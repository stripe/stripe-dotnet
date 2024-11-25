namespace StripeTests.Wholesome
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using Xunit;

#pragma warning disable SA1402 // File may only contain a single type
#pragma warning disable SA1649 // File name should match first type name
    internal class ExtendedPropertyInfo : PropertyInfo
#pragma warning restore SA1649 // File name should match first type name
#pragma warning restore SA1402 // File may only contain a single type
    {
        private readonly PropertyInfo propertyInfo;

        internal ExtendedPropertyInfo(PropertyInfo propertyInfo, bool isNotPublic)
        {
            this.propertyInfo = propertyInfo;
            this.IsNotPublic = isNotPublic;
        }

        public bool IsNotPublic { get; }

        public override PropertyAttributes Attributes => this.propertyInfo.Attributes;

        public override bool CanRead => this.propertyInfo.CanRead;

        public override bool CanWrite => this.propertyInfo.CanWrite;

        public override Type PropertyType => this.propertyInfo.PropertyType;

        public override Type DeclaringType => this.propertyInfo.DeclaringType;

        public override string Name => this.propertyInfo.Name;

        public override Type ReflectedType => this.propertyInfo.ReflectedType;

        public override MethodInfo[] GetAccessors(bool nonPublic)
        {
            return this.propertyInfo.GetAccessors(nonPublic);
        }

        public override MethodInfo GetGetMethod(bool nonPublic)
        {
            return this.propertyInfo.GetGetMethod(nonPublic);
        }

        public override ParameterInfo[] GetIndexParameters()
        {
            return this.propertyInfo.GetIndexParameters();
        }

        public override MethodInfo GetSetMethod(bool nonPublic)
        {
            return this.propertyInfo.GetSetMethod(nonPublic);
        }

        public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
        {
            return this.propertyInfo.GetValue(obj, invokeAttr, binder, index, culture);
        }

        public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
        {
            this.propertyInfo.SetValue(obj, value, invokeAttr, binder, index, culture);
        }

        public override object[] GetCustomAttributes(bool inherit)
        {
            return this.propertyInfo.GetCustomAttributes(inherit);
        }

        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return this.propertyInfo.GetCustomAttributes(attributeType, inherit);
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            return this.propertyInfo.IsDefined(attributeType, inherit);
        }
    }

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
        /// </summary>
        /// <param name="results">The list of strings to check.</param>
        /// <param name="message">The message to display if the list is not empty.</param>
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
        /// <param name="parentClass">The parent class.</param>
        /// <returns>The list of classes that are subclasses of the provided type.</returns>
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
        /// <param name="implementedInterface">The implemented interface.</param>
        /// <returns>The list of classes that implement the provided interface.</returns>
        protected static List<Type> GetClassesWithInterface(Type implementedInterface)
        {
            var assembly = implementedInterface.GetTypeInfo().Assembly;
            return assembly.DefinedTypes
                .Where(t => t.IsClass && t.ImplementedInterfaces.Contains(implementedInterface))
                .Select(t => t.AsType())
                .ToList();
        }

        internal static IEnumerable<ExtendedPropertyInfo> GetPropertiesToCheck(Type type)
        {
            // Gets the nonpublic properties (private, internal, protected, etc)
            var nonpublicProperties = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            var allProperties = type.GetProperties().Concat(nonpublicProperties);

            return allProperties.Select(p => new ExtendedPropertyInfo(p, nonpublicProperties.Contains(p)));
        }
    }
}
