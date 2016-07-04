﻿using Newtonsoft.Json;
using Stripe.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Stripe
{
    internal static class ParameterBuilder
    {
        public static string ApplyAllParameters(
            this StripeService service,
            object obj,
            string url,
            bool isListMethod = false,
            bool includeEmptyValues = false)
        {
            string newUrl = url;

            if (obj != null)
            {
                foreach (var property in
                    obj.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
                {
                    var value = property.GetValue(obj, null);

                    var attribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                    if (attribute == null)
                    {
                        continue;
                    }

                    newUrl = ApplyParameters(newUrl, attribute.PropertyName, value, includeEmptyValues);
                }
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

                    newUrl = ApplyParameterToUrl(newUrl, "expand[]", expandPropertyName);
                }
            }

            return newUrl;
        }

        public static string ApplyParameters(
            string url,
            string propertyName,
            object obj,
            bool includeEmptyValues = false)
        {
            string newUrl = url;

            if (obj == null)
            {
                if (includeEmptyValues)
                {
                    return ApplyParameterToUrl(newUrl, propertyName, string.Empty);
                }

                return newUrl;
            }

            //if simple types:
            if (obj is DateTime)
            {
                //we know it's not null:
                return ApplyParameterToUrl(newUrl, propertyName, ((DateTime)obj).ConvertDateTimeToEpoch().ToString());
            }


            Type dictionaryInterfaceType =
                    obj.GetType()
                        .GetTypeInfo()
                        .ImplementedInterfaces.SingleOrDefault(
                            x =>
                            x.GetTypeInfo().IsGenericType && x.GetGenericTypeDefinition() == typeof(IDictionary<,>));

            if (dictionaryInterfaceType != null)
            {
                Type[] dictioanryKeyValueTypes = dictionaryInterfaceType.GetTypeInfo().GenericTypeArguments;
                if (dictioanryKeyValueTypes[0] == typeof(string))
                {
                    Type valueType = dictioanryKeyValueTypes[0];
                    MethodInfo method =
                        typeof(ParameterBuilder).GetTypeInfo().GetDeclaredMethod("ApplyDictionaryParameters");
                    MethodInfo generic = method.MakeGenericMethod(valueType);
                    newUrl = (string)generic.Invoke(null, new[] { newUrl, propertyName, obj });
                }
                else
                {
                    throw new NotSupportedException("Only string keys are supported for dictionary properties.");
                }
            }
            else if (obj is StripeDateFilter)
            {
                var filter = (StripeDateFilter)obj;

                if (filter.EqualTo.HasValue)
                    newUrl = ApplyParameterToUrl(
                        newUrl,
                        propertyName,
                        filter.EqualTo.Value.ConvertDateTimeToEpoch().ToString());

                if (filter.LessThan.HasValue)
                    newUrl = ApplyParameterToUrl(
                        newUrl,
                        propertyName + "[lt]",
                        filter.LessThan.Value.ConvertDateTimeToEpoch().ToString());

                if (filter.LessThanOrEqual.HasValue)
                    newUrl = ApplyParameterToUrl(
                        newUrl,
                        propertyName + "[lte]",
                        filter.LessThanOrEqual.Value.ConvertDateTimeToEpoch().ToString());

                if (filter.GreaterThan.HasValue)
                    newUrl = ApplyParameterToUrl(
                        newUrl,
                        propertyName + "[gt]",
                        filter.GreaterThan.Value.ConvertDateTimeToEpoch().ToString());

                if (filter.GreaterThanOrEqual.HasValue)
                    newUrl = ApplyParameterToUrl(
                        newUrl,
                        propertyName + "[gte]",
                        filter.GreaterThanOrEqual.Value.ConvertDateTimeToEpoch().ToString());
            }
            else if (obj is INestedNamedOptions )
            {
                //newUrl = ApplyParameters(newUrl, attribute.PropertyName, value);
                // recursive: 
                foreach (var property in
                    obj.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
                {
                    var value = property.GetValue(obj, null);

                    var attribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                    newUrl = ApplyParameters(newUrl, $"{propertyName}[{attribute.PropertyName}]", value, includeEmptyValues);
                }
            }
            else if (obj is INestedOptions)
            {
                //Left the old nested options processing as is:
                newUrl = ApplyNestedObjectProperties(newUrl, obj);
            }
            else if (obj.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).Any(p=> p.GetCustomAttribute<JsonPropertyAttribute>() !=null))
            {
                //even if the object was not marked as nested, we check to see if has fields marked with the json JsonPropertyAttribute and treat it as a nested object:
                // recursive: 
                foreach (var property in
                    obj.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
                {
                    var value = property.GetValue(obj, null);

                    var attribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                    newUrl = ApplyParameters(newUrl, $"{propertyName}[{attribute.PropertyName}]", value, includeEmptyValues);
                }
            }
            else if (obj is IList && obj.GetType().GetTypeInfo().IsGenericType)
            {
                //var objArr = ((Array)value).Cast<object>().ToArray();
                int i = 0;
                foreach (var listItem in (obj as IList))
                {
                    newUrl = ApplyParameters(newUrl, $"{propertyName}[{i}]", listItem);
                    ++i;
                }
            }
            else if (obj.GetType().IsArray)
            {
                var objArr = ((Array)obj).Cast<object>().ToArray();
                newUrl = ApplyArrayParameters(newUrl, propertyName, objArr);
            }
            else
            {
                newUrl = ApplyParameterToUrl(newUrl, propertyName, obj.ToString());
            }
            return newUrl;
        }

#if false
        public static string ApplyAllParameters(this StripeService service, object obj, string url, bool isListMethod = false)
        {
            string newUrl = url;

            if (obj != null)
            {
                foreach (var property in obj.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
                {
                    var value = property.GetValue(obj, null);
                    if (value == null) continue;

                    
                    foreach (var attribute in property.GetCustomAttributes(typeof(JsonPropertyAttribute), false).Cast<JsonPropertyAttribute>())
                    {
                        //Check if this property is a dictionary:
//                        Type dictionaryInterfaceType =
//                            value.GetType()
//                                .GetInterfaces()
//                                .SingleOrDefault(
//                                    x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IDictionary<,>));
                        Type dictionaryInterfaceType =
                            value.GetType()
                                .GetTypeInfo()
                                .ImplementedInterfaces.SingleOrDefault(
                                    x => x.GetTypeInfo().IsGenericType && x.GetGenericTypeDefinition() == typeof(IDictionary<,>));


                        if (dictionaryInterfaceType != null)
                        {
                            Type[] dictioanryKeyValueTypes = dictionaryInterfaceType.GetTypeInfo().GenericTypeArguments;
                            if (dictioanryKeyValueTypes[0] == typeof(string))
                            {
                                Type valueType = dictioanryKeyValueTypes[0];

                                //newUrl = ApplyDictionaryParameters(newUrl, attribute.PropertyName, value);

                                //MethodInfo method = typeof(ParameterBuilder).GetMethod("ApplyDictionaryParameters");
                                MethodInfo method =
                                    typeof(ParameterBuilder).GetTypeInfo()
                                        .GetDeclaredMethod("ApplyDictionaryParameters");
                                MethodInfo generic = method.MakeGenericMethod(valueType);
                                newUrl = (string)generic.Invoke(null, new[] { newUrl, attribute.PropertyName, value });
                            }
                            else
                            {
                                throw new NotSupportedException("Only string keys are supported for dictionary properties.");
                            }
                        } 


//                        if (attribute.PropertyName.ToLower().Contains("metadata"))
//                            newUrl = ApplyMetadataParameters(newUrl, value);
//                        else if (attribute.PropertyName.ToLower().Contains("fraud_details"))
//                        {
//                            var fraudDetails = (Dictionary<string, string>)value;
//
//                            foreach (string key in fraudDetails.Keys)
//                            {
//                                newUrl = ApplyParameterToUrl(newUrl, $"fraud_details[{key}]", fraudDetails[key]);
//                            }
//                        }
                        else if (property.PropertyType == typeof(StripeDateFilter))
                        {
                            var filter = (StripeDateFilter)value;

                            if (filter.EqualTo.HasValue)
                                newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName, filter.EqualTo.Value.ConvertDateTimeToEpoch().ToString());

                            if (filter.LessThan.HasValue)
                                newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName + "[lt]", filter.LessThan.Value.ConvertDateTimeToEpoch().ToString());

                            if (filter.LessThanOrEqual.HasValue)
                                newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName + "[lte]", filter.LessThanOrEqual.Value.ConvertDateTimeToEpoch().ToString());

                            if (filter.GreaterThan.HasValue)
                                newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName + "[gt]", filter.GreaterThan.Value.ConvertDateTimeToEpoch().ToString());

                            if (filter.GreaterThanOrEqual.HasValue)
                                newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName + "[gte]", filter.GreaterThanOrEqual.Value.ConvertDateTimeToEpoch().ToString());
                        }
                        else if (value as INestedNamedOptions != null)
                        {
                            newUrl = ApplyNestedNamedObjectProperties(newUrl, attribute.PropertyName, value);    
                        }
                        else if (value as INestedOptions != null)
                        {
                            newUrl = ApplyNestedObjectProperties(newUrl, value);
                        }
                        else if (value is IList && value.GetType().GetTypeInfo().IsGenericType)
                        {
                            //var objArr = ((Array)value).Cast<object>().ToArray();
                            int i = 0;
                            foreach (var listItem in (value as IList))
                            {
                                newUrl = ApplyNestedNamedObjectProperties(newUrl, $"{attribute.PropertyName}[{i}]", listItem);
                                ++i;
                            }
                        }
                        else if (property.PropertyType.IsArray)
                        {
                            var objArr = ((Array)value).Cast<object>().ToArray();
                            newUrl = ApplyArrayParameters(newUrl, attribute.PropertyName, objArr);
                        }
                        else
                        {
                            newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName, value.ToString());
                        }
                    }
                }
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

                    newUrl = ApplyParameterToUrl(newUrl, "expand[]", expandPropertyName);
                }
            }

            return newUrl;
        }
