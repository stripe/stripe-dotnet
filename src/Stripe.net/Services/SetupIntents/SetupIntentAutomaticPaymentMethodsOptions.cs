// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentAutomaticPaymentMethodsOptions : INestedOptions
    {
        /// <summary>
        /// Controls whether this SetupIntent will accept redirect-based payment methods.
        ///
        /// Redirect-based payment methods may require your customer to be redirected to a payment
        /// method's app or site for authentication or additional steps. To <a
        /// href="https://stripe.com/docs/api/setup_intents/confirm">confirm</a> this SetupIntent,
        /// you may be required to provide a <c>return_url</c> to redirect customers back to your
        /// site after they authenticate or complete the setup.
        /// One of: <c>always</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("allow_redirects")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allow_redirects")]
#endif
        public string AllowRedirects { get; set; }

        /// <summary>
        /// Whether this feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool? Enabled { get; set; }
    }
}
