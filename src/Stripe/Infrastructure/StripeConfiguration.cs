using System;
#if !WINDOWS_UAP
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
#if WINDOWS_UAP
                throw new Exception("You must SetApiKey on Windows Universal Platform");
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
