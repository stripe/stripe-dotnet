namespace StripeTests.Wholesome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// This test checks that <see cref="Stripe.StripeEntity" /> subclasses that have a
    /// <c>Deleted</c> property have <see cref="Newtonsoft.Json.NullValueHandling" />
    /// set to <see cref="Newtonsoft.Json.NullValueHandling.Ignore" /> so that the property is not
    /// serialized when its value is <c>null</c>.
    /// </summary>
    public class DontSerializeNullDeletedAttrs : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one invalid Deleted property. Make sure that the property " +
            "has a JsonPropertyAttribute and that NullValueHandling is set to Ignore.";

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();
            List<string> skipTheseClasses = new List<string>
            {
                // For some reason, Secret.Deleted is not nullable
                "Stripe.Apps.Secret",
            };

            // Get all StripeEntity subclasses
            var entityClasses = GetSubclassesOf(typeof(StripeEntity));

            foreach (Type entityClass in entityClasses)
            {
                foreach (PropertyInfo property in entityClass.GetProperties())
                {
                    if (property.Name != "Deleted")
                    {
                        continue;
                    }

                    // Check that property has a JsonPropertyAttribute
                    var attribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                    if (attribute == null)
                    {
                        continue;
                    }

                    // Check that NullValueHanding is set to Ignore
                    bool hasNullValueHandling = attribute.NullValueHandling == NullValueHandling.Ignore;
#if NET6_0_OR_GREATER
                    if (!skipTheseClasses.Contains(entityClass.FullName))
                    {
                        // This feature is implemented as part of JsonIgnore in STJ; make sure
                        // we have the correct ignore w/ condition.
                        // TODO: move to SystemTextJsonTestUtils
                        var stjAttribute = property.GetCustomAttribute<STJS.JsonIgnoreAttribute>();
                        if (stjAttribute == null || stjAttribute.Condition != STJS.JsonIgnoreCondition.WhenWritingNull)
                        {
                            hasNullValueHandling = false;
                        }
                    }
#endif

                    if (!hasNullValueHandling)
                    {
                        results.Add($"{entityClass.Name}.{property.Name}");
                    }
                }
            }

            if (results.Any())
            {
                // Sort results alphabetically
                results = results.OrderBy(i => i).ToList();

                // Display our own error message (because Assert.Empty truncates the results)
                Console.WriteLine("Found invalid Deleted properties:");
                foreach (string item in results)
                {
                    Console.WriteLine($"- {item}");
                }

                // Actually fail test
                var message = $"{AssertionMessage}\n{results.Count} affected properties: {string.Join(",", results)}";
                Assert.True(false, message);
            }
        }
    }
}
