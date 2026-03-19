// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionCurrentAttemptPaymentMethodDetails : StripeEntity<SessionCurrentAttemptPaymentMethodDetails>
    {
        /// <summary>
        /// Indicates whether this payment method can be shown again to its customer in a checkout
        /// flow.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay")]
        [STJS.JsonPropertyName("allow_redisplay")]
        public string AllowRedisplay { get; set; }

        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public SessionCurrentAttemptPaymentMethodDetailsCard Card { get; set; }

        /// <summary>
        /// The type of payment method the customer is attempting to pay with. An additional hash is
        /// included in the payment method details with a name matching this value. It contains
        /// additional information specific to the payment method type.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
