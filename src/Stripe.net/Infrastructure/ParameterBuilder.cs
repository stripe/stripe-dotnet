using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Stripe.Infrastructure
{
    internal static class ParameterBuilder
    {
        public static string ApplyAllParameters(this StripeService service, object obj, string url, bool isListMethod = false)
        {
            // store the original url from the service call into requestString (e.g. https://api.stripe.com/v1/accounts/account_id)
            // before the stripe attributes get applied. all of the attributes that will get passed to stripe will be applied to this string,
            // don't worry - if the request is a post, the Requestor will take care of moving the attributes to the post body
            var requestString = url;

            // obj = the options object passed from the service
            if (obj != null)
            {
                foreach (var property in obj.GetType().GetRuntimeProperties())
                {
                    var value = property.GetValue(obj, null);
                    if (value == null) continue;

                    foreach (var attribute in property.GetCustomAttributes<JsonPropertyAttribute>())
                    {
                        if (attribute.PropertyName.ToLower().Contains("metadata"))
                            requestString = ApplyMetadataParameters(requestString, value);
                        else if (attribute.PropertyName.ToLower().Contains("fraud_details"))
                        {
                            var fraudDetails = (Dictionary<string, string>)value;

                            foreach (string key in fraudDetails.Keys)
                            {
                                requestString = ApplyParameterToUrl(requestString, $"fraud_details[{key}]", fraudDetails[key]);
                            }
                        }
                        else if (property.PropertyType == typeof(StripeDateFilter))
                        {
                            var filter = (StripeDateFilter)value;

                            if (filter.EqualTo.HasValue)
                                requestString = ApplyParameterToUrl(requestString, attribute.PropertyName, filter.EqualTo.Value.ConvertDateTimeToEpoch().ToString());

                            if (filter.LessThan.HasValue)
                                requestString = ApplyParameterToUrl(requestString, attribute.PropertyName + "[lt]", filter.LessThan.Value.ConvertDateTimeToEpoch().ToString());

                            if (filter.LessThanOrEqual.HasValue)
                                requestString = ApplyParameterToUrl(requestString, attribute.PropertyName + "[lte]", filter.LessThanOrEqual.Value.ConvertDateTimeToEpoch().ToString());

                            if (filter.GreaterThan.HasValue)
                                requestString = ApplyParameterToUrl(requestString, attribute.PropertyName + "[gt]", filter.GreaterThan.Value.ConvertDateTimeToEpoch().ToString());

                            if (filter.GreaterThanOrEqual.HasValue)
                                requestString = ApplyParameterToUrl(requestString, attribute.PropertyName + "[gte]", filter.GreaterThanOrEqual.Value.ConvertDateTimeToEpoch().ToString());
                        }
                        else if (value as INestedOptions != null)
                        {
                            requestString = ApplyNestedObjectProperties(requestString, value);
                        }
                        else
                        {
                            requestString = ApplyParameterToUrl(requestString, attribute.PropertyName, value.ToString());
                        }
                    }
                }
            }

            if (service != null)
            {
                // expandable properties
                var propertiesToExpand = service.GetType()
                    .GetRuntimeProperties()
                    .Where(p => p.Name.StartsWith("Expand") && p.PropertyType == typeof(bool))
                    .Where(p => (bool) p.GetValue(service, null))
                    .Select(p => p.Name);

                foreach (var propertyName in propertiesToExpand)
                {
                    string expandPropertyName = propertyName.Substring("Expand".Length);
                    expandPropertyName = Regex.Replace(expandPropertyName, "([a-z])([A-Z])", "$1_$2").ToLower();

                    if (isListMethod)
                    {
                        expandPropertyName = "data." + expandPropertyName;
                    }

                    requestString = ApplyParameterToUrl(requestString, "expand[]", expandPropertyName);

                    // note for someday - I had no idea you could expand properties beyond the first level (up to 4 before stripe throws and exception).
                    // something to consider adding to the project.
                    //
                    // example:
                    // requestString = ApplyParameterToUrl(requestString, "expand[]", "data.charge.dispute.charge.dispute.charge.dispute");
                }
            }

            return requestString;
        }

        public static string ApplyParameterToUrl(string url, string argument, string value)
        {
            var token = "&";

            if (!url.Contains("?"))
                token = "?";

            return $"{url}{token}{argument}={WebUtility.UrlEncode(value)}";
        }

        private static string ApplyNestedObjectProperties(string requestString, object nestedObject)
        {
            foreach (var property in nestedObject.GetType().GetRuntimeProperties())
            {
                var value = property.GetValue(nestedObject, null);
                if (value == null) continue;

                foreach (var attribute in property.GetCustomAttributes<JsonPropertyAttribute>())
                {
                    if (attribute.PropertyName.ToLower().Contains("metadata"))
                        requestString = ApplyMetadataParameters(requestString, value);
                    else
                        requestString = ApplyParameterToUrl(requestString, attribute.PropertyName, value.ToString());
                }
            }

            return requestString;
        }

        private static string ApplyMetadataParameters(string requestString, object value)
        {
            var metadata = (Dictionary<string, string>)value;

            foreach (string key in metadata.Keys)
            {
                requestString = ApplyParameterToUrl(requestString, $"metadata[{key}]", metadata[key]);
            }

            return requestString;
        }
    }
}
