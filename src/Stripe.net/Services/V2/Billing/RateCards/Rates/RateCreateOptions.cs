// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.RateCards
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RateCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The custom pricing unit that this rate binds to. One of <c>unit_amount</c>,
        /// <c>tiers</c>, or <c>custom_pricing_unit_amount</c> is required.
        /// </summary>
        [JsonProperty("custom_pricing_unit_amount")]
        [STJS.JsonPropertyName("custom_pricing_unit_amount")]
        public RateCreateCustomPricingUnitAmountOptions CustomPricingUnitAmount { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The Metered Item that this rate binds to.
        /// </summary>
        [JsonProperty("metered_item")]
        [STJS.JsonPropertyName("metered_item")]
        public string MeteredItem { get; set; }

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
        /// Each element represents a pricing tier. One of <c>unit_amount</c>, <c>tiers</c>, or
        /// <c>custom_pricing_unit_amount</c> is required.
        /// </summary>
        [JsonProperty("tiers")]
        [STJS.JsonPropertyName("tiers")]
        public List<RateCreateTierOptions> Tiers { get; set; }

        /// <summary>
        /// Apply a transformation to the reported usage or set quantity before computing the amount
        /// billed.
        /// </summary>
        [JsonProperty("transform_quantity")]
        [STJS.JsonPropertyName("transform_quantity")]
        public RateCreateTransformQuantityOptions TransformQuantity { get; set; }

        /// <summary>
        /// The per-unit amount to be charged, represented as a decimal string in minor currency
        /// units with at most 12 decimal places. One of <c>unit_amount</c>, <c>tiers</c>, or
        /// <c>custom_pricing_unit_amount</c> is required.
        /// </summary>
        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public string UnitAmount { get; set; }
    }
}
