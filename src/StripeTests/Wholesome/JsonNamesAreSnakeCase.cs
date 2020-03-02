namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    /// <summary>
    /// This wholesome test ensures that no entity or options class reuses the same name in
    /// different `JsonProperty` attributes.
    /// </summary>
    public class JsonNamesAreSnakeCase : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one invalid JsonProperty name.";

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            // Get all classes that derive from StripeEntity or implement INestedOptions
            var stripeClasses = GetSubclassesOf(typeof(StripeEntity));
            stripeClasses.AddRange(GetClassesWithInterface(typeof(INestedOptions)));

            foreach (Type stripeClass in stripeClasses)
            {
                foreach (PropertyInfo property in stripeClass.GetProperties())
                {
                    var propType = property.PropertyType;

                    // Skip properties that don't have a `JsonProperty` attribute
                    var attribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                    if (attribute == null)
                    {
                        continue;
                    }

                    var match = Regex.Match(attribute.PropertyName, "^[a-z0-9][a-z0-9_]*$");

                    if (!match.Success)
                    {
                        results.Add($"{stripeClass.Name}.{property.Name}");
                    }
                }
            }

            AssertEmpty(results, AssertionMessage);
        }
    }
}
