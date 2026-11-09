// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsPix : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsPix>
    {
        /// <summary>
        /// The number of seconds after PaymentIntent confirmation when the Pix expires (between 60
        /// and 1209600, inclusive). If unspecified, defaults to 14400 seconds (4 hours).
        /// </summary>
        [JsonProperty("expires_after_seconds")]
        [STJS.JsonPropertyName("expires_after_seconds")]
        public long ExpiresAfterSeconds { get; set; }

        [JsonProperty("mandate_options")]
        [STJS.JsonPropertyName("mandate_options")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptions MandateOptions { get; set; }
    }
}
