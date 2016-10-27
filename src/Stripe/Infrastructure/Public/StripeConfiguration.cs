using System.Net.Http;
using System.Reflection;
using Stripe.Infrastructure;

namespace Stripe
{
    public static class StripeConfiguration
    {
        /// <summary>
        /// <para>This is the API version that Stripe.net will automatically use when working with Stripe. You only need to be concerned if you are using webhooks (Stripe Events) and having issues.</para>
        /// <para>If you notice webhooks are not working correctly, email Stripe and ask them to downgrade your API version to match the StripeApiVersion. Work is going on to catch up so this isn't necessary!</para>
        /// </summary>
        public static string StripeApiVersion = "2016-07-06";
        public static string StripeNetVersion { get; private set; }

        /// <summary>
        /// This option allows you to provide your own HttpMessageHandler. Useful with Android/iPhone and/or adding in ModernHttpClient.
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
#if !PORTABLE
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
