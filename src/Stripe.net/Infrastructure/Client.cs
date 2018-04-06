using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Reflection;
using Newtonsoft.Json;
#if NET45
using Microsoft.Win32;
#else
using System.Runtime.InteropServices;
#endif

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
            var values = new Dictionary<string, string>
            {
                { "bindings_version", StripeConfiguration.StripeNetVersion },
                { "lang", ".net" },
                { "publisher", "stripe" },
            };

#if NET45
            values.Add("lang_version", ".NET Framework 4.5+");
            values.Add("os_version", Environment.OSVersion.ToString());

            string monoVersion = Client.GetMonoVersion();
            if (monoVersion != null) {
                values.Add("mono_version", monoVersion);
            }
#else
            values.Add("lang_version", RuntimeInformation.FrameworkDescription);
            values.Add("os_version", RuntimeInformation.OSDescription);
#endif

            return JsonConvert.SerializeObject(values, Formatting.None);
        }

#if NET45
        private static string GetMonoVersion()
        {
            Type monoRuntimeType;
            MethodInfo getDisplayNameMethod;
            if ((monoRuntimeType = typeof(object).Assembly.GetType("Mono.Runtime")) != null &&
                (getDisplayNameMethod = monoRuntimeType.GetMethod("GetDisplayName",
                BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.ExactBinding, null,
                        Type.EmptyTypes, null)) != null) {
                return (string)getDisplayNameMethod.Invoke(null, null);
            }
            return null;
        }
#endif
    }
}
