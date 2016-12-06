using System.Net.Http;
using System.Reflection;
using Stripe.Infrastructure;

namespace Stripe
{
    public static class StripeConfiguration
    {
        /// <summary>
        /// If this isn't the latest version of the Stripe API, it's news to me.
        /// </summary>
        public static string StripeApiVersion = "2016-07-06";
        public static string StripeNetVersion { get; private set; }

        /// <summary>
        /// This option allows you to provide your own HttpMessageHandler. Useful with Android/iPhone.
        /// </summary>
        public static HttpMessageHandler HttpMessageHandler { get; set; } 

        private static string _apiKey;

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
    }
}
