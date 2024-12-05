// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionPaymentMethodOptionsPix : StripeEntity<SessionPaymentMethodOptionsPix>
    {
        /// <summary>
        /// The number of seconds after which Pix payment will expire.
        /// </summary>
        [JsonProperty("expires_after_seconds")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_after_seconds")]
#endif
        public long? ExpiresAfterSeconds { get; set; }
    }
}
