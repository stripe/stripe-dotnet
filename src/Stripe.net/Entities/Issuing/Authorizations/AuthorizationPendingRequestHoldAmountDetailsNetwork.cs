// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationPendingRequestHoldAmountDetailsNetwork : StripeEntity<AuthorizationPendingRequestHoldAmountDetailsNetwork>
    {
        /// <summary>
        /// Three-letter ISO currency code.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The amount in the smallest currency unit.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public long Value { get; set; }
    }
}
