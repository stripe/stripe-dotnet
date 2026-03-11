// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionCurrentAttemptPaymentMethodDetails : StripeEntity<SessionCurrentAttemptPaymentMethodDetails>
    {
        /// <summary>
        /// Indicates whether this payment method can be shown again to its customer in a checkout
        /// flow.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allow_redisplay")]
#endif
        public string AllowRedisplay { get; set; }

        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public SessionCurrentAttemptPaymentMethodDetailsCard Card { get; set; }

        /// <summary>
        /// The type of payment method the customer is attempting to pay with. An additional hash is
        /// included in the payment method details with a name matching this value. It contains
        /// additional information specific to the payment method type.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
