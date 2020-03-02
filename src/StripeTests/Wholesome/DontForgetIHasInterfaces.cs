namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Stripe;
    using Xunit;

    /// <summary>
    /// This wholesome test ensures that all Stripe entity and options classes implement the
    /// <c>IHasX</c> interfaces when they have matching properties.
    /// </summary>
    public class DontForgetIHasInterfaces : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one missing interface.";

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            // Get all classes that derive from StripeEntity or implement INestedOptions
            var stripeClasses = GetSubclassesOf(typeof(StripeEntity));
            stripeClasses.AddRange(GetClassesWithInterface(typeof(INestedOptions)));

            foreach (Type stripeClass in stripeClasses)
            {
                var interfaces = stripeClass.GetInterfaces();

                foreach (PropertyInfo property in stripeClass.GetProperties())
                {
                    // Check for IHasId
                    if ((property.Name == "Id") && (property.PropertyType == typeof(string)))
                    {
                        if (!interfaces.Contains(typeof(IHasId)))
                        {
                            results.Add($"{stripeClass.Name} is missing IHasId");
                        }
                    }

                    // Check for IHasObject
                    if ((property.Name == "Object") && (property.PropertyType == typeof(string)))
                    {
                        if (!interfaces.Contains(typeof(IHasObject)))
                        {
                            results.Add($"{stripeClass.Name} is missing IHasObject");
                        }
                    }

                    // Check for IHasMetadata
                    if ((property.Name == "Metadata") && (property.PropertyType == typeof(Dictionary<string, string>)))
                    {
                        if (!interfaces.Contains(typeof(IHasMetadata)))
                        {
                            results.Add($"{stripeClass.Name} is missing IHasMetadata");
                        }
                    }
                }
            }

            AssertEmpty(results, AssertionMessage);
        }
    }
}
