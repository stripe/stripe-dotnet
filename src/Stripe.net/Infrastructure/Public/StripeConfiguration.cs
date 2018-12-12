namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Reflection;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public static class StripeConfiguration
    {
        private static string stripeApiVersion = "2018-11-08";

        private static string apiKey;
        private static string apiBase;
        private static string connectBase;
        private static string filesBase;
        private static JsonSerializerSettings serializerSettings = DefaultSerializerSettings();

        static StripeConfiguration()
        {
            StripeNetVersion = new AssemblyName(typeof(Requestor).GetTypeInfo().Assembly.FullName).Version.ToString(3);
        }

        public static string StripeApiVersion
        {
            get { return stripeApiVersion; }
            set { stripeApiVersion = value; }
        }

        /// <summary>
        /// Gets or sets the settings used for deserializing JSON objects returned by Stripe's API.
        /// It is highly recommended you do not change these settings, as doing so can produce
        /// unexpected results. If you do change these settings, make sure that
        /// <see cref="Stripe.Infrastructure.StripeObjectConverter"/> is among the converters,
        /// otherwise the library will no longer be able to deserialize polymorphic resources
        /// represented by interfaces (e.g. <see cref="IPaymentSource"/>).
        /// </summary>
        public static JsonSerializerSettings SerializerSettings
        {
            get { return serializerSettings; }
            set { serializerSettings = value; }
        }

        public static string StripeNetVersion { get; }

        /// <summary>
        /// This option allows you to provide your own HttpMessageHandler. Useful with Android/iPhone.
        /// </summary>
        public static HttpMessageHandler HttpMessageHandler { get; set; }

        public static TimeSpan? HttpTimeSpan { get; set; }

        internal static string GetApiKey()
        {
#if NET45
            if (string.IsNullOrEmpty(apiKey))
            {
                apiKey = System.Configuration.ConfigurationManager.AppSettings["StripeApiKey"];
            }
#endif

            return apiKey;
        }

        public static void SetApiKey(string newApiKey)
        {
            apiKey = newApiKey;
        }

        internal static string GetApiBase()
        {
            if (string.IsNullOrEmpty(apiBase))
            {
                apiBase = Urls.DefaultBaseUrl;
            }

            return apiBase;
        }

        public static void SetApiBase(string baseUrl)
        {
            apiBase = baseUrl;
        }

        internal static string GetConnectBase()
        {
            if (string.IsNullOrEmpty(connectBase))
            {
                connectBase = Urls.DefaultBaseConnectUrl;
            }

            return connectBase;
        }

        public static void SetConnectBase(string baseUrl)
        {
            connectBase = baseUrl;
        }

        internal static string GetFilesBase()
        {
            if (string.IsNullOrEmpty(filesBase))
            {
                filesBase = Urls.DefaultBaseFilesUrl;
            }

            return filesBase;
        }

        public static void SetFilesBase(string baseUrl)
        {
            filesBase = baseUrl;
        }

        /// <summary>
        /// Returns a new instance of <see cref="Newtonsoft.Json.JsonSerializerSettings"/> with
        /// the default settings used by Stripe.net.
        /// <summary>
        public static JsonSerializerSettings DefaultSerializerSettings()
        {
            return new JsonSerializerSettings
            {
                Converters = new List<JsonConverter>
                {
                    new StripeObjectConverter(),
                },
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
}
