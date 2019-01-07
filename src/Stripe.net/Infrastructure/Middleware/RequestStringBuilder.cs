namespace Stripe.Infrastructure.Middleware
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using Newtonsoft.Json;

    public static class RequestStringBuilder
    {
        public static void ApplyParameterToRequestString(ref string requestString, string argument, string value)
        {
            var token = requestString.Contains("?") ? "&" : "?";
            requestString = $"{requestString}{token}{argument}={WebUtility.UrlEncode(value)}";
        }

        /// <summary>
        /// Creates the HTTP query string for a given options class.
        /// </summary>
        /// <param name="requestString">The string to which the query string will be appended.</param>
        /// <param name="options">The options class for which to create the query string.</param>
        public static void CreateQuery(ref string requestString, INestedOptions options)
        {
            List<Parameter> flatParams = FlattenParams(options);

            foreach (Parameter param in flatParams)
            {
                RequestStringBuilder.ApplyParameterToRequestString(ref requestString, param.Key, param.Value);
            }
        }

        /// <summary>
        /// Returns a list of parameters for a given options class. If the class contains
        /// containers (e.g. dictionaries, lists, arrays or other options classes), the parameters
        /// will be computed recursively and a flat list will be returned.
        /// </summary>
        /// <param name="options">The options class for which to create the list of parameters.</param>
        /// <returns>The list of parameters</returns>
        private static List<Parameter> FlattenParams(INestedOptions options)
        {
            return FlattenParamsOptions(options, null);
        }

        /// <summary>
        /// Returns a list of parameters for a given value. The value can be basically anything, as
        /// long as it can be encoded in some way.
        /// </summary>
        /// <param name="value">The value for which to create the list of parameters.</param>
        /// <param name="keyPrefix">The key under which new keys should be nested, if any.</param>
        /// <returns>The list of parameters</returns>
        private static List<Parameter> FlattenParamsValue(object value, string keyPrefix)
        {
            List<Parameter> flatParams = null;

            if (value is INestedOptions)
            {
                flatParams = FlattenParamsOptions((INestedOptions)value, keyPrefix);
            }
            else if (IsDictionary(value))
            {
                // Cast to Dictionary<string, object>
                Dictionary<string, object> dictionary = ((IDictionary)value).
                    Cast<dynamic>().
                    ToDictionary(
                        entry => (string)entry.Key,
                        entry => entry.Value);
                flatParams = FlattenParamsDictionary(dictionary, keyPrefix);
            }
            else if (IsList(value))
            {
                // Cast to List<object>
                List<object> list = ((IEnumerable)value).
                    Cast<dynamic>().
                    ToList();
                flatParams = FlattenParamsList(list, keyPrefix);
            }
            else if (IsArray(value))
            {
                // Cast to object[]
                object[] array = ((IEnumerable)value).
                    Cast<dynamic>().
                    ToArray();
                flatParams = FlattenParamsArray(array, keyPrefix);
            }
            else if (IsEnum(value))
            {
                flatParams = new List<Parameter>();

                // Use JsonConvert to grab the EnumMemberAttribute's Value for the enum element
                string paramValue = JsonConvert.SerializeObject(value).Trim('"');

                flatParams.Add(new Parameter(keyPrefix, paramValue));
            }
            else if (value is DateTime)
            {
                flatParams = new List<Parameter>();
                DateTime? dateTime = (DateTime)value;
                if (dateTime.HasValue)
                {
                    flatParams.Add(new Parameter(keyPrefix, dateTime?.ConvertDateTimeToEpoch().ToString(CultureInfo.InvariantCulture)));
                }
            }
            else if (value == null)
            {
                flatParams = new List<Parameter>();
                flatParams.Add(new Parameter(keyPrefix, string.Empty));
            }
            else
            {
                flatParams = new List<Parameter>();
                flatParams.Add(new Parameter(
                    keyPrefix,
                    string.Format(CultureInfo.InvariantCulture, "{0}", value)));
            }

            return flatParams;
        }

        /// <summary>
        /// Returns a list of parameters for a given options class. If a key prefix is provided, the
        /// keys for the new parameters will be nested under the key prefix. E.g. if the key prefix
        /// `foo` is passed and the options class contains a parameter `bar`, then a parameter
        /// with key `foo[bar]` will be returned.
        /// </summary>
        /// <param name="options">The options class for which to create the list of parameters.</param>
        /// <param name="keyPrefix">The key under which new keys should be nested, if any.</param>
        /// <returns>The list of parameters</returns>
        private static List<Parameter> FlattenParamsOptions(INestedOptions options, string keyPrefix)
        {
            List<Parameter> flatParams = new List<Parameter>();
            if (options == null)
            {
                return flatParams;
            }

            foreach (var property in options.GetType().GetRuntimeProperties())
            {
                var value = property.GetValue(options, null);

                // Fields on a class which are never set by the user will contain null values (for
                // reference types), so skip those to avoid encoding them in the request.
                if (value == null)
                {
                    continue;
                }

                var attribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                if (attribute == null)
                {
                    continue;
                }

                string key = attribute.PropertyName;
                string newPrefix = NewPrefix(key, keyPrefix);

                flatParams.AddRange(FlattenParamsValue(value, newPrefix));
            }

            return flatParams;
        }

        /// <summary>
        /// Returns a list of parameters for a given dictionary. If a key prefix is provided, the
        /// keys for the new parameters will be nested under the key prefix. E.g. if the key prefix
        /// `foo` is passed and the dictionary contains a key `bar`, then a parameter with key
        /// `foo[bar]` will be returned.
        /// </summary>
        /// <param name="dictionary">The dictionary for which to create the list of parameters.</param>
        /// <param name="keyPrefix">The key under which new keys should be nested, if any.</param>
        /// <returns>The list of parameters</returns>
        private static List<Parameter> FlattenParamsDictionary(Dictionary<string, object> dictionary, string keyPrefix)
        {
            List<Parameter> flatParams = new List<Parameter>();
            if (dictionary == null)
            {
                return flatParams;
            }

            foreach (KeyValuePair<string, object> entry in dictionary)
            {
                string key = WebUtility.UrlEncode(entry.Key);
                object value = entry.Value;

                string newPrefix = NewPrefix(key, keyPrefix);

                flatParams.AddRange(FlattenParamsValue(value, newPrefix));
            }

            return flatParams;
        }

        /// <summary>
        /// Returns a list of parameters for a given list of objects. The parameter keys will be
        /// indexed under the `keyPrefix` parameter. E.g. if the `keyPrefix` is `foo`, then the
        /// key for the first element's will be `foo[0]`, etc.
        /// </summary>
        /// <param name="list">The list for which to create the list of parameters.</param>
        /// <param name="keyPrefix">The key under which new keys should be nested.</param>
        /// <returns>The list of parameters</returns>
        private static List<Parameter> FlattenParamsList(List<object> list, string keyPrefix)
        {
            List<Parameter> flatParams = new List<Parameter>();
            if (list == null)
            {
                return flatParams;
            }

            if (!list.Any())
            {
                flatParams.Add(new Parameter(keyPrefix, string.Empty));
            }
            else
            {
                foreach (var item in list.Select((value, index) => new { value, index }))
                {
                    string newPrefix = $"{keyPrefix}[{item.index}]";
                    flatParams.AddRange(FlattenParamsValue(item.value, newPrefix));
                }
            }

            return flatParams;
        }

        /// <summary>
        /// Returns a list of parameters for a given array of objects. The parameter keys will be
        /// indexed under the `keyPrefix` parameter. E.g. if the `keyPrefix` is `foo`, then the
        /// key for the first element's will be `foo[0]`, etc.
        /// </summary>
        /// <param name="array">The array for which to create the list of parameters.</param>
        /// <param name="keyPrefix">The key under which new keys should be nested.</param>
        /// <returns>The list of parameters</returns>
        private static List<Parameter> FlattenParamsArray(object[] array, string keyPrefix)
        {
            List<Parameter> flatParams = new List<Parameter>();

            if (array.Length == 0)
            {
                flatParams.Add(new Parameter(keyPrefix, string.Empty));
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    object value = array[i];
                    string newPrefix = $"{keyPrefix}[{i}]";
                    flatParams.AddRange(FlattenParamsValue(value, newPrefix));
                }
            }

            return flatParams;
        }

        /// <summary>
        /// Checks if a given object is a dictionary.
        /// </summary>
        /// <param name="o">The object to check.</param>
        /// <returns>True if the object is a dictionary, false otherwise.</returns>
        private static bool IsDictionary(object o)
        {
            if (o == null)
            {
                return false;
            }

            var type = o.GetType();

            if (!type.GetTypeInfo().IsGenericType)
            {
                return false;
            }

            if (type.GetTypeInfo().GetGenericTypeDefinition() != typeof(Dictionary<,>))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if a given object is a list.
        /// </summary>
        /// <param name="o">The object to check.</param>
        /// <returns>True if the object is a list, false otherwise.</returns>
        private static bool IsList(object o)
        {
            if (o == null)
            {
                return false;
            }

            var type = o.GetType();

            if (!type.GetTypeInfo().IsGenericType)
            {
                return false;
            }

            if (type.GetTypeInfo().GetGenericTypeDefinition() != typeof(List<>))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if a given object is an array.
        /// </summary>
        /// <param name="o">The object to check.</param>
        /// <returns>True if the object is an array, false otherwise.</returns>
        private static bool IsArray(object o)
        {
            if (o == null)
            {
                return false;
            }

            var type = o.GetType();
            return type.IsArray;
        }

        /// <summary>
        /// Checks if a given object is an enum. Note that nullable enums count as enums.
        /// </summary>
        /// <param name="o">The object to check.</param>
        /// <returns>True if the object is an enum (nullable or not), false otherwise.</returns>
        private static bool IsEnum(object o)
        {
            if (o == null)
            {
                return false;
            }

            var type = o.GetType();

            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                type = Nullable.GetUnderlyingType(type);
            }

            if (!type.GetTypeInfo().IsEnum)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Computes the new key prefix, given a key and an existing prefix (if any).
        /// E.g. if the key is `bar` and the existing prefix is `foo`, then `foo[bar]` is returned.
        /// If a key already contains nested values, then only the non-nested part is nested under
        /// the prefix, e.g. if the key is `bar[baz]` and the prefix is `foo`, then `foo[bar][baz]`
        /// is returned.
        /// If no prefix is provided, the key is returned unchanged.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="keyPrefix">The existing key prefix, if any.</param>
        /// <returns>The new key prefix.</returns>
        private static string NewPrefix(string key, string keyPrefix)
        {
            if (string.IsNullOrEmpty(keyPrefix))
            {
                return key;
            }
            else
            {
                int i = key.IndexOf("[", StringComparison.Ordinal);
                if (i == -1)
                {
                    return $"{keyPrefix}[{key}]";
                }
                else
                {
                    return $"{keyPrefix}[{key.Substring(0, i)}]{key.Substring(i)}";
                }
            }
        }

        /// <summary>
        /// Represents a parameter in a query string, i.e. a key/value pair.
        /// </summary>
        internal sealed class Parameter
        {
            public Parameter(string key, string value)
            {
                this.Key = key;
                this.Value = value;
            }

            public string Key { get; }

            public string Value { get; }
        }
    }
}
