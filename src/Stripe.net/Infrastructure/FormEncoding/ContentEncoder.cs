namespace Stripe.Infrastructure.FormEncoding
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Reflection;
    using Newtonsoft.Json;

    internal enum ArrayEncoding
    {
        /// <summary>
        /// Encodes arrays using the "repeated" style, e.g. `a=1 a=2 a=3`.
        /// </summary>
        Repetition,

        /// <summary>
        /// Encodes arrays using the "indexed" style, e.g. `a[0]=1 a[1]=2 a[2]=3`.
        /// </summary>
        Indexed,
    }

    /// <summary>
    /// This class provides methods to serialize various objects with
    /// <c>application/x-www-form-urlencoded</c> or <c>application/json</c> encoding. This is used to encode request
    /// parameters to be sent to Stripe's API.
    /// </summary>
    internal static class ContentEncoder
    {
        /// <summary>Creates an <see cref="HttpContent"/> for a given options class.</summary>
        /// <param name="options">The options class.</param>
        /// <param name="apiMode">The API mode to use for the request.</param>
        /// <returns>The <see cref="HttpContent"/>.</returns>
        public static HttpContent CreateHttpContent(BaseOptions options, ApiMode apiMode)
        {
            if (apiMode == ApiMode.V2)
            {
                if (options == null)
                {
                    return null;
                }

                return new JsonEncodedContent(options);
            }

            // If options is null, we create an empty FormUrlEncodedContent because we still
            // want to send the Content-Type header.
            if (options == null)
            {
                return new FormUrlEncodedContent(new List<KeyValuePair<string, string>>());
            }

            var arrayEncoding = apiMode == ApiMode.V1 ? ArrayEncoding.Indexed : ArrayEncoding.Repetition;
            var flatParams = FlattenParamsValue(options, null, arrayEncoding);

            // If all parameters have been encoded as strings, then the content can be represented
            // with application/x-www-form-url-encoded encoding. Otherwise, use
            // multipart/form-data encoding.
            if (flatParams.All(kvp => kvp.Value is string))
            {
                var flatParamsString = flatParams
                    .Select(kvp => new KeyValuePair<string, string>(kvp.Key, kvp.Value as string));

                return new FormUrlEncodedContent(flatParamsString);
            }
            else
            {
                return new MultipartFormDataContent(flatParams);
            }
        }

        /// <summary>Creates the HTTP query string for a given options class.</summary>
        /// <param name="options">The options class.</param>
        /// <param name="apiMode">The API mode to use for the query string.</param>
        /// <returns>The query string.</returns>
        public static string CreateQueryString(BaseOptions options, ApiMode apiMode = ApiMode.V1)
        {
            var arrayEncoding = apiMode == ApiMode.V1 ? ArrayEncoding.Indexed : ArrayEncoding.Repetition;
            var flatParams = FlattenParamsValue(options, null, arrayEncoding)
                .Where(kvp => kvp.Value is string)
                .Select(kvp => new KeyValuePair<string, string>(
                    kvp.Key,
                    kvp.Value as string));
            return CreateQueryString(flatParams);
        }

        /// <summary>Creates the HTTP query string for a collection of name/value tuples.</summary>
        /// <param name="nameValueCollection">The collection of name/value tuples.</param>
        /// <returns>The query string.</returns>
        public static string CreateQueryString(IEnumerable<KeyValuePair<string, string>> nameValueCollection)
        {
            return string.Join(
                "&",
                nameValueCollection.Select(kvp => $"{UrlEncode(kvp.Key)}={UrlEncode(kvp.Value)}"));
        }

        /// <summary>URL-encodes a string.</summary>
        /// <param name="value">The string to URL-encode.</param>
        /// <returns>The URL-encoded string.</returns>
        private static string UrlEncode(string value)
        {
            // Don't use strict form encoding by changing the square bracket control
            // characters back to their literals. This is fine by the server, and
            // makes these parameter strings easier to read.
            return WebUtility.UrlEncode(value)
                .Replace("%5B", "[")
                .Replace("%5D", "]");
        }

        /// <summary>
        /// Returns a list of parameters for a given value. The value can be basically anything, as
        /// long as it can be encoded in some way.
        /// </summary>
        /// <param name="value">The value for which to create the list of parameters.</param>
        /// <param name="keyPrefix">The key under which new keys should be nested, if any.</param>
        /// <param name="arrayEncoding">How to encode arrays.</param>
        /// <returns>The list of parameters.</returns>
        private static List<KeyValuePair<string, object>> FlattenParamsValue(object value, string keyPrefix, ArrayEncoding arrayEncoding)
        {
            List<KeyValuePair<string, object>> flatParams = null;

            switch (value)
            {
                case null:
                    flatParams = SingleParam(keyPrefix, string.Empty);
                    break;

                case IAnyOf anyOf:
                    flatParams = FlattenParamsAnyOf(anyOf, keyPrefix, arrayEncoding);
                    break;

                case INestedOptions options:
                    flatParams = FlattenParamsOptions(options, keyPrefix, arrayEncoding);
                    break;

                case IDictionary dictionary:
                    flatParams = FlattenParamsDictionary(dictionary, keyPrefix, arrayEncoding);
                    break;

                case string s:
                    flatParams = SingleParam(keyPrefix, s);
                    break;

                case Stream s:
                    flatParams = SingleParam(keyPrefix, s);
                    break;

                case IEnumerable enumerable:
                    flatParams = FlattenParamsList(enumerable, keyPrefix, arrayEncoding);
                    break;

                case DateTime dateTime:
                    flatParams = SingleParam(
                        keyPrefix,
                        ((DateTimeOffset)dateTime).ToUnixTimeSeconds().ToString(CultureInfo.InvariantCulture));
                    break;

                case Enum e:
                    flatParams = SingleParam(keyPrefix, JsonUtils.SerializeObject(e).Trim('"'));
                    break;

                default:
                    flatParams = SingleParam(
                        keyPrefix,
                        string.Format(CultureInfo.InvariantCulture, "{0}", value));
                    break;
            }

            return flatParams;
        }

        /// <summary>
        /// Returns a list of parameters for a given <see cref="IAnyOf"/> instance.
        /// </summary>
        /// <param name="anyOf">The instance for which to create the list of parameters.</param>
        /// <param name="keyPrefix">The key under which new keys should be nested, if any.</param>
        /// <param name="arrayEncoding">How to encode arrays.</param>
        /// <returns>The list of parameters.</returns>
        private static List<KeyValuePair<string, object>> FlattenParamsAnyOf(
            IAnyOf anyOf,
            string keyPrefix,
            ArrayEncoding arrayEncoding)
        {
            List<KeyValuePair<string, object>> flatParams = new List<KeyValuePair<string, object>>();

            // If the value contained within the `AnyOf` instance is null, we don't encode it in the
            // request. We do this to mimic the behavior of regular (non-`AnyOf`) properties in
            // options classes, which are skipped by the encoder when they have a null value
            // because it's the default value (cf. FlattenParamsOptions).
            if (anyOf.Value == null)
            {
                return flatParams;
            }

            flatParams.AddRange(FlattenParamsValue(anyOf.Value, keyPrefix, arrayEncoding));

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
        /// <param name="arrayEncoding">How to encode arrays.</param>
        /// <returns>The list of parameters.</returns>
        private static List<KeyValuePair<string, object>> FlattenParamsOptions(
            INestedOptions options,
            string keyPrefix,
            ArrayEncoding arrayEncoding)
        {
            List<KeyValuePair<string, object>> flatParams = new List<KeyValuePair<string, object>>();
            if (options == null)
            {
                return flatParams;
            }

            foreach (var property in options.GetType().GetRuntimeProperties())
            {
                // `[JsonExtensionData]` tells the serializer to write the values contained in
                // the collection as if they were class properties.
                var extensionAttribute = property.GetCustomAttribute<JsonExtensionDataAttribute>();
                if (extensionAttribute != null)
                {
                    var extensionValue = property.GetValue(options, null) as IDictionary;

                    flatParams.AddRange(FlattenParamsDictionary(extensionValue, keyPrefix, arrayEncoding));
                    continue;
                }

                // Skip properties not annotated with `[JsonProperty]`
                var attribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                if (attribute == null)
                {
                    continue;
                }

                var value = property.GetValue(options, null);

                // Fields on a class which are never set by the user will contain null values (for
                // reference types), so skip those to avoid encoding them in the request.
                if (value == null)
                {
                    continue;
                }

                string key = attribute.PropertyName;
                string newPrefix = NewPrefix(key, keyPrefix);

                flatParams.AddRange(FlattenParamsValue(value, newPrefix, arrayEncoding));
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
        /// <param name="arrayEncoding">How to encode arrays.</param>
        /// <returns>The list of parameters.</returns>
        private static List<KeyValuePair<string, object>> FlattenParamsDictionary(
            IDictionary dictionary,
            string keyPrefix,
            ArrayEncoding arrayEncoding)
        {
            List<KeyValuePair<string, object>> flatParams = new List<KeyValuePair<string, object>>();
            if (dictionary == null)
            {
                return flatParams;
            }

            foreach (DictionaryEntry entry in dictionary)
            {
                string key = string.Format(CultureInfo.InvariantCulture, "{0}", entry.Key);
                object value = entry.Value;

                string newPrefix = NewPrefix(key, keyPrefix);

                flatParams.AddRange(FlattenParamsValue(value, newPrefix, arrayEncoding));
            }

            return flatParams;
        }

        /// <summary>
        /// Returns a list of parameters for a given list of objects. The parameter keys will be
        /// indexed under the `keyPrefix` parameter. Examples:
        /// list=[a,b,c], keyPrefix=foo, arrayEncoding=indexed -> foo[0]=a,foo[1]=b,foo[2]=c
        /// list=[a,b,c], keyPrefix=foo, arrayEncoding=repeated -> foo=a,foo=b,foo=c.
        ///
        /// </summary>
        /// <param name="list">The list for which to create the list of parameters.</param>
        /// <param name="keyPrefix">The key under which new keys should be nested.</param>
        /// <param name="arrayEncoding">How to encode arrays.</param>
        /// <returns>The list of parameters.</returns>
        private static List<KeyValuePair<string, object>> FlattenParamsList(
            IEnumerable list,
            string keyPrefix,
            ArrayEncoding arrayEncoding)
        {
            List<KeyValuePair<string, object>> flatParams = new List<KeyValuePair<string, object>>();
            if (list == null)
            {
                return flatParams;
            }

            int index = 0;
            foreach (object value in list)
            {
                var maybeIndex = arrayEncoding == ArrayEncoding.Indexed ? $"[{index}]" : string.Empty;
                string newPrefix = $"{keyPrefix}{maybeIndex}";
                flatParams.AddRange(FlattenParamsValue(value, newPrefix, arrayEncoding));
                index += 1;
            }

            // Because application/x-www-form-urlencoded cannot represent an empty list, convention
            // is to take the list parameter and just set it to an empty string. (E.g. A regular
            // list might look like `a[0]=1&b[1]=2`. Emptying it would look like `a=`.)
            if (!flatParams.Any())
            {
                flatParams.Add(new KeyValuePair<string, object>(keyPrefix, string.Empty));
            }

            return flatParams;
        }

        /// <summary>Creates a list containing a single parameter.</summary>
        /// <param name="key">The parameter's key.</param>
        /// <param name="value">The parameter's value.</param>
        /// <returns>A list containg the single parameter.</returns>
        private static List<KeyValuePair<string, object>> SingleParam(string key, object value)
        {
            List<KeyValuePair<string, object>> flatParams = new List<KeyValuePair<string, object>>();
            flatParams.Add(new KeyValuePair<string, object>(key, value));
            return flatParams;
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
}
