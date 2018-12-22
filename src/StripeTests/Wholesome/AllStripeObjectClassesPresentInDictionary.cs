#if NETCOREAPP
namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    /// <summary>
    /// This test checks that all Stripe object classes (i.e. model classes that implement
    /// <see cref="Stripe.IHasObject" />) have an entry in the
    /// <see cref="Stripe.Infrastructure.StripeTypeRegistry.ObjectsToTypes" /> dictionary.
    /// </summary>
    public class AllStripeObjectClassesPresentInDictionary : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one model class missing in ObjectsToTypes dictionary";

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            // Get all classes that implement IHasObject
            var modelClasses = GetClassesWithInterface(typeof(IHasObject));

            foreach (Type modelClass in modelClasses)
            {
                // Skip types present in dictionary
                if (StripeTypeRegistry.ObjectsToTypes.Any(kv => kv.Value == modelClass))
                {
                    continue;
                }

                // StripeList is a generic type that is handled separately
                if (modelClass == typeof(StripeList<>))
                {
                    continue;
                }

                results.Add(modelClass.Name);
            }

            AssertEmpty(results, AssertionMessage);
        }
    }
}
#endif
