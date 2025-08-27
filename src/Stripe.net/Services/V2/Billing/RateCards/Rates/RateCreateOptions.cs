// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.RateCards
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RateCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The custom pricing unit that this rate binds to.
        /// </summary>
        [JsonProperty("custom_pricing_unit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit_amount")]
#endif
        public RateCreateCustomPricingUnitAmountOptions CustomPricingUnitAmount { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The Metered Item that this rate binds to.
        /// </summary>
        [JsonProperty("metered_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metered_item")]
#endif
        public string MeteredItem { get; set; }

        /// <summary>
        /// The ID of the price object to take price information from. The price must have the same
        /// interval as the rate card. Updates to the Price will not be reflected in the Rate Card
        /// or its rates.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public string Price { get; set; }

        /// <summary>
        /// Defines whether the tiered price should be graduated or volume-based. In volume-based
        /// tiering, the maximum quantity within a period determines the per-unit price. In
        /// graduated tiering, the pricing changes as the quantity grows into new tiers. Can only be
        /// set if <c>tiers</c> is set.
        /// One of: <c>graduated</c>, or <c>volume</c>.
        /// </summary>
        [JsonProperty("tiering_mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tiering_mode")]
#endif
        public string TieringMode { get; set; }

        /// <summary>
        /// Each element represents a pricing tier. Cannot be set if <c>unit_amount</c> is provided.
        /// </summary>
        [JsonProperty("tiers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tiers")]
#endif
        public List<RateCreateTierOptions> Tiers { get; set; }

        /// <summary>
        /// Apply a transformation to the reported usage or set quantity before computing the amount
        /// billed.
        /// </summary>
        [JsonProperty("transform_quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transform_quantity")]
#endif
        public RateCreateTransformQuantityOptions TransformQuantity { get; set; }

        /// <summary>
        /// The per-unit amount to be charged, represented as a decimal string in minor currency
        /// units with at most 12 decimal places. Cannot be set if <c>tiers</c> is provided.
        /// </summary>
        [JsonProperty("unit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount")]
#endif
        public string UnitAmount { get; set; }
    }
}
