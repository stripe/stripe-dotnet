// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionItemMetronomeCommitCommitCommitOptions : StripeEntity<SessionItemMetronomeCommitCommitCommitOptions>
    {
        /// <summary>
        /// Custom access amount configuration.
        /// </summary>
        [JsonProperty("custom_amount")]
        [STJS.JsonPropertyName("custom_amount")]
        public SessionItemMetronomeCommitCommitCommitOptionsCustomAmount CustomAmount { get; set; }

        /// <summary>
        /// Volume-based discount tiers.
        /// </summary>
        [JsonProperty("discount_tiers")]
        [STJS.JsonPropertyName("discount_tiers")]
        public List<SessionItemMetronomeCommitCommitCommitOptionsDiscountTier> DiscountTiers { get; set; }

        /// <summary>
        /// When access for the purchased credits ends.
        /// </summary>
        [JsonProperty("ending_before")]
        [STJS.JsonPropertyName("ending_before")]
        public string EndingBefore { get; set; }

        /// <summary>
        /// Access-amount presets for the buyer to choose from.
        /// </summary>
        [JsonProperty("options")]
        [STJS.JsonPropertyName("options")]
        public List<SessionItemMetronomeCommitCommitCommitOptionsOption> Options { get; set; }

        /// <summary>
        /// The selected access amount. It matches an <c>options[].access_amount</c> for a preset
        /// selection, but may be a custom value when <c>custom_amount</c> is enabled. New sessions
        /// initialize it from the option marked <c>default_option</c>, or from the first option
        /// when none is marked. It is not necessarily the item's monetary price; use
        /// <c>amount_details</c> for display and totals.
        /// </summary>
        [JsonProperty("selected_access_amount")]
        [STJS.JsonPropertyName("selected_access_amount")]
        public long? SelectedAccessAmount { get; set; }

        /// <summary>
        /// When access for the purchased credits starts.
        /// </summary>
        [JsonProperty("starting_at")]
        [STJS.JsonPropertyName("starting_at")]
        public string StartingAt { get; set; }
    }
}
