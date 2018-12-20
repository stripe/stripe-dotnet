#if NETCOREAPP
namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Xunit;

    [Collection("Wholesome tests")]
    public class WholesomeTest
    {
        /// <summary>
        /// Returns the list of classes that are subclasses of the provided type.
        /// </summary>
        protected static IEnumerable<Type> GetSubclassesOf(Type parentClass)
        {
            var assembly = parentClass.GetTypeInfo().Assembly;
            return assembly.DefinedTypes
                .Where(t => t.IsClass && t.IsSubclassOf(parentClass))
                .Select(t => t.AsType());
        }

        /// <summary>
        /// Returns the list of classes that implement the provided interface.
        /// </summary>
        protected static IEnumerable<Type> GetClassesWithInterface(Type implementedInterface)
        {
            var assembly = implementedInterface.GetTypeInfo().Assembly;
            return assembly.DefinedTypes
                .Where(t => t.IsClass && t.ImplementedInterfaces.Contains(implementedInterface))
                .Select(t => t.AsType());
        }
    }
}
#endif
