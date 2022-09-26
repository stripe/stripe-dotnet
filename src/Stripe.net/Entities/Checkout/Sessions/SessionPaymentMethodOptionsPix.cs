// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsPix : StripeEntity<SessionPaymentMethodOptionsPix>
    {
        /// <summary>
        /// The number of seconds after which Pix payment will expire.
        /// </summary>
        [JsonProperty("expires_after_seconds")]
        public long? ExpiresAfterSeconds { get; set; }
    }
}
