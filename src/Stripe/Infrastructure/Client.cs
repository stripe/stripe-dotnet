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
            var langVersion = "4.5";

#if !PORTABLE
            langVersion = typeof(object).GetTypeInfo().Assembly.ImageRuntimeVersion;
#endif

            var mono = testForMono();
            if (!string.IsNullOrEmpty(mono)) langVersion = mono;

            var values = new Dictionary<string, string>
            {
                { "bindings_version", StripeConfiguration.StripeNetVersion },
                { "lang", ".net" },
                { "publisher", "Jayme Davis" },
                { "lang_version", WebUtility.HtmlEncode(langVersion) },
                { "uname", WebUtility.HtmlEncode(getSystemInformation()) }
            };

            return JsonConvert.SerializeObject(values);
        }

        private string testForMono()
        {
            var type = Type.GetType("Mono.Runtime");
            var getDisplayName = type?.GetTypeInfo().GetDeclaredMethod("GetDisplayName");

            return getDisplayName?.Invoke(null, null).ToString();
        }

        private string getSystemInformation()
        {
            var result = string.Empty;

#if !PORTABLE
            result += $"net45.platform: { Environment.OSVersion.VersionString }";
            result += $", {getOperatingSystemInfo()}"; 
#else
            result += "portable.platform: ";

            try
            {
                result += typeof(object).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyProductAttribute>().Product;
            }
            catch
            {
                result += "unknown";
            }
#endif

            return result;
        }

#if !PORTABLE
        private string getOperatingSystemInfo()
        {
            var os = Environment.OSVersion;
            var pid = os.Platform;

            switch (pid)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    return "OS: Windows";
                case PlatformID.Unix:
                    return "OS: Unix";
                default:
                    return "OS: Unknown";
            }
        }
#endif

    }
}