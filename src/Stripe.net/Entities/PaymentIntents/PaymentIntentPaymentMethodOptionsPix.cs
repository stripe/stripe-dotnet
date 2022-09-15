// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsPix : StripeEntity<PaymentIntentPaymentMethodOptionsPix>
    {
        /// <summary>
        /// The number of seconds (between 10 and 1209600) after which Pix payment will expire.
        /// </summary>
        [JsonProperty("expires_after_seconds")]
        public long? ExpiresAfterSeconds { get; set; }

        /// <summary>
        /// The timestamp at which the Pix expires.
        /// </summary>
        [JsonProperty("expires_at")]
        public long? ExpiresAt { get; set; }
    }
}
