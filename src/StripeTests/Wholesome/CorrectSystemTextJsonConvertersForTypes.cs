#if NET6_0_OR_GREATER
namespace StripeTests.Wholesome
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    /// <summary>
    /// This wholesome test ensures that properties with types that require custom converters to
    /// use the correct custom converter.  This checks the System.Text.Json attributes; see
    /// CorrectJsonConvertersForTypes for the Newtonsoft Json checks.
    /// </summary>
    public class CorrectSystemTextJsonConvertersForTypes : WholesomeTest
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

                    // Skip properties that don't have a `JsonPropertyName` attribute
                    // FIXME: this seems like an unnecessary test; why would we have a converter without a property name?
                    var jsonPropertyNameAttribute = property.GetCustomAttribute<JsonPropertyNameAttribute>();
                    if (jsonPropertyNameAttribute == null)
                    {
                        continue;
                    }

                    var ret = SystemTextJsonTestUtils.HasCorrectConverterType(propType, property);
                    if (ret != null)
                    {
                        results.Add(
                            $"{stripeClass.Name}.{property.Name}, expected = {ret.Item1}, "
                                + $"actual = {ret.Item2}");
                    }
                }
            }

            var message = $"{AssertionMessage}\n{results.Count} affected properties: {string.Join(",", results)}";
            AssertEmpty(results, message);
        }
    }
}
#endif
