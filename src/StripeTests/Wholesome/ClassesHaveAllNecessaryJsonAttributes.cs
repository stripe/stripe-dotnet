namespace StripeTests.Wholesome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Stripe;
    using Xunit;

#if NET6_0_OR_GREATER
    using Stripe.Infrastructure;
    using Stripe.Infrastructure.FormEncoding;
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// This wholesome test ensures that if a class has Newtonsoft JSON attributes, it also has
    /// all other necessary/equivalent attributes (i.e. for System.Text.Json support)
    /// attributes.
    /// </summary>
    public class ClassesHaveAllNecessaryJsonAttributes : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one class that is missing necessary attributes.";

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

                var hasCorrectAttributes = true;
#if NET6_0_OR_GREATER
                var isIEnumerable = typeof(System.Collections.IEnumerable).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo());
                var isEntity = typeof(StripeEntity).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo());

                if (isIEnumerable && isEntity)
                {
                    var converter = type.GetCustomAttribute(typeof(STJS.JsonConverterAttribute), false) as STJS.JsonConverterAttribute;
                    if (converter?.ConverterType != typeof(STJEnumerableObjectConverter))
                    {
                        hasCorrectAttributes = false;
                    }
                }
#endif

                if (hasCorrectAttributes)
                {
                    var attributes = type.GetCustomAttributes(false).Cast<Attribute>();
                    foreach (Attribute attribute in attributes)
                    {
                        if (attribute.GetType().Namespace.StartsWith("Newtonsoft", true, null))
                        {
#if NET6_0_OR_GREATER
                            // we assume classes are public if they have json attributes
                            hasCorrectAttributes = SystemTextJsonTestUtils.HasCorrectAttributes(attribute, attributes, true);
                            if (!hasCorrectAttributes)
                            {
                                break;
                            }
#endif
                        }
                    }
                }

                if (!hasCorrectAttributes)
                {
                    results.Add($"{type.FullName}");
                }
            }

            var message = $"{AssertionMessage}\n{results.Count} affected classes: {string.Join(",", results)}";
            AssertEmpty(results, message);
        }
    }
}
