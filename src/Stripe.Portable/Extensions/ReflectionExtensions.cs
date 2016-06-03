using System;
using System.Collections.Generic;
using System.Reflection;

namespace Stripe
{
    internal static class ReflectionExtensions
    {
        public static IEnumerable<PropertyInfo> GetProperties(this Type type, BindingFlags flags)
        {
            var properties = type.GetRuntimeProperties();

            return properties;
        }
    }
}
