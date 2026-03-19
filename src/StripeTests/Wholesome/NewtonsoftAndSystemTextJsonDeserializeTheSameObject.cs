namespace StripeTests.Wholesome
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
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
    /// System.Text.Json produce equivalent objects when deserializing the same JSON input.
    ///
    /// The approach:
    /// 1. Create a populated instance of each entity type
    /// 2. Serialize it to JSON (using STJ as the canonical format)
    /// 3. Deserialize the JSON with both Newtonsoft and STJ
    /// 4. Re-serialize both results with STJ and compare
    ///
    /// This validates Step 1.4 of the STJ migration plan.
    /// </summary>
    public class NewtonsoftAndSystemTextJsonDeserializeTheSameObject : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one class that deserializes differently between Newtonsoft and System.Text.Json.";

        private void CheckOneStripeClass(Type type, string json, List<string> results)
        {
            // Deserialize with Newtonsoft
            object newtonsoftObj;
            try
            {
#pragma warning disable CS0618 // Type or member is obsolete
                newtonsoftObj = JsonConvert.DeserializeObject(
                    json,
                    type,
                    StripeConfiguration.SerializerSettings);
#pragma warning restore CS0618 // Type or member is obsolete
            }
            catch (Exception ex)
            {
                results.Add($"{type.FullName} (Newtonsoft deser failed: {ex.Message})");
                return;
            }

            // Deserialize with STJ
            object stjObj;
            try
            {
                stjObj = STJ.JsonSerializer.Deserialize(
                    json,
                    type,
                    StripeConfiguration.SerializerOptions);
            }
            catch (Exception ex)
            {
                results.Add($"{type.FullName} (STJ deser failed: {ex.Message})");
                return;
            }

            // Re-serialize both with STJ and compare
            var newtonsoftReserialized = STJ.JsonSerializer.Serialize(newtonsoftObj, type);
            var stjReserialized = STJ.JsonSerializer.Serialize(stjObj, type);

            if (newtonsoftReserialized != stjReserialized)
            {
                results.Add($"{type.FullName}");
            }
        }

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            var stripeClasses = GetSubclassesOf(typeof(StripeEntity));

            // Event types use fundamentally different deserialization strategies
            // between Newtonsoft and STJ (STJ uses custom converters for polymorphic
            // dispatch that Newtonsoft doesn't have, and vice versa).
            var typesToSkip = new HashSet<Type>
            {
                typeof(Event),
                typeof(EventData),
            };

            // V2 event types also use different converter strategies
            var v2EventBase = typeof(Stripe.V2.Core.Event);
            var v2NotificationBase = typeof(Stripe.V2.Core.EventNotification);

            var expandableObjectCache = new Dictionary<Type, object>();
            foreach (TypeInfo stripeClass in stripeClasses)
            {
                expandableObjectCache[stripeClass] = null;
            }

            foreach (TypeInfo stripeClass in stripeClasses)
            {
                if (stripeClass.FullName.Contains("Stripe.StripeEntity"))
                {
                    continue;
                }

                if (typesToSkip.Contains(stripeClass))
                {
                    continue;
                }

                if (v2EventBase.IsAssignableFrom(stripeClass) ||
                    v2NotificationBase.IsAssignableFrom(stripeClass))
                {
                    continue;
                }

                if (stripeClass.IsGenericType)
                {
                    continue;
                }

                // Create a populated instance
                var instance = Activator.CreateInstance(stripeClass);
                this.PopulateWithReasonableDefaults(instance, null, expandableObjectCache);
                expandableObjectCache[stripeClass] = instance;

                // Serialize to JSON with STJ using SerializerOptions so
                // opt-in serialization converters are active.
                var json = STJ.JsonSerializer.Serialize(
                    instance, stripeClass.AsType(), StripeConfiguration.SerializerOptions);

                // Skip empty objects — nothing meaningful to test
                if (json == "{}" || json == "null")
                {
                    continue;
                }

                this.CheckOneStripeClass(stripeClass, json, results);
            }

            var message = $"{AssertionMessage}\n{results.Count} affected classes: {string.Join(",", results)}";
            AssertEmpty(results, message);
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
                return null;
            }
            else if (typeof(IList).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
            {
                var propValue = (IList)Activator.CreateInstance(type);
                this.PopulateWithReasonableDefaults(propValue, seen, expandedObjectCache);
                if (type.GenericTypeArguments.Length > 0)
                {
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
                var classes = GetClassesWithInterface(type);
                var selected = this.SelectOneOf(classes, seen);
                if (selected == null)
                {
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
    }
}
