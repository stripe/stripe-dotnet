using System.Reflection;
using System.Web;

namespace Stripe
{
    internal static class ParameterBuilder
    {
        public static string ApplyAllParameters(object obj, string url)
        {
            if (obj == null) return url;

            var newUrl = url;

            foreach (var property in obj.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
            {
                foreach (var attribute in property.GetCustomAttributes(false))
                {
                    if (attribute.GetType() != typeof(StripeArgumentAttribute)) continue;
                   
                    var stripeArgumentAttribute = (StripeArgumentAttribute)attribute;

                    var value = property.GetValue(obj, null);

                    if (value != null)
                        newUrl = ApplyParameterToUrl(newUrl, stripeArgumentAttribute.Field, value.ToString());
                }
            }

            return newUrl;
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
