#if NET6_0_OR_GREATER
namespace StripeTests.Wholesome
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Text.Json.Serialization;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    /// <summary>
    /// This wholesome test ensures that types used in enumerables (List, StripeList) that require
    /// custom converters have the correct converters specified.  This is important because
    /// System.Text.Json will by default use the declared type, and not the actual concrete type
    /// of the object, to determine how to Serialize.
    /// </summary>
    public class CorrectJsonConvertersForEnumerableItemTypes : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one property with a missing or incorrect [JsonConverter] attribute.";

        [Fact]
        public void Check()
        {
            var results = new List<string>();

            // Get all classes that derive from StripeEntity or implement INestedOptions
            var stripeClasses = GetSubclassesOf(typeof(StripeEntity));
            stripeClasses.AddRange(GetClassesWithInterface(typeof(INestedOptions)));

            foreach (var stripeClass in stripeClasses)
            {
                foreach (var property in GetPropertiesToCheck(stripeClass))
                {
                    var propType = property.PropertyType;
                    if (Nullable.GetUnderlyingType(propType) != null)
                    {
                        propType = Nullable.GetUnderlyingType(propType);
                    }

                    // Skip properties that don't have a `JsonProperty` attribute
                    var jsonPropertyAttribute = property.GetCustomAttribute<JsonPropertyNameAttribute>();
                    if (jsonPropertyAttribute == null)
                    {
                        continue;
                    }

                    // Skip any proeprty that isn't an IEnumerable
                    if (!typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(propType.GetTypeInfo()))
                    {
                        continue;
                    }

                    // Skip any non-generic IEnumerables, since we wont be able to tell what
                    // type the items are.
                    if (propType.GenericTypeArguments.Length == 0)
                    {
                        continue;
                    }

                    foreach (var typeArg in propType.GenericTypeArguments)
                    {
                        CheckExpectedConverterType(typeArg, results);
                    }
                }
            }

            var message = $"{AssertionMessage}\n{results.Count} affected classes: {string.Join(",", results)}";
            AssertEmpty(results, message);
        }

        private static void CheckExpectedConverterType(Type type, List<string> results)
        {
            Type expectedConverterType = null;
            Type[] expectedGenericTypeArguments = null;

            // In V1 DateTime properties require a UnixDateTimeConverter, in V2
            // datetime conversion is handled by Newtonsoft.Json
            // Note that the Stripe.Events namespace contains V2 events; there are
            // some whos name starts with V1 but those are V1 payloads inside V2
            // style events.
            if (typeof(IAnyOf).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
            {
                expectedConverterType = typeof(STJAnyOfConverter);
            }
            else if (typeof(IExpandableField).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
            {
                // because the annotation is going above a class, we don't have
                // access to the specific type parameter for the expandable field
                // so we add the annotation with <IHasId> as the parameter, and it
                // just works.
                expectedConverterType = typeof(STJExpandableFieldConverter<>);
                expectedGenericTypeArguments = new Type[] { typeof(IHasId) };
            }
            else if (type.GetTypeInfo().IsInterface)
            {
                expectedConverterType = typeof(STJStripeObjectConverter);
            }

            var expectedConverterName = GetConverterName(
                expectedConverterType,
                expectedGenericTypeArguments);

            Type actualConverterType = null;
            Type[] actualGenericTypeArguments = null;

            // For this check, we are looking for the attribute on the class/type that is passed in.
            var jsonConverterAttribute = type.GetCustomAttribute<JsonConverterAttribute>();
            if (jsonConverterAttribute != null)
            {
                actualConverterType = jsonConverterAttribute.ConverterType;
                actualGenericTypeArguments = actualConverterType.GenericTypeArguments;
            }

            var actualConverterName = GetConverterName(
                actualConverterType,
                actualGenericTypeArguments);

            if (expectedConverterName == actualConverterName)
            {
                return;
            }

            results.Add(
                $"{type.FullName}, expected = {expectedConverterName}, "
                    + $"actual = {actualConverterName}");
        }

        private static string GetConverterName(Type type, Type[] genericTypeArguments)
        {
            if (type == null)
            {
                return "null";
            }

            var sb = new StringBuilder();
            sb.Append(type.Name);

            if (genericTypeArguments != null && genericTypeArguments.Length > 0)
            {
                sb.Append("<");
                sb.Append(string.Join(", ", genericTypeArguments.Select(t => t.Name)));
                sb.Append(">");
            }

            return sb.ToString();
        }
    }
}
#endif
