#if NETCOREAPP
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
    public class DontForgetEntityType : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one class with an incorrect base type.";

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            // Get all classes that derive from StripeEntity
            var stripeClasses = GetSubclassesOf(typeof(StripeEntity));

            foreach (Type stripeClass in stripeClasses)
            {
                var baseType = stripeClass.GetTypeInfo().BaseType;

                // Skip the generic version of StripeEntity or AddressJapan as it inherits from
                // Address and is an exception in the library
                if (stripeClass == typeof(StripeEntity<>) || stripeClass.Name == "AddressJapan")
                {
                    continue;
                }

                if (!baseType.GetTypeInfo().IsGenericType ||
                    baseType.GetGenericTypeDefinition() != typeof(StripeEntity<>))
                {
                    results.Add($"{stripeClass.Name} inherits from {baseType.Name} instead of StripeEntity<{stripeClass.Name}>");
                    continue;
                }

                var typeParam = baseType.GetTypeInfo().GetGenericArguments()[0];
                if (typeParam != stripeClass)
                {
                    results.Add($"{stripeClass.Name} inherits from StripeEntity<{typeParam.Name}> instead of StripeEntity<{stripeClass.Name}>");
                    continue;
                }
            }

            AssertEmpty(results, AssertionMessage);
        }
    }
}
#endif
