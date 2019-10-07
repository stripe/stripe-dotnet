#if NETCOREAPP
namespace StripeTests
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

    /// <summary>
    /// This wholesome test ensures that `JsonProperty` attributes in options classes have names
    /// that match their property's name. E.g. if the property's name is `FooBar`, then the JSON
    /// name should be `foo_bar`.
    /// </summary>
    public class JsonNamesMatchPropertyNames : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one JsonProperty name mismatched with its property name.";

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            // Get all classes that implement INestedOptions
            var stripeClasses = GetClassesWithInterface(typeof(INestedOptions));

            foreach (Type stripeClass in stripeClasses)
            {
                foreach (PropertyInfo property in stripeClass.GetProperties())
                {
                    var propType = property.PropertyType;

                    // Skip properties that don't have a `JsonProperty` attribute
                    var jsonPropertyAttribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                    if (jsonPropertyAttribute == null)
                    {
                        continue;
                    }

                    var snakeCasedPropName = Stripe.Infrastructure.StringUtils.ToSnakeCase(property.Name);

                    // Skip properties when the property name matches the JSON name
                    if (jsonPropertyAttribute.PropertyName == snakeCasedPropName)
                    {
                        continue;
                    }

                    // Skip properties that have a `AllowNameMismatch` attribute
                    var allowMismatchAttribute = property.GetCustomAttribute<AllowNameMismatch>();
                    if (allowMismatchAttribute != null)
                    {
                        continue;
                    }

                    results.Add($"{stripeClass.Name}.{property.Name}: {jsonPropertyAttribute.PropertyName} != {snakeCasedPropName}");
                }
            }

            AssertEmpty(results, AssertionMessage);
        }
    }
}
#endif
