using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Stripe
{
    internal static class ParameterBuilder
    {
        public static string ApplyAllParameters(this StripeService service, object obj, string url, bool isListMethod)
        {
            var queryStringProperties = new Dictionary<string, List<string>>();

            if (obj != null)
            {
                AddQueryStringProperties(queryStringProperties, Enumerable.Empty<string>(), obj);
            }

            if (service != null)
            {
                var propertiesToExpand = service.GetType()
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.Name.StartsWith("Expand") && p.PropertyType == typeof(bool))
                    .Where(p => (bool)p.GetValue(service, null))
                    .Select(p => p.Name);

                foreach (var propertyName in propertiesToExpand)
                {
                    string expandPropertyName = propertyName.Substring("Expand".Length);
                    expandPropertyName = Regex.Replace(expandPropertyName, "([a-z])([A-Z])", "$1_$2").ToLower();

                    if (isListMethod)
                    {
                        expandPropertyName = "data." + expandPropertyName;
                    }

                    AddQueryStringProperty(queryStringProperties, null, "expand[]", expandPropertyName);
                }
            }

            if (queryStringProperties.Count > 0)
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.Append(url);
                stringBuilder.Append("?");
                ToQueryString(stringBuilder, queryStringProperties);
                return stringBuilder.ToString();
            }
            else
            {
                return url;                
            }
        }

        private static void ToQueryString(StringBuilder stringBuilder, Dictionary<string, List<string>> properties)
        {
            var queryStrings = properties.SelectMany(kvp => kvp.Value.Select((v) => string.Format("{0}={1}", kvp.Key, v))).ToArray();
            stringBuilder.Append(string.Join("&", queryStrings));
        }

        private static void AddQueryStringProperties(Dictionary<string, List<string>> queryStringProperties, IEnumerable<string> parents, object obj)
        {
            if (queryStringProperties == null) throw new ArgumentNullException("queryStringProperties");
            if (parents == null) throw new ArgumentNullException("parents");

            foreach (var property in obj.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
            {
                var value = property.GetValue(obj, null);
                if (value == null) continue;
                var valueType = value.GetType();

                foreach (var attribute in property.GetCustomAttributes(typeof (JsonPropertyAttribute), false).Cast<JsonPropertyAttribute>())
                {
                    QueryStringParameterConverterAttribute converterAttrib = valueType.GetCustomAttributes(typeof(QueryStringParameterConverterAttribute), false).Cast<QueryStringParameterConverterAttribute>().FirstOrDefault();

                    if (converterAttrib != null)
                    {
                        var converter = converterAttrib.GetConverter();
                        var convertedValue = converter.ConvertToQueryStringValue(value);
                        if (convertedValue != null)
                        {
                            AddQueryStringProperty(queryStringProperties, parents, attribute.PropertyName, convertedValue);
                        }
                    }
                    else if (value is IDictionary<string, string>)
                    {
                        var dictionary = (IDictionary<string, string>)value;
                        foreach (string key in dictionary.Keys)
                        {
                            AddQueryStringProperty(queryStringProperties, parents.Union(new[] { attribute.PropertyName }), key, dictionary[key]);
                        }
                    }
                    else if (value is StripeDateFilter)
                    {
                        var filter = (StripeDateFilter) value;

                        if (filter.EqualTo.HasValue)
                            AddQueryStringProperty(queryStringProperties, parents, attribute.PropertyName, filter.EqualTo.Value.ConvertDateTimeToEpoch().ToString());
                        
                        if (filter.LessThan.HasValue)
                            AddQueryStringProperty(queryStringProperties, parents, attribute.PropertyName + "[lt]", filter.LessThan.Value.ConvertDateTimeToEpoch().ToString());

                        if (filter.LessThanOrEqual.HasValue)
                            AddQueryStringProperty(queryStringProperties, parents, attribute.PropertyName + "[lte]", filter.LessThanOrEqual.Value.ConvertDateTimeToEpoch().ToString());

                        if (filter.GreaterThan.HasValue)
                            AddQueryStringProperty(queryStringProperties, parents, attribute.PropertyName + "[gt]", filter.GreaterThan.Value.ConvertDateTimeToEpoch().ToString());

                        if (filter.GreaterThanOrEqual.HasValue)
                            AddQueryStringProperty(queryStringProperties,parents, attribute.PropertyName + "[gte]", filter.GreaterThanOrEqual.Value.ConvertDateTimeToEpoch().ToString());
                    }
                    else if (value is string || valueType.IsPrimitive)
                    {
                        AddQueryStringProperty(queryStringProperties, parents, attribute.PropertyName, value.ToString());
                    }
                    else
                    {
                        AddQueryStringProperties(queryStringProperties, parents.Union(new[] {attribute.PropertyName}), value);
                    }
                }
            }
        }

        public static void AddQueryStringProperty(Dictionary<string, List<string>> queryStrings, IEnumerable<string> parents, string argument, string value)
        {
            if (parents != null)
            {
                int parentCount = 0;
                var stringBuilder = new StringBuilder();
                foreach (var parent in parents)
                {
                    parentCount++;
                    stringBuilder.AppendFormat("{0}[", parent);
                }
                stringBuilder.Append(argument);
                stringBuilder.Append(new string(']', parentCount));
                argument = stringBuilder.ToString();
            }

            List<string> values;
            if (!queryStrings.TryGetValue(argument, out values))
            {
                queryStrings.Add(argument, values = new List<string>());
            }
            values.Add(HttpUtility.UrlEncode(value));
        }

        public static string ApplyParameterToUrl(string url, string argument, string value)
        {
            var token = "&";

            if (!url.Contains("?"))
                token = "?";

            return string.Format("{0}{1}{2}={3}", url, token, argument, HttpUtility.UrlEncode(value));
        }
    }
}
