namespace StripeTests.Wholesome
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class AttributeTestUtils
    {
        /// <summary>
        /// Find all attributes used by any type in the specified assembly that has a
        /// namespace that starts with the supplied prefix.
        /// </summary>
        /// <param name="nsPrefix">The namespace or prefix of the namespace to search for.  Case insensitive.</param>
        /// <param name="assembly">An assembly to search.  If null, this method uses the calling assembly.</param>
        /// <returns>A list of attribute names currently in use.</returns>
        public static IEnumerable<Attribute> FindAllUsedAttributesFromNamespace(string nsPrefix, Assembly assembly = null)
        {
            var results = new List<Attribute>();
            assembly = assembly ?? Assembly.GetCallingAssembly();
            foreach (Type type in assembly.GetTypes())
            {
                foreach (var attribute in type.GetCustomAttributes())
                {
                    var attributeType = attribute.GetType();
                    if (attributeType.Namespace.StartsWith(nsPrefix, true, null))
                    {
                        if (!results.Contains(attribute))
                        {
                            results.Add(attribute);
                        }
                    }
                }

                foreach (var property in type.GetProperties())
                {
                    foreach (var attribute in property.GetCustomAttributes())
                    {
                        var attributeType = attribute.GetType();
                        if (attributeType.Namespace.StartsWith(nsPrefix, true, null))
                        {
                            if (!results.Contains(attribute))
                            {
                                results.Add(attribute);
                            }
                        }
                    }
                }
            }

            return results;
        }
    }
}
