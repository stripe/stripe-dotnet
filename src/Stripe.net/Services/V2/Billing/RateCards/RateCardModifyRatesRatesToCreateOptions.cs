// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RateCardModifyRatesRatesToCreateOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The Metered Item that this rate binds to. Cannot be set if <c>metered_item_data</c> is
        /// provided, and must be set if it isn't.
        /// </summary>
        [JsonProperty("metered_item")]
        [STJS.JsonPropertyName("metered_item")]
        public string MeteredItem { get; set; }

        /// <summary>
        /// The data to create a metered item that binds to this rate. Cannot be set if
        /// <c>metered_item</c> is provided, and must be set if it isn't.
        /// </summary>
        [JsonProperty("metered_item_data")]
        [STJS.JsonPropertyName("metered_item_data")]
        public RateCardModifyRatesRatesToCreateMeteredItemDataOptions MeteredItemData { get; set; }

        /// <summary>
        /// Defines whether the tiered price is graduated or volume-based. In volume-based tiering,
        /// the maximum quantity within a period determines the per-unit price. In graduated
        /// tiering, the pricing changes as the quantity grows into new tiers. Can only be set if
        /// <c>tiers</c> is set.
        /// One of: <c>graduated</c>, or <c>volume</c>.
        /// </summary>
        [JsonProperty("tiering_mode")]
        [STJS.JsonPropertyName("tiering_mode")]
        public string TieringMode { get; set; }

        /// <summary>
        /// Each element represents a pricing tier. Cannot be set if <c>unit_amount</c> is provided.
        /// </summary>
        [JsonProperty("tiers")]
        [STJS.JsonPropertyName("tiers")]
        public List<RateCardModifyRatesRatesToCreateTierOptions> Tiers { get; set; }

        /// <summary>
        /// Apply a transformation to the reported usage or set quantity before computing the amount
        /// billed.
        /// </summary>
        [JsonProperty("transform_quantity")]
        [STJS.JsonPropertyName("transform_quantity")]
        public RateCardModifyRatesRatesToCreateTransformQuantityOptions TransformQuantity { get; set; }

        /// <summary>
        /// The per-unit amount to be charged, represented as a decimal string in minor currency
        /// units with at most 12 decimal places. Cannot be set if <c>tiers</c> is provided.
        /// </summary>
        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public string UnitAmount { get; set; }
    }
}
