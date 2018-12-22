#if NETCOREAPP
namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    /// <summary>
    /// This test checks that all properties in request parameter classes (i.e. classes that
    /// implement <see cref="Stripe.INestedOptions" />) with value types are nullable. This ensures
    /// that only values explicitly set by users are sent to Stripe's API.
    /// </summary>
    public class NullableValueTypes : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one non-nullable value type";

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            // Get all classes that implement INestedOptions
            var optionsClasses = GetClassesWithInterface(typeof(INestedOptions));

            foreach (Type optionsClass in optionsClasses)
            {
                foreach (PropertyInfo property in optionsClass.GetProperties())
                {
                    var propType = property.PropertyType;

                    // Skip properties that don't have a `JsonProperty` attribute
                    var attribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                    if (attribute == null)
                    {
                        continue;
                    }

                    // Skip non-value types
                    if (!propType.GetTypeInfo().IsValueType)
                    {
                        continue;
                    }

                    // Skip value types that are already nullable
                    if (propType.GetTypeInfo().IsGenericType &&
                        propType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        continue;
                    }

                    results.Add($"{optionsClass.Name}.{property.Name}");
                }
            }

            AssertEmpty(results, AssertionMessage);
        }
    }
}
#endif
