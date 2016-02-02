using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stripe
{
    public static class ReflectionExtensions
    {

        public static IEnumerable<PropertyInfo> GetProperties(this Type type, BindingFlags flags)
        {
            var properties = type.GetTypeInfo().DeclaredProperties;
            if ((flags & BindingFlags.FlattenHierarchy) == BindingFlags.FlattenHierarchy)
                properties = type.GetRuntimeProperties();

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
