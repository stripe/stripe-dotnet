using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe.Infrastructure.Middleware
{
    public static class RequestStringBuilder
    {
        private static IEnumerable<IParserPlugin> ParserPlugins { get; }

        static RequestStringBuilder()
        {
            if (ParserPlugins != null) return;

            // use reflection so this works on the bin directory?
            ParserPlugins = new List<IParserPlugin>
            {
                new AdditionalOwnerPlugin(),
                new ArrayPlugin(),
                new DateFilterPlugin(),
                new DictionaryPlugin(),
                new EnumPlugin(),
                new OrderItemsPlugin(),
                new PlanTiersPlugin(),
                new SubscriptionItemPlugin(),
                new SubscriptionItemUpdatedPlugin(),
                new InvoiceSubscriptionItemPlugin()
            };
        }

        internal static void ProcessPlugins(ref string requestString, JsonPropertyAttribute attribute, PropertyInfo property, object propertyValue, object propertyParent)
        {
            var parsedParameter = false;

            foreach (var plugin in ParserPlugins)
            {
                if(!parsedParameter)
                    parsedParameter = plugin.Parse(ref requestString, attribute, property, propertyValue, propertyParent);
            }

            if (!parsedParameter)
                ApplyParameterToRequestString(ref requestString, attribute.PropertyName, string.Format(CultureInfo.InvariantCulture, "{0}", propertyValue));
        }

        public static void ApplyParameterToRequestString(ref string requestString, string argument, string value)
        {
            var token = "&";

            if (!requestString.Contains("?"))
                token = "?";

            requestString = $"{requestString}{token}{argument}={WebUtility.UrlEncode(value)}";
        }
    }
}
