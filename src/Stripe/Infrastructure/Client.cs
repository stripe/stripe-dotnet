using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe.Infrastructure
{
    internal class Client
    {
        private HttpRequestMessage RequestMessage { get; set; }

        public Client(HttpRequestMessage requestMessage)
        {
            RequestMessage = requestMessage;
        }

        public void ApplyUserAgent()
        {
            RequestMessage.Headers.UserAgent.ParseAdd($"Stripe/v1 .NetBindings/{StripeConfiguration.StripeNetVersion}");
        }

        public void ApplyClientData()
        {
            RequestMessage.Headers.Add("X-Stripe-Client-User-Agent", GetClientUserAgentString());
        }

        private string GetClientUserAgentString()
        {
            var langVersion = "unknown";

#if !PORTABLE
            langVersion = typeof(object).GetTypeInfo().Assembly.ImageRuntimeVersion;
#endif

            // check for mono and replace langVersion if it's present
            var type = Type.GetType("Mono.Runtime");

            if (type != null)
            {
                var getDisplayName = type.GetTypeInfo().GetDeclaredMethod("GetDisplayName");
                langVersion = getDisplayName?.Invoke(null, null).ToString();
            }

            var values = new Dictionary<string, string>
            {
                {"bindings_version", StripeConfiguration.StripeNetVersion},
                {"lang", ".net"},
                {"publisher", "Jayme Davis"},
                {"lang_version", WebUtility.HtmlEncode(langVersion)},
                {"uname", WebUtility.HtmlEncode(GetSystemInformation())}
            };

            return JsonConvert.SerializeObject(values);
        }

        private string GetSystemInformation()
        {
            var result = string.Empty;
            
#if !PORTABLE
            result += $"net45.platform: {Environment.OSVersion.VersionString}";
#else
            result += $"portable.platform: {typeof(object).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyProductAttribute>().Product}";
#endif

            return result;
        }
    }
}