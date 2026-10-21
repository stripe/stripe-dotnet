// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionItemMetronomeCommitCommitCommitOptionsDiscountTier : StripeEntity<SessionItemMetronomeCommitCommitCommitOptionsDiscountTier>
    {
        /// <summary>
        /// Percentage discount applied to the full access_amount.
        /// </summary>
        [JsonProperty("discount_percentage")]
        [STJS.JsonPropertyName("discount_percentage")]
        public long DiscountPercentage { get; set; }

        /// <summary>
        /// Upper bound (inclusive) in credit_type_id units. Null means unbounded.
        /// </summary>
        [JsonProperty("up_to")]
        [STJS.JsonPropertyName("up_to")]
        public long? UpTo { get; set; }
    }
}
