namespace Stripe.Infrastructure
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.Text.RegularExpressions;
    using Stripe.Infrastructure.Middleware;

    internal static class ParameterBuilder
    {
        public static string ApplyAllParameters<T>(this Service<T> service, BaseOptions obj, string url, bool isListMethod = false)
            where T : IStripeEntity
        {
            // store the original url from the service call into requestString (e.g. https://api.stripe.com/v1/accounts/account_id)
            // before the stripe attributes get applied. all of the attributes that will get passed to stripe will be applied to this string,
            // don't worry - if the request is a post, the Requestor will take care of moving the attributes to the post body
            var requestString = url;

            // obj = the options object passed from the service
            if (obj != null)
            {
                RequestStringBuilder.CreateQuery(ref requestString, obj);

                foreach (KeyValuePair<string, string> pair in obj.ExtraParams)
                {
                    var key = WebUtility.UrlEncode(pair.Key);
                    RequestStringBuilder.ApplyParameterToRequestString(ref requestString, key, pair.Value);
                }

                foreach (var value in obj.Expand)
                {
                    RequestStringBuilder.ApplyParameterToRequestString(ref requestString, "expand[]", value);
                }
            }

            if (service != null)
            {
                // expandable properties
                var propertiesToExpand = service.GetType()
                    .GetRuntimeProperties()
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

                    requestString = ApplyParameterToUrl(requestString, "expand[]", expandPropertyName);
                }
            }

            return requestString;
        }

        public static string ApplyParameterToUrl(string url, string argument, string value)
        {
            RequestStringBuilder.ApplyParameterToRequestString(ref url, argument, value);

            return url;
        }
    }
}
