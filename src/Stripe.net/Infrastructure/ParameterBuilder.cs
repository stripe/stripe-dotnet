using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Stripe.Infrastructure.Middleware;

namespace Stripe.Infrastructure
{
    internal static class ParameterBuilder
    {
        public static string ApplyAllParameters(this StripeService service, StripeBaseOptions obj, string url, bool isListMethod = false)
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
                        if (value is INestedOptions)
                            ApplyNestedObjectProperties(ref requestString, value);
                        else
                            RequestStringBuilder.ProcessPlugins(ref requestString, attribute, property, value, obj);
                    }
                }

                foreach (KeyValuePair<string, string> pair in obj.ExtraParams)
                {
                    var key = WebUtility.UrlEncode(pair.Key);
                    RequestStringBuilder.ApplyParameterToRequestString(ref requestString, key, pair.Value);
                }
                foreach (var value in obj.Expand) {
                    RequestStringBuilder.ApplyParameterToRequestString(ref requestString, "expand[]", value);
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

                    // note: I had no idea you could expand properties beyond the first level (up to 4 before stripe throws an exception).
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
            RequestStringBuilder.ApplyParameterToRequestString(ref url, argument, value);

            return url;
        }

        private static void ApplyNestedObjectProperties(ref string requestString, object nestedObject)
        {
            foreach (var property in nestedObject.GetType().GetRuntimeProperties())
            {
                var value = property.GetValue(nestedObject, null);
                if (value == null) continue;

                foreach (var attribute in property.GetCustomAttributes<JsonPropertyAttribute>())
                    RequestStringBuilder.ProcessPlugins(ref requestString, attribute, property, value, nestedObject);
            }
        }
    }
}
