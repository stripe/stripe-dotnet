#if NET6_0_OR_GREATER
namespace StripeTests.Wholesome
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text.Json.Serialization;
    using Stripe;
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
                        var ret = SystemTextJsonTestUtils.HasCorrectConverterType(typeArg, typeArg);
                        if (ret != null)
                        {
                            results.Add(
                                $"{typeArg.FullName}, expected = {ret.Item1}, "
                                    + $"actual = {ret.Item2}");
                        }
                    }
                }
            }

            var message = $"{AssertionMessage}\n{results.Count} affected classes: {string.Join(",", results)}";
            AssertEmpty(results, message);
        }
    }
}
#endif
