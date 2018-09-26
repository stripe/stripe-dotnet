namespace StripeTests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Microsoft.Extensions.DependencyModel;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

#if NETCOREAPP1_1
    public class NullableValueTypes
    {
        [Fact]
        public void EnsureAllValueTypesAreNullable()
        {
            List<string> results = new List<string>();

            // Get all classes that implement INestedOptions
            var type = typeof(INestedOptions);
            var optionsClasses = GetReferencingAssemblies("Stripe.net")
                .SelectMany(assembly => assembly.ExportedTypes)
                .Where(p => type.IsAssignableFrom(p));

            foreach (Type optionsClass in optionsClasses)
            {
                foreach (PropertyInfo property in optionsClass.GetProperties())
                {
                    var propType = property.PropertyType;

                    // Skip properties that don't have a `JsonProperty` attribute
                    var attribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                    if (attribute == null)
                    {
                        continue;
                    }

                    // Skip non-value types
                    if (!propType.GetTypeInfo().IsValueType)
                    {
                        continue;
                    }

                    // Skip value types that are already nullable
                    if (propType.GetTypeInfo().IsGenericType &&
                        propType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        continue;
                    }

                    results.Add($"{optionsClass.Name}.{property.Name}");
                }
            }

            if (results.Any())
            {
                // Sort results alphabetically
                results = results.OrderBy(i => i).ToList();

                // Display our own error message (because Assert.Empty truncates the results)
                Console.WriteLine("Found non-nullable value types:");
                foreach (string item in results)
                {
                    Console.WriteLine($"- {item}");
                }

                // Actually fail test
                Assert.True(false, "Found at least one non-nullable value type");
            }
        }

        private static IEnumerable<Assembly> GetReferencingAssemblies(string assemblyName)
        {
            var assemblies = new List<Assembly>();
            var dependencies = DependencyContext.Default.RuntimeLibraries;
            foreach (var library in dependencies)
            {
                if (IsCandidateLibrary(library, assemblyName))
                {
                    var assembly = Assembly.Load(new AssemblyName(library.Name));
                    assemblies.Add(assembly);
                }
            }

            return assemblies;
        }

        private static bool IsCandidateLibrary(RuntimeLibrary library, string assemblyName)
        {
            return library.Name == assemblyName
                || library.Dependencies.Any(d => d.Name.StartsWith(assemblyName));
        }
    }
#endif
}
