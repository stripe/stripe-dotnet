// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractPricingOverrideMultiplierCriterion : StripeEntity<ContractPricingOverrideMultiplierCriterion>
    {
        /// <summary>
        /// Filter by billable item IDs.
        /// </summary>
        [JsonProperty("billable_item_ids")]
        [STJS.JsonPropertyName("billable_item_ids")]
        public List<string> BillableItemIds { get; set; }

        /// <summary>
        /// Filter by billable item lookup keys.
        /// </summary>
        [JsonProperty("billable_item_lookup_keys")]
        [STJS.JsonPropertyName("billable_item_lookup_keys")]
        public List<string> BillableItemLookupKeys { get; set; }

        /// <summary>
        /// Filter by billable item type.
        /// One of: <c>licensed</c>, or <c>metered</c>.
        /// </summary>
        [JsonProperty("billable_item_types")]
        [STJS.JsonPropertyName("billable_item_types")]
        public List<string> BillableItemTypes { get; set; }

        /// <summary>
        /// Filter by metadata conditions.
        /// </summary>
        [JsonProperty("metadata_conditions")]
        [STJS.JsonPropertyName("metadata_conditions")]
        public List<ContractPricingOverrideMultiplierCriterionMetadataCondition> MetadataConditions { get; set; }

        /// <summary>
        /// Filter by rate card IDs. Only applicable for <c>multiplier</c> overrides.
        /// </summary>
        [JsonProperty("rate_card_ids")]
        [STJS.JsonPropertyName("rate_card_ids")]
        public List<string> RateCardIds { get; set; }

        /// <summary>
        /// Whether to include or exclude items matching these criteria.
        /// One of: <c>exclude</c>, or <c>include</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
