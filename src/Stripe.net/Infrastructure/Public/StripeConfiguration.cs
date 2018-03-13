using System;
using System.Net.Http;
using System.Reflection;
using Stripe.Infrastructure;

namespace Stripe
{
    public static class StripeConfiguration
    {
        public static string StripeApiVersion = "2018-02-06";
        public static string StripeNetVersion { get; }

        /// <summary>
        /// This option allows you to provide your own HttpMessageHandler. Useful with Android/iPhone.
        /// </summary>
        public static HttpMessageHandler HttpMessageHandler { get; set; } 

        public static TimeSpan? HttpTimeSpan { get; set; }

        private static string _apiKey;
        private static string _apiBase;
        private static string _uploadsBase;
        private static string _connectBase;

        static StripeConfiguration()
        {
            StripeNetVersion = new AssemblyName(typeof(Requestor).GetTypeInfo().Assembly.FullName).Version.ToString(3);
        }

        internal static string GetApiKey()
        {
            if (string.IsNullOrEmpty(_apiKey))
            {
#if NET45
                _apiKey = System.Configuration.ConfigurationManager.AppSettings["StripeApiKey"];
#endif
            }

            return _apiKey;
        }

        public static void SetApiKey(string newApiKey)
        {
            _apiKey = newApiKey;
        }

        internal static string GetApiBase()
        {
            if (string.IsNullOrEmpty(_apiBase))
            {
                _apiBase = Urls.DefaultBaseUrl;
            }
            return _apiBase;
        }

        public static void SetApiBase(string baseUrl)
        {
            _apiBase = baseUrl;
        }

        internal static string GetUploadsBase()
        {
            if (string.IsNullOrEmpty(_uploadsBase))
            {
                _uploadsBase = Urls.DefaultBaseUploadsUrl;
            }
            return _uploadsBase;
        }

        public static void SetUploadsBase(string baseUrl)
        {
            _uploadsBase = baseUrl;
        }

        internal static string GetConnectBase()
        {
            if (string.IsNullOrEmpty(_connectBase))
            {
                _connectBase = Urls.DefaultBaseConnectUrl;
            }
            return _connectBase;
        }

        public static void SetConnectBase(string baseUrl)
        {
            _connectBase = baseUrl;
        }
    }
}
