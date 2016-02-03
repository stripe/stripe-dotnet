using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Stripe
{

    /// <summary>
    /// 
    /// </summary>
    internal static class ReflectionExtensions
    {

        /// <summary>
        /// Replacement for the GetType().GetProperties() method so we wouldn't have to replace a crapload of code.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="flags"></param>
        /// <returns></returns>
        public static IEnumerable<PropertyInfo> GetProperties(this Type type, BindingFlags flags)
        {
            var properties = type.GetTypeInfo().DeclaredProperties;
            if ((flags & BindingFlags.FlattenHierarchy) == BindingFlags.FlattenHierarchy)
                properties = type.GetRuntimeProperties();

            //TODO: RWM: Fix for the NonPublic binding flag.
            return from property in properties
                   let getMethod = property.GetMethod
                   where getMethod != null
                   where (flags & BindingFlags.Public) != BindingFlags.Public || getMethod.IsPublic
                   where (flags & BindingFlags.Instance) != BindingFlags.Instance || !getMethod.IsStatic
                   where (flags & BindingFlags.Static) != BindingFlags.Static || getMethod.IsStatic
                   select property;
        }

    }
}
