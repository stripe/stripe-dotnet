#if NET6_0_OR_GREATER
namespace StripeTests.Wholesome
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using Castle.DynamicProxy.Internal;
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Events;
    using Stripe.Infrastructure;
    using Stripe.V2;
    using Xunit;

    using STJ = System.Text.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// This wholesome test ensures that for all StripeEntity classes, both Json.NET and
    /// System.Text.Json serialize equivalent objects.  Equivalent objects have the same
    /// keys and data formats, but not necessarily in the same order when converted to
    /// string.
    ///
    /// Note that this is a very slow test, as it takes a lot of time to generate the test data.
    /// </summary>
    public class NewtonsoftAndSystemTextJsonOutputTheSameObject : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one class that serializes differently between Newtonsoft and System.Text.Json.";

        private const string GenericTypeAssertionMessage =
            "Found at least one generic type that is not checked.";

        private void CheckOneStripeClass<T>(T instance, List<string> results)
        {
            var jsonNet = JsonUtils.SerializeObject(
                instance,
                Formatting.None,
                StripeConfiguration.SerializerSettings);

            var systemTextJson = STJ.JsonSerializer.Serialize(instance);

            if (jsonNet != systemTextJson)
            {
                // Json.NET and STJ serialize doubles that can be represented as integers
                // differently: Json.NET will add a trailing .0, whereas STJ by default
                // will not.  For this test, if a straight comparison fails, lets try
                // and strip the .0 in the jsonNet string.
                jsonNet = jsonNet.Replace(".0,", ",").Replace(".0}", "}");
                if (jsonNet != systemTextJson)
                {
                    results.Add($"{instance.GetType().FullName}");
                }
            }
        }

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            var stripeClasses = GetSubclassesOf(typeof(StripeEntity));
            stripeClasses.AddRange(GetClassesWithInterface(typeof(INestedOptions)));
            var genericTypes = new List<Type>();
            var expandableObjectCache = new Dictionary<Type, object>();
            foreach (TypeInfo stripeClass in stripeClasses)
            {
                expandableObjectCache[stripeClass] = null;
            }

            var typesWithExpandableFields = new List<Type>();

            foreach (TypeInfo stripeClass in stripeClasses)
            {
                if (stripeClass.FullName.Contains("Stripe.StripeEntity"))
                {
                    // Skip StripeEntity and StripeEntity<T>
                    continue;
                }

                if (stripeClass.Name.StartsWith("V1Billing"))
                {
                    Debugger.Break();
                }

                if (stripeClass.IsGenericType)
                {
                    // Handle generic types (container types) separately, because
                    // they need to be instantiated with concrete type parameters
                    // and there aren't that many.
                    genericTypes.Add(stripeClass);
                    continue;
                }

                // First, check that empty objects serialize correctly

                // be careful with casts or explicit types here; explicit casts here will color
                // the behavior of STJ Serialize
                var instance = Activator.CreateInstance(stripeClass);
                this.CheckOneStripeClass(instance, results);

                // Next, fill the object with some reasonable defaults and check agian
                this.PopulateWithReasonableDefaults(instance, null, expandableObjectCache);
                this.CheckOneStripeClass(instance, results);

                expandableObjectCache[stripeClass] = instance;

                foreach (var property in GetPropertiesToCheck(stripeClass))
                {
                    if (typeof(IExpandableField).GetTypeInfo().IsAssignableFrom(property.PropertyType))
                    {
                        if (!typesWithExpandableFields.Contains(stripeClass))
                        {
                            typesWithExpandableFields.Add(stripeClass);
                        }
                    }
                }
            }

            foreach (TypeInfo stripeClass in typesWithExpandableFields)
            {
                // be careful with casts or explicit types here; explicit casts here will color
                // the behavior of STJ Serialize
                var instance = Activator.CreateInstance(stripeClass);

                // Next, fill the object with some reasonable defaults and check agian
                this.PopulateWithReasonableDefaults(instance, null, expandableObjectCache);
                this.CheckOneStripeClass(instance, results);
            }

            // Test the generic containers: StripeList, V2.StripeList, StripeSearchResults
            this.CheckGenericTypes(genericTypes, results);

            var message = $"{AssertionMessage}\n{results.Count} affected classes: {string.Join(",", results)}";
            AssertEmpty(results, message);

            message = $"{GenericTypeAssertionMessage}\n{results.Count} affected classes: {string.Join(",", results)}";
            AssertEmpty(genericTypes.Select(t => t.Name).ToList(), message);
        }

        private object GetPopulatedObject(Type type, List<Type> seen, Dictionary<Type, object> expandedObjectCache)
        {
            if (type.IsNullableType())
            {
                return this.GetPopulatedObject(type.GenericTypeArguments[0], seen, expandedObjectCache);
            }

            if (type == typeof(bool))
            {
                return true;
            }
            else if (type == typeof(long))
            {
                return 123456L;
            }
            else if (type == typeof(double))
            {
                return 1.1;
            }
            else if (type == typeof(string))
            {
                return "aaaa";
            }
            else if (type == typeof(DateTime))
            {
                return DateTime.Now;
            }
            else if (type == typeof(decimal))
            {
                return 2.1m;
            }
            else if (typeof(IAnyOf).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
            {
                var anyOfClass = this.SelectOneOf(type.GenericTypeArguments, seen);
                if (anyOfClass == null)
                {
                    // We've seen all the possible types; return null here
                    return null;
                }

                seen.Add(anyOfClass);
                var propValue = this.GetPopulatedObject(anyOfClass, seen, expandedObjectCache);
                return Activator.CreateInstance(type, propValue);
            }
            else if (typeof(IExpandableField).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
            {
                IExpandableField propValue = (IExpandableField)Activator.CreateInstance(type);
                propValue.Id = "obj_123";
                if (type.GenericTypeArguments.Length > 0)
                {
                    var objectType = type.GenericTypeArguments[0];
                    if (expandedObjectCache.ContainsKey(objectType))
                    {
                        propValue.ExpandedObject = expandedObjectCache[objectType];
                    }
                    else
                    {
                        propValue.ExpandedObject = this.GetPopulatedObject(objectType, seen, expandedObjectCache);
                        expandedObjectCache[objectType] = propValue.ExpandedObject;
                    }
                }

                return propValue;
            }
            else if (typeof(StringEnum).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
            {
                var enumValues = type.GetFields(BindingFlags.Public | BindingFlags.Static);
                return enumValues[0].GetValue(null);
            }
            else if (type == typeof(System.IO.Stream))
            {
                // neither JSON library supports serializing Streams without a custom converter
                // which we currently do not support within Stripe.net (we use the
                // MultipartFormDataContent type for sending streams across the network).
                return null;
            }
            else if (typeof(IList).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
            {
                var propValue = (IList)Activator.CreateInstance(type);
                this.PopulateWithReasonableDefaults(propValue, seen, expandedObjectCache);
                if (type.GenericTypeArguments.Length > 0)
                {
                    // Add some elements to the list
                    var objectType = type.GenericTypeArguments[0];
                    var value = this.GetPopulatedObject(objectType, seen, expandedObjectCache);
                    if (value != null)
                    {
                        propValue.Add(value);
                        value = this.GetPopulatedObject(objectType, seen, expandedObjectCache);
                        if (value != null)
                        {
                            propValue.Add(value);
                        }
                    }
                }

                return propValue;
            }
            else if (typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
            {
                var propValue = Activator.CreateInstance(type);
                this.PopulateWithReasonableDefaults(propValue, seen, expandedObjectCache);
                return propValue;
            }
            else if (type.IsClass)
            {
                if (seen.Contains(type))
                {
                    return null;
                }

                seen.Add(type);
                var propValue = Activator.CreateInstance(type);
                this.PopulateWithReasonableDefaults(propValue, seen, expandedObjectCache);
                return propValue;
            }
            else if (type.IsInterface)
            {
                // Pick the first subclass of this interface we havent seen yet.
                var classes = GetClassesWithInterface(type);
                var selected = this.SelectOneOf(classes, seen);
                if (selected == null)
                {
                    // We've seen all the possible types; return null here
                    return null;
                }

                seen.Add(selected);
                var propValue = Activator.CreateInstance(selected);
                this.PopulateWithReasonableDefaults(propValue, seen, expandedObjectCache);
                return propValue;
            }
            else
            {
                throw new Exception($"Unknown property type {type}");
            }
        }

        private Type SelectOneOf(IEnumerable<Type> availableTypes, List<Type> seen)
        {
            foreach (var type in availableTypes)
            {
                if (!seen.Contains(type))
                {
                    return type;
                }
            }

            return null;
        }

        private T PopulateWithReasonableDefaults<T>(T instance, List<Type> seen, Dictionary<Type, object> expandedObjectCache)
        {
            expandedObjectCache = expandedObjectCache ?? new Dictionary<Type, object>();
            foreach (var property in GetPropertiesToCheck(instance.GetType()))
            {
                if (property.GetCustomAttribute(typeof(STJS.JsonPropertyNameAttribute), false) == null)
                {
                    continue;
                }

                if (!property.CanWrite)
                {
                    continue;
                }

                var propertyType = property.PropertyType;
                var newValue = this.GetPopulatedObject(propertyType, seen?.ToList() ?? new List<Type>(), expandedObjectCache);
                property.SetValue(instance, newValue);
            }

            return instance;
        }

        private void CheckGenericTypes(List<Type> genericTypes, List<string> results)
        {
            var customer1 = new Customer
            {
                Id = "cust_123",
                Object = "customer",
                Name = "Jenny Rosen",
                Email = "jrosen@example.com",
            };
            var customer2 = new Customer
            {
                Id = "cust_124",
                Object = "customer",
                Name = "John Smith",
                Email = "john@example.com",
            };
            var customer3 = new Customer
            {
                Id = "cust_125",
                Object = "customer",
                Name = "Jenny Rosen",
                Email = "jrosen@example.com",
            };

            var list = new Stripe.StripeList<Customer>
            {
                Object = "list_object",
                Data = new List<Customer>
                {
                    customer1, customer2, customer3,
                },
                HasMore = true,
                Url = "/v1/customers",
            };

            this.CheckOneStripeClass(list, results);
            var listType = list.GetType();
            genericTypes.RemoveAll(gt => listType.FullName.StartsWith(gt.FullName));

            // This also tests polymorphic types like V2.Event within
            // the list
            var v2List = new Stripe.V2.StripeList<Stripe.V2.Event>
            {
                Data = new List<Stripe.V2.Event>
                {
                    this.PopulateWithReasonableDefaults(new V1BillingMeterErrorReportTriggeredEvent(), null, new Dictionary<Type, object>()),
                    this.PopulateWithReasonableDefaults(new V1BillingMeterErrorReportTriggeredEvent(), null, new Dictionary<Type, object>()),
                    this.PopulateWithReasonableDefaults(new V1BillingMeterErrorReportTriggeredEvent(), null, new Dictionary<Type, object>()),
                },
                NextPageUrl = "/v2/customers?page=1234",
                PreviousPageUrl = null,
            };

            this.CheckOneStripeClass(v2List, results);
            var v2ListType = v2List.GetType();
            genericTypes.RemoveAll(gt => v2ListType.FullName.StartsWith(gt.FullName));

            var searchResult = new Stripe.StripeSearchResult<Customer>
            {
                Object = "search_result",
                Data = new List<Customer>
                {
                    customer1, customer2, customer3,
                },
                HasMore = true,
                NextPage = "1234",
                TotalCount = 12,
                Url = "/v1/customers",
            };

            this.CheckOneStripeClass(searchResult, results);
            var searchResultType = searchResult.GetType();
            genericTypes.RemoveAll(gt => searchResultType.FullName.StartsWith(gt.FullName));
        }
    }
}
#endif
