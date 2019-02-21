#if NETCOREAPP
namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Xunit;

    /// <summary>
    /// Parent class for all wholesome tests. Wholesome tests check the state of the Stripe.net
    /// codebase and prevent inconsistencies and programming mistakes.
    /// </summary>
    [Collection("Wholesome tests")]
    public class WholesomeTest
    {
        /// <summary>
        /// Verifies that a list of strings is empty. If not, display the sorted contents of the
        /// list and fail the test with the provided message.
        /// <summary>
        protected static void AssertEmpty(List<string> results, string message)
        {
            if (results.Any())
            {
                // Sort results alphabetically
                var sortedResults = results.OrderBy(i => i).ToList();

                // Display our own error message (because Assert.Empty truncates the results)
                Console.WriteLine("Non-empty results:");
                foreach (string item in sortedResults)
                {
                    Console.WriteLine($"- {item}");
                }

                // Actually fail test
                Assert.True(false, message);
            }
        }

        /// <summary>
        /// Returns the list of classes that are subclasses of the provided type.
        /// </summary>
        protected static List<Type> GetSubclassesOf(Type parentClass)
        {
            var assembly = parentClass.GetTypeInfo().Assembly;
            return assembly.DefinedTypes
                .Where(t => t.IsClass && t.IsSubclassOf(parentClass))
                .Select(t => t.AsType())
                .ToList();
        }

        /// <summary>
        /// Returns the list of classes that implement the provided interface.
        /// </summary>
        protected static List<Type> GetClassesWithInterface(Type implementedInterface)
        {
            var assembly = implementedInterface.GetTypeInfo().Assembly;
            return assembly.DefinedTypes
                .Where(t => t.IsClass && t.ImplementedInterfaces.Contains(implementedInterface))
                .Select(t => t.AsType())
                .ToList();
        }
    }
}
#endif
