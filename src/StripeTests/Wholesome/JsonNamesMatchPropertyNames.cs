namespace StripeTests.Wholesome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// This wholesome test ensures that `JsonProperty` attributes in entity and options classes
    /// have names that match their property's name. E.g. if the property's name is `FooBar`, then
    /// the JSON name should be `foo_bar`.
    /// </summary>
    /// <remarks>
    /// At the moment this test only checks `public` properties. `internal` properties, such as
    /// the ones used for expandable fields, are ignored. This should be fixed, but handling
    /// expandable fields will require more complex handling.
    /// </remarks>
    public class JsonNamesMatchPropertyNames : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one JsonProperty name mismatched with its property name.";

        // Map of words that have a non-standard snake_case -> PascalCase transformation. This is
        // mostly useful for two-letter acronyms, which should stay capitalized per Microsoft's
        // recommendations: https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/capitalization-conventions#capitalization-rules-for-identifiers.
        private static Dictionary<string, string> overrides = new Dictionary<string, string>
        {
            // Commented out as we prefer to standardize on `Ip` for the moment to minimize breaking changes.
            // { "ip", "IP" },
        };

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            // Get all classes that derive from StripeEntity or implement INestedOptions
            var stripeClasses = GetSubclassesOf(typeof(StripeEntity));
            stripeClasses.AddRange(GetClassesWithInterface(typeof(INestedOptions)));

            foreach (Type stripeClass in stripeClasses)
            {
                foreach (PropertyInfo property in GetPropertiesToCheck(stripeClass))
                {
                    var propType = property.PropertyType;

                    // Skip properties that don't have a `JsonProperty` attribute
                    var jsonPropertyAttribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                    if (jsonPropertyAttribute == null)
                    {
                        continue;
                    }

                    var propertyName = property.Name;

                    // expandable field json properties are prefixed with with Internal so
                    // that they don't conflict with the public properties we expose to the
                    // user
                    var toStrip = "Internal";
                    if (propertyName.StartsWith(toStrip))
                    {
                        propertyName = propertyName.Substring(toStrip.Length);
                    }

                    var pascalCasedJsonName = ToPascalCase(jsonPropertyAttribute.PropertyName);
                    var hasCorrectJsonPropertyName = false;

                    // Skip properties when the property name matches the JSON name
                    if (propertyName == pascalCasedJsonName)
                    {
                        hasCorrectJsonPropertyName = true;
                    }

#if NET6_0_OR_GREATER
                    var stjsJsonPropertyNameAttribute = property.GetCustomAttribute<STJS.JsonPropertyNameAttribute>();

                    // Only check if there is a stjs property name attribute; another test will check
                    // that the necessary attributes are present
                    if (stjsJsonPropertyNameAttribute != null)
                    {
                        // Error on properties where the STJ property name doesn't match the Newtonsoft property name
                        if (jsonPropertyAttribute.PropertyName != stjsJsonPropertyNameAttribute?.Name)
                        {
                            hasCorrectJsonPropertyName = false;
                        }
                    }
#endif
                    if (hasCorrectJsonPropertyName)
                    {
                        continue;
                    }

                    // Skip properties that have a `AllowNameMismatch` attribute
                    var allowMismatchAttribute = property.GetCustomAttribute<AllowNameMismatch>();
                    if (allowMismatchAttribute != null)
                    {
                        continue;
                    }

                    results.Add($"{stripeClass.Name}.{property.Name}");
                }
            }

            var message = $"{AssertionMessage}\n{results.Count} affected properties: {string.Join(",", results)}";
            AssertEmpty(results, message);
        }

        private static string ToPascalCase(string snakeCase)
        {
            return snakeCase.Split('_')
                .Select(s =>
                    overrides.ContainsKey(s)
                        ? overrides[s]
                        : char.ToUpperInvariant(s[0]) + s.Substring(1, s.Length - 1))
                .Aggregate(string.Empty, (s1, s2) => s1 + s2);
        }
    }
}
