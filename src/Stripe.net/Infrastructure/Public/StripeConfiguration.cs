namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Global configuration class for Stripe.net settings.
    /// </summary>
    public static class StripeConfiguration
    {
        private static string apiKey;
        private static string clientId;

        private static IStripeClient stripeClient;

        static StripeConfiguration()
        {
            StripeNetVersion = new AssemblyName(typeof(StripeConfiguration).GetTypeInfo().Assembly.FullName).Version.ToString(3);
        }

        /// <summary>API version used by Stripe.net.</summary>
        public static string ApiVersion => "2019-03-14";

        /// <summary>Default base URL for Stripe's API.</summary>
        public static string DefaultApiBase => "https://api.stripe.com";

        /// <summary>Default base URL for Stripe's OAuth API.</summary>
        public static string DefaultConnectBase => "https://connect.stripe.com";

        /// <summary>Default base URL for Stripe's Files API.</summary>
        public static string DefaultFilesBase => "https://files.stripe.com";

        /// <summary>Default timespan before the request times out.</summary>
        public static TimeSpan DefaultHttpTimeout => TimeSpan.FromSeconds(80);

        /// <summary>
        /// Maximum sleep time between tries to send HTTP requests after network failure.
        /// </summary>
        public static TimeSpan MaxNetworkRetriesDelay => TimeSpan.FromSeconds(5);

        /// <summary>
        /// Minimum sleep time between tries to send HTTP requests after network failure.
        /// </summary>
        public static TimeSpan MinNetworkRetriesDelay => TimeSpan.FromMilliseconds(500);

        /// <summary>Gets or sets the base URL for Stripe's API.</summary>
        public static string ApiBase { get; set; } = DefaultApiBase;

#if NET45 || NETSTANDARD2_0
        /// <summary>Gets or sets the API key.</summary>
        /// <remarks>
        /// You can also set the API key using the <c>StripeApiKey</c> key in
        /// <see cref="System.Configuration.ConfigurationManager.AppSettings"/>.
        /// </remarks>
#else
        /// <summary>Gets or sets the API key.</summary>
#endif
        public static string ApiKey
        {
            get
            {
#if NET45 || NETSTANDARD2_0
                if (string.IsNullOrEmpty(apiKey))
                {
                    apiKey = System.Configuration.ConfigurationManager.AppSettings["StripeApiKey"];
                }
#endif
                return apiKey;
            }

            set => apiKey = value;
        }

#if NET45 || NETSTANDARD2_0
        /// <summary>Gets or sets the client ID.</summary>
        /// <remarks>
        /// You can also set the client ID using the <c>StripeClientId</c> key in
        /// <see cref="System.Configuration.ConfigurationManager.AppSettings"/>.
        /// </remarks>
#else
        /// <summary>Gets or sets the client ID.</summary>
#endif
        public static string ClientId
        {
            get
            {
#if NET45 || NETSTANDARD2_0
                if (string.IsNullOrEmpty(apiKey))
                {
                    clientId = System.Configuration.ConfigurationManager.AppSettings["StripeClientId"];
                }
#endif
                return clientId;
            }

            set => clientId = value;
        }

        /// <summary>Gets or sets the base URL for Stripe's OAuth API.</summary>
        public static string ConnectBase { get; set; } = DefaultConnectBase;

        /// <summary>Gets or sets a value indicating whether telemetry is enabled.</summary>
        public static bool EnableTelemetry { get; set; }

        /// <summary>Gets or sets the base URL for Stripe's Files API.</summary>
        public static string FilesBase { get; set; } = DefaultFilesBase;

        /// <summary>
        /// Gets or sets the settings used for deserializing JSON objects returned by Stripe's API.
        /// It is highly recommended you do not change these settings, as doing so can produce
        /// unexpected results. If you do change these settings, make sure that
        /// <see cref="Stripe.Infrastructure.StripeObjectConverter"/> is among the converters,
        /// otherwise Stripe.net will no longer be able to deserialize polymorphic resources
        /// represented by interfaces (e.g. <see cref="IPaymentSource"/>).
        /// </summary>
        public static JsonSerializerSettings SerializerSettings { get; set; } = DefaultSerializerSettings();

        /// <summary>
        /// Gets or sets the maximum number of times that the library will retry requests that
        /// appear to have failed due to an intermittent problem.
        /// </summary>
        public static int MaxNetworkRetries { get; set; }

        /// <summary>
        /// Gets or sets a custom <see cref="StripeClient"/> for sending requests to Stripe's
        /// API. You can use this to use a custom message handler, set proxy parameters, etc.
        /// </summary>
        /// <example>
        /// To use a custom message handler:
        /// <code>
        /// System.Net.Http.HttpMessageHandler messageHandler = ...;
        /// var httpClient = new System.Net.HttpClient(messageHandler);
        /// var stripeClient = new Stripe.StripeClient(new Stripe.SystemNetHttpClient(httpClient));
        /// Stripe.StripeConfiguration.StripeClient = stripeClient;
        /// </code>
        /// </example>
        public static IStripeClient StripeClient
        {
            get
            {
                if (stripeClient == null)
                {
                    stripeClient = new StripeClient();
                }

                return stripeClient;
            }

            set => stripeClient = value;
        }

        /// <summary>Gets the version of the Stripe.net client library.</summary>
        public static string StripeNetVersion { get; }

        /// <summary>Gets or sets a value indicating whether to sleep between network retries.</summary>
        /// <remarks>This is an internal property meant to be used in tests.</remarks>
        internal static bool NetworkRetriesSleep { get; set; } = true;

        /// <summary>
        /// Returns a new instance of <see cref="Newtonsoft.Json.JsonSerializerSettings"/> with
        /// the default settings used by Stripe.net.
        /// </summary>
        /// <returns>A <see cref="Newtonsoft.Json.JsonSerializerSettings"/> instance.</returns>
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

        // TODO: remove everything below this in a future major version

        /// <summary>
        /// Sets the base URL.for Stripe's API.
        /// This method is deprecated and will be removed in a future version, please use the
        /// <see cref="ApiBase"/> property setter instead.
        /// </summary>
        /// <param name="baseUrl">Base URL.for Stripe's API.</param>
        [Obsolete("Use StripeConfiguration.ApiBase getter instead.")]
        public static void SetApiBase(string baseUrl)
        {
            ApiBase = baseUrl;
        }

        /// <summary>
        /// Sets the API key.
        /// This method is deprecated and will be removed in a future version, please use the
        /// <see cref="ApiKey"/> property setter instead.
        /// </summary>
        /// <param name="newApiKey">API key.</param>
        [Obsolete("Use StripeConfiguration.ApiKey setter instead.")]
        public static void SetApiKey(string newApiKey)
        {
            ApiKey = newApiKey;
        }

        /// <summary>
        /// Sets the base URL.for Stripe's OAuth API.
        /// This method is deprecated and will be removed in a future version, please use the
        /// <see cref="ConnectBase"/> property setter instead.
        /// </summary>
        /// <param name="baseUrl">Base URL.for Stripe's OAuth API.</param>
        [Obsolete("Use StripeConfiguration.ConnectBase setter instead.")]
        public static void SetConnectBase(string baseUrl)
        {
            ConnectBase = baseUrl;
        }

        /// <summary>
        /// Sets the base URL.for Stripe's Files API.
        /// This method is deprecated and will be removed in a future version, please use the
        /// <see cref="FilesBase"/> property setter instead.
        /// </summary>
        /// <param name="baseUrl">Base URL.for Stripe's Files API.</param>
        [Obsolete("Use StripeConfiguration.FilesBase setter instead.")]
        public static void SetFilesBase(string baseUrl)
        {
            FilesBase = baseUrl;
        }
    }
}
