// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionItemMetronomeCommitCommitCommitOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Optionally let the buyer enter a custom access amount.
        /// </summary>
        [JsonProperty("custom_amount")]
        [STJS.JsonPropertyName("custom_amount")]
        public SessionItemMetronomeCommitCommitCommitOptionsCustomAmountOptions CustomAmount { get; set; }

        /// <summary>
        /// Volume-based discount tiers.
        /// </summary>
        [JsonProperty("discount_tiers")]
        [STJS.JsonPropertyName("discount_tiers")]
        public List<SessionItemMetronomeCommitCommitCommitOptionsDiscountTierOptions> DiscountTiers { get; set; }

        /// <summary>
        /// When access for the purchased credits ends. Hour-aligned UTC timestamp.
        /// </summary>
        [JsonProperty("ending_before")]
        [STJS.JsonPropertyName("ending_before")]
        public string EndingBefore { get; set; }

        /// <summary>
        /// Access-amount presets for the buyer to choose from.
        /// </summary>
        [JsonProperty("options")]
        [STJS.JsonPropertyName("options")]
        public List<SessionItemMetronomeCommitCommitCommitOptionsOptionOptions> Options { get; set; }

        /// <summary>
        /// When access for the purchased credits starts. Hour-aligned UTC timestamp.
        /// </summary>
        [JsonProperty("starting_at")]
        [STJS.JsonPropertyName("starting_at")]
        public string StartingAt { get; set; }
    }
}
