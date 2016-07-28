using System.Reflection;

namespace Stripe
{
    public static class StripeConfiguration
    {
        /// <summary>
        /// <para>This is the api version of Stripe that Stripe.net uses. You only need to be concerned if you are using webhooks (Stripe Events).</para>
        /// <para>If you are using webhooks and are having issues, email Stripe and ask them to downgrade your api version to match the StripeApiVersion.</para>
        /// </summary>
        public static string StripeApiVersion = "2015-09-08";
        public static string StripeNetVersion { get; private set; }

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