#endif

        public static string ApplyParameterToUrl(string url, string argument, string value)
        {
            var token = "&";

            if (!url.Contains("?"))
                token = "?";

            return string.Format("{0}{1}{2}={3}", url, token, argument, WebUtility.UrlEncode(value));
        }

        private static string ApplyArrayParameters(string newUrl, string propertyName, object[] array)
        {
            foreach (var o in array)
            {
                newUrl = ApplyParameterToUrl(newUrl, $"{propertyName}[]", o.ToString());
            }

            return newUrl;
        }

        private static string ApplyNestedNamedObjectProperties(string newUrl, string propertyName, object nestedObject)
        {
            foreach (var property in nestedObject.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
            {
                var value = property.GetValue(nestedObject, null);
                if (value == null) continue;

                foreach (var attribute in property.GetCustomAttributes(typeof(JsonPropertyAttribute), false).Cast<JsonPropertyAttribute>())
                {
                    newUrl = ApplyParameterToUrl(newUrl, $"{propertyName}[{attribute.PropertyName}]", value.ToString());
                }
            }

            return newUrl;
        }

        private static string ApplyNestedObjectProperties(string newUrl, object nestedObject)
        {
            foreach (var property in nestedObject.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
            {
                var value = property.GetValue(nestedObject, null);
                if (value == null) continue;

                foreach (var attribute in property.GetCustomAttributes(typeof(JsonPropertyAttribute), false).Cast<JsonPropertyAttribute>())
                {
                    //TODO:
                    if (attribute.PropertyName.ToLower().Contains("metadata"))
                        //newUrl = ApplyMetadataParameters(newUrl, value);
                        newUrl = ApplyDictionaryParameters(newUrl, "metadata", value as Dictionary<string, string>);
                    else newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName, value.ToString());
                }
            }

            return newUrl;
        }

        private static string ApplyDictionaryParameters<T>(string newUrl, string propertyName, Dictionary<string, T> values)
        {
            foreach (var kvp in values)
            {
                newUrl = ApplyParameterToUrl(newUrl, $"{propertyName}[{kvp.Key}]", kvp.Value.ToString());
            }

            return newUrl;
        }

//        private static string ApplyMetadataParameters(string newUrl, object value)
//        {
//            var metadata = (Dictionary<string, string>)value;
//
//            foreach (string key in metadata.Keys)
//            {
//                newUrl = ApplyParameterToUrl(newUrl, $"metadata[{key}]", metadata[key]);
//            }
//
//            return newUrl;
//        }
    }
}
