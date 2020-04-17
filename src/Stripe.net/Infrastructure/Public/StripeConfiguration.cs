namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Reflection;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Global configuration class for Stripe.net settings.
    /// </summary>
    public static class StripeConfiguration
    {
        private static string apiKey;

        private static AppInfo appInfo;

        private static string clientId;

        private static bool enableTelemetry = true;

        private static int maxNetworkRetries = SystemNetHttpClient.DefaultMaxNumberRetries;

        private static IStripeClient stripeClient;

        static StripeConfiguration()
        {
            StripeNetVersion = new AssemblyName(typeof(StripeConfiguration).GetTypeInfo().Assembly.FullName).Version.ToString(3);
        }

        /// <summary>API version used by Stripe.net.</summary>
        public static string ApiVersion => "2020-03-02";

        /// <summary>Gets or sets the API key.</summary>
        /// <remarks>
        /// You can also set the API key using the <c>StripeApiKey</c> key in
        /// <see cref="System.Configuration.ConfigurationManager.AppSettings"/>.
        /// </remarks>
        public static string ApiKey
        {
            get
            {
                if (string.IsNullOrEmpty(apiKey) &&
                    !string.IsNullOrEmpty(ConfigurationManager.AppSettings["StripeApiKey"]))
                {
                    apiKey = ConfigurationManager.AppSettings["StripeApiKey"];
                }

                return apiKey;
            }

            set
            {
                if (value != apiKey)
                {
                    StripeClient = null;
                }

                apiKey = value;
            }
        }

        /// <summary>Gets or sets the client ID.</summary>
        /// <remarks>
        /// You can also set the client ID using the <c>StripeClientId</c> key in
        /// <see cref="System.Configuration.ConfigurationManager.AppSettings"/>.
        /// </remarks>
        public static string ClientId
        {
            get
            {
                if (string.IsNullOrEmpty(apiKey) &&
                    !string.IsNullOrEmpty(ConfigurationManager.AppSettings["StripeClientId"]))
                {
                    clientId = ConfigurationManager.AppSettings["StripeClientId"];
                }

                return clientId;
            }

            set
            {
                if (value != clientId)
                {
                    StripeClient = null;
                }

                clientId = value;
            }
        }

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
        public static int MaxNetworkRetries
        {
            get => maxNetworkRetries;

            set
            {
                if (value != maxNetworkRetries)
                {
                    StripeClient = null;
                }

                maxNetworkRetries = value;
            }
        }

        /// <summary>
        /// Gets or sets the flag enabling request latency telemetry. Enabled by default.
        /// </summary>
        public static bool EnableTelemetry
        {
            get => enableTelemetry;

            set
            {
                if (value != enableTelemetry)
                {
                    StripeClient = null;
                }

                enableTelemetry = value;
            }
        }

        /// <summary>
        /// Gets or sets a custom <see cref="StripeClient"/> for sending requests to Stripe's
        /// API. You can use this to use a custom message handler, set proxy parameters, etc.
        /// </summary>
        /// <example>
        /// To use a custom message handler:
        /// <code>
        /// System.Net.Http.HttpMessageHandler messageHandler = ...;
        /// var httpClient = new System.Net.HttpClient(messageHandler);
        /// var stripeClient = new Stripe.StripeClient(
        ///     stripeApiKey,
        ///     httpClient: new Stripe.SystemNetHttpClient(httpClient));
        /// Stripe.StripeConfiguration.StripeClient = stripeClient;
        /// </code>
        /// </example>
        public static IStripeClient StripeClient
        {
            get
            {
                if (stripeClient == null)
                {
                    stripeClient = BuildDefaultStripeClient();
                }

                return stripeClient;
            }

            set => stripeClient = value;
        }

        /// <summary>Gets the version of the Stripe.net client library.</summary>
        public static string StripeNetVersion { get; }

        /// <summary>
        /// Sets information about the "app" which this integration belongs to. This should be
        /// reserved for plugins that wish to identify themselves with Stripe.
        /// </summary>
        public static AppInfo AppInfo
        {
            internal get => appInfo;

            set
            {
                if ((value != null) && string.IsNullOrEmpty(value.Name))
                {
                    throw new ArgumentException("AppInfo.Name cannot be empty");
                }

                if (value != appInfo)
                {
                    StripeClient = null;
                }

                appInfo = value;
            }
        }

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

        /// <summary>
        /// Sets the API key.
        /// This method is deprecated and will be removed in a future version, please use the
        /// <see cref="ApiKey"/> property setter instead.
        /// </summary>
        /// <param name="newApiKey">API key.</param>
        // TODO; remove this method in a future major version
        [Obsolete("Use StripeConfiguration.ApiKey setter instead.")]
        public static void SetApiKey(string newApiKey)
        {
            ApiKey = newApiKey;
        }

        private static StripeClient BuildDefaultStripeClient()
        {
            if (ApiKey != null && ApiKey.Length == 0)
            {
                var message = "Your API key is invalid, as it is an empty string. You can "
                    + "double-check your API key from the Stripe Dashboard. See "
                    + "https://stripe.com/docs/api/authentication for details or contact support "
                    + "at https://support.stripe.com/email if you have any questions.";
                throw new StripeException(message);
            }

            if (ApiKey != null && StringUtils.ContainsWhitespace(ApiKey))
            {
                var message = "Your API key is invalid, as it contains whitespace. You can "
                    + "double-check your API key from the Stripe Dashboard. See "
                    + "https://stripe.com/docs/api/authentication for details or contact support "
                    + "at https://support.stripe.com/email if you have any questions.";
                throw new StripeException(message);
            }

            var httpClient = new SystemNetHttpClient(
                httpClient: null,
                maxNetworkRetries: MaxNetworkRetries,
                appInfo: AppInfo,
                enableTelemetry: EnableTelemetry);
            return new StripeClient(ApiKey, ClientId, httpClient: httpClient);
        }
    }
}
