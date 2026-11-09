// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsPixOptions : INestedOptions
    {
        /// <summary>
        /// The number of seconds after PaymentIntent confirmation when the Pix expires (between 60
        /// and 1209600, inclusive). If unspecified, defaults to 14400 seconds (4 hours).
        /// </summary>
        [JsonProperty("expires_after_seconds")]
        [STJS.JsonPropertyName("expires_after_seconds")]
        public long? ExpiresAfterSeconds { get; set; }

        /// <summary>
        /// Configuration options for setting up a mandate.
        /// </summary>
        [JsonProperty("mandate_options")]
        [STJS.JsonPropertyName("mandate_options")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptionsOptions MandateOptions { get; set; }
    }
}
