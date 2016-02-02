using System;
#if !PORTABLE
using System.Configuration;
#endif

namespace Stripe
{
    public static class StripeConfiguration
    {
        private static string _apiKey;
        internal const string SupportedApiVersion = "2015-02-18";

        static StripeConfiguration()
        {
            ApiVersion = SupportedApiVersion;
        }

        internal static string GetApiKey()
        {
            if (string.IsNullOrEmpty(_apiKey))
            {
#if PORTABLE
                throw new Exception("You must explicitly specify the ApiKey on Portable platforms.");
#else
                _apiKey = ConfigurationManager.AppSettings["StripeApiKey"];
#endif
            }

            return _apiKey;
        }

        public static void SetApiKey(string newApiKey)
        {
            _apiKey = newApiKey;
        }

        public static string ApiVersion { get; internal set; }
    }
}
