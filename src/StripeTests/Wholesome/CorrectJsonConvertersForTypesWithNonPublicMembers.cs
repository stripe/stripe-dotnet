#if NET6_0_OR_GREATER
namespace StripeTests.Wholesome
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Reflection;
    using System.Text.Json.Serialization;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    /// <summary>
    /// Checks that classes with non-public properties with Json attributes
    /// have STJMemberSerializationOptIn custom converter.
    /// </summary>
    public class CorrectJsonConvertersForTypesWithNonPublicMembers : WholesomeTest
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
                    // Skip properties that don't have a `JsonProperty` attribute
                    var jsonPropertyAttribute = property.GetCustomAttribute<JsonPropertyNameAttribute>();
                    if (jsonPropertyAttribute == null)
                    {
                        continue;
                    }

                    if (!property.IsNotPublic)
                    {
                        continue;
                    }

                    // Check the class attributes; JsonConverter must be specified STJMemberSerializationOptIn
                    var jsonConverterAttribute = stripeClass.GetCustomAttribute<JsonConverterAttribute>();
                    if (jsonConverterAttribute == null || jsonConverterAttribute.ConverterType != typeof(STJMemberSerializationOptIn))
                    {
                        results.Add($"{stripeClass.FullName}");
                    }

                    // If we get here, we can move on to the next class
                    break;
                }
            }

            var message = $"{AssertionMessage}\n{results.Count} affected classes: {string.Join(",", results)}";
            AssertEmpty(results, message);
        }
    }
}
#endif
