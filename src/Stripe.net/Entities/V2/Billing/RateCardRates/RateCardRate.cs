// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Rate Card Rate represents a single usage-based price within a Rate Card. Each rate
    /// binds to one Metered Item and defines the pricing structure for that item, including
    /// either a flat unit amount or tiered pricing. Rates support features like graduated or
    /// volume-based tiering, quantity transformations, and custom pricing units.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RateCardRate : StripeEntity<RateCardRate>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The custom pricing unit that this rate binds to.
        /// </summary>
        [JsonProperty("custom_pricing_unit_amount")]
        [STJS.JsonPropertyName("custom_pricing_unit_amount")]
        public RateCardRateCustomPricingUnitAmount CustomPricingUnitAmount { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A Metered Item represents a billable item whose pricing is based on usage, measured by a
        /// meter. You can use rate cards to specify the pricing and create subscriptions to these
        /// items.
        /// </summary>
        [JsonProperty("metered_item")]
        [STJS.JsonPropertyName("metered_item")]
        public MeteredItem MeteredItem { get; set; }

        /// <summary>
        /// The ID of the Rate Card it belongs to.
        /// </summary>
        [JsonProperty("rate_card")]
        [STJS.JsonPropertyName("rate_card")]
        public string RateCard { get; set; }

        /// <summary>
        /// The ID of the Rate Card Version it was created on.
        /// </summary>
        [JsonProperty("rate_card_version")]
        [STJS.JsonPropertyName("rate_card_version")]
        public string RateCardVersion { get; set; }

        /// <summary>
        /// Defines whether the tiering price is graduated or volume-based. In volume-based tiering,
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
        public List<RateCardRateTier> Tiers { get; set; }

        /// <summary>
        /// Apply a transformation to the reported usage or set quantity before computing the amount
        /// billed.
        /// </summary>
        [JsonProperty("transform_quantity")]
        [STJS.JsonPropertyName("transform_quantity")]
        public RateCardRateTransformQuantity TransformQuantity { get; set; }

        /// <summary>
        /// The per-unit amount to be charged, represented as a decimal string in minor currency
        /// units with at most 12 decimal places. Cannot be set if <c>tiers</c> is provided.
        /// </summary>
        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public string UnitAmount { get; set; }
    }
}
