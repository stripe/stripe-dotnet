namespace Stripe.Infrastructure.Middleware
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Net;
    using System.Reflection;
    using Newtonsoft.Json;

    public static class RequestStringBuilder
    {
        static RequestStringBuilder()
        {
            if (ParserPlugins != null)
            {
                return;
            }

            // use reflection so this works on the bin directory?
            ParserPlugins = new List<IParserPlugin>
            {
                new ArrayPlugin(),
                new DateFilterPlugin(),
                new DictionaryPlugin(),
                new EnumPlugin(),
                new ListPlugin(),
            };
        }

        private static IEnumerable<IParserPlugin> ParserPlugins { get; }

        internal static void ProcessPlugins(ref string requestString, JsonPropertyAttribute attribute, PropertyInfo property, object propertyValue, object propertyParent)
        {
            var parsedParameter = false;

            foreach (var plugin in ParserPlugins)
            {
                if (!parsedParameter)
                {
                    parsedParameter = plugin.Parse(ref requestString, attribute, property, propertyValue, propertyParent);
                }
            }

            if (!parsedParameter)
            {
                ApplyParameterToRequestString(ref requestString, attribute.PropertyName, string.Format(CultureInfo.InvariantCulture, "{0}", propertyValue));
            }
        }

        public static void ApplyParameterToRequestString(ref string requestString, string argument, string value)
        {
            var token = "&";

            if (!requestString.Contains("?"))
            {
                token = "?";
            }

            requestString = $"{requestString}{token}{argument}={WebUtility.UrlEncode(value)}";
        }
    }
}
