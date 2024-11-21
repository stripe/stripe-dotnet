namespace StripeTests.Wholesome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Stripe;
    using Xunit;

    /// <summary>
    /// This wholesome test ensures that if a class has Newtonsoft JSON attributes, it also has
    /// all other necessary/equivalent attributes (i.e. for System.Text.Json support)
    /// attributes.
    /// </summary>
    public class ClassesHaveAllNecessaryJsonAttributes : WholesomeTest
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
                if (type.GetCustomAttribute(typeof(NoSystemTextJsonAttributesNeededAttribute), false) != null)
                {
                    continue;
                }

                foreach (Attribute attribute in type.GetCustomAttributes(false))
                {
                    if (attribute.GetType().Namespace.StartsWith("Newtonsoft", true, null))
                    {
#if NET6_0_OR_GREATER
                        // we assume classes are public if they have json attributes
                        bool hasCorrectAttributes = SystemTextJsonTestUtils.HasCorrectAttributes(attribute, type.GetCustomAttributes(false) as IEnumerable<Attribute>, true);
                        if (!hasCorrectAttributes)
                        {
                            results.Add($"{type.FullName}");
                        }
#endif
                    }
                }
            }

            var message = $"{AssertionMessage}\n{results.Count} affected classes: {string.Join(",", results)}";
            AssertEmpty(results, message);
        }
    }
}
