namespace StripeTests.Wholesome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Stripe;
    using Xunit;

    /// <summary>
    /// This wholesome test ensures that if a property has Newtonsoft JSON attributes, it also has
    /// all other necessary/equivalent attributes (i.e. for System.Text.Json support)
    /// attributes.
    /// </summary>
    public class PropertiesHaveAllNecessaryJsonAttributes : WholesomeTest
    {
        // TODO(jar): update to include JsonExtensionData, and STJ attributes
        private const string AssertionMessage =
            "Found at least one class with a Json*Attribute that is missing other necessary (e.g. System.Text.Json) attributes.";

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            // Get all classes in the Stripe namespace
            var assembly = typeof(StripeEntity).Assembly;
            var types = assembly.DefinedTypes.Where(t => t.FullName.StartsWith("Stripe."));
            foreach (TypeInfo type in types)
            {
                foreach (ExtendedPropertyInfo property in GetPropertiesToCheck(type))
                {
                    if (property.GetCustomAttribute(typeof(NoSystemTextJsonAttributesNeededAttribute), false) != null)
                    {
                        continue;
                    }

                    foreach (Attribute attribute in property.GetCustomAttributes())
                    {
                        if (attribute.GetType().Namespace.StartsWith("Newtonsoft", true, null))
                        {
#if NET6_0_OR_GREATER
                            bool hasCorrectAttributes = SystemTextJsonTestUtils.HasCorrectAttributes(attribute, property.GetCustomAttributes(), property.IsNotPublic);
                            if (!hasCorrectAttributes)
                            {
                                results.Add($"{type.FullName}.{property.Name}");
                            }
#endif
                        }
                    }
                }
            }

            var message = $"{AssertionMessage}\n{results.Count} affected properties: {string.Join(",", results)}";
            AssertEmpty(results, message);
        }
    }
}
