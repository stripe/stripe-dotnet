// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionItemMetronomeCommitCommitCommitOptionsDiscountTierOptions : INestedOptions
    {
        /// <summary>
        /// Percentage discount applied to the full access_amount when it falls in this tier.
        /// </summary>
        [JsonProperty("discount_percentage")]
        [STJS.JsonPropertyName("discount_percentage")]
        public long? DiscountPercentage { get; set; }

        /// <summary>
        /// Upper bound (inclusive) in credit_type_id units. Use <c>inf</c> to define an unbounded
        /// tier.
        /// </summary>
        [JsonProperty("up_to")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("up_to")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<long?, SessionItemMetronomeCommitCommitCommitOptionsDiscountTierUpTo> UpTo { get; set; }
    }
}
