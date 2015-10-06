using System;
using System.Configuration;

namespace Stripe
{
    public static class StripeConfiguration
    {
        private static string _apiKey;
        internal const string SupportedApiVersion = "2015-09-08";

        static StripeConfiguration()
        {
            ApiVersion = SupportedApiVersion;
        }

        internal static string GetApiKey()
        {
            if (string.IsNullOrEmpty(_apiKey))
                _apiKey = ConfigurationManager.AppSettings["StripeApiKey"];

            return _apiKey;
        }

        public static void SetApiKey(string newApiKey)
        {
            _apiKey = newApiKey;
        }

        public static string ApiVersion { get; internal set; }
    }
}
