// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A License Fee Version represents a specific configuration of a License Fee at a point in
    /// time. Versions are created automatically when you update the pricing structure of a
    /// License Fee, allowing you to track changes and manage which version is active for new
    /// subscriptions. Each version maintains the pricing details including unit amounts and
    /// tiers.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class LicenseFeeVersion : StripeEntity<LicenseFeeVersion>, IHasId, IHasObject
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
        /// The ID of the parent License Fee.
        /// </summary>
        [JsonProperty("license_fee_id")]
        [STJS.JsonPropertyName("license_fee_id")]
        public string LicenseFeeId { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

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
        public List<LicenseFeeVersionTier> Tiers { get; set; }

        /// <summary>
        /// Apply a transformation to the reported usage or set quantity before computing the amount
        /// billed.
        /// </summary>
        [JsonProperty("transform_quantity")]
        [STJS.JsonPropertyName("transform_quantity")]
        public LicenseFeeVersionTransformQuantity TransformQuantity { get; set; }

        /// <summary>
        /// The per-unit amount to be charged, represented as a decimal string in minor currency
        /// units with at most 12 decimal places. Cannot be set if <c>tiers</c> is provided.
        /// </summary>
        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public string UnitAmount { get; set; }
    }
}
