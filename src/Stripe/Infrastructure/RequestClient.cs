using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;

namespace Stripe.Infrastructure
{
    internal class RequestClient
    {
        private HttpRequestMessage RequestMessage { get; set; }

        public RequestClient(HttpRequestMessage requestMessage)
        {
            RequestMessage = requestMessage;
        }

        public void ApplyUserAgent()
        {
            RequestMessage.Headers.UserAgent.TryParseAdd($"User-Agent: Stripe/v1 .NetBindings/{StripeConfiguration.StripeNetVersion}");
        }

        public void ApplyClientData()
        {
            RequestMessage.Headers.Add("X-Stripe-Client-User-Agent", GetClientUserAgentString());
        }

        private string GetClientUserAgentString()
        {
            var values = new Dictionary<string, string>();

            values.Add("bindings_version", StripeConfiguration.StripeNetVersion);
            values.Add("lang", ".NET");
            values.Add("publisher", "Jayme Davis");
            values.Add("lang_version", GetLangVersion());
            values.Add("platform", typeof(object).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyProductAttribute>().Product);

            return BuildJsonObject(values);
        }

        private string GetLangVersion()
        {
            var assembly = typeof(object).GetTypeInfo().Assembly;

            var assemblyName = new AssemblyName(assembly.FullName);
            return assemblyName.Version.Major + "." + assemblyName.Version.Minor + "." + assemblyName.Version.Revision;
        }

        // i want to move away from json.net. this is a simple serializer
        private string BuildJsonObject(Dictionary<string, string> items)
        {
            var result = new StringBuilder();

            for (var item = 0; item < items.Count; item++)
            {
                // if it's the first item, add the opening bracket.
                if (item == 0) result.Append("{");

                // add the key/value
                result.AppendFormat("\"{0}\": \"{1}\"", 
                    items.Keys.ElementAt(item), 
                    WebUtility.HtmlEncode(items.Values.ElementAt(item))
                );

                // if it's not the last item, add a comma
                if (item < items.Count - 1) result.Append(", ");

                // if it is the last item, close the json object
                if (item == items.Count - 1) result.Append("}");
            }

            return result.ToString();
        }
    }
}