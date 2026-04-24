// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A License Fee represents a versioned recurring charge for a Licensed Item, typically
    /// used for seat-based or quantity-based pricing. Each License Fee defines the pricing
    /// structure (flat unit amount or tiered pricing) and service interval. After creating a
    /// License Fee, you can subscribe customers to it by creating a License Fee Subscription.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class LicenseFee : StripeEntity<LicenseFee>, IHasId, IHasMetadata, IHasObject
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
        /// Whether this License Fee is active. Inactive License Fees cannot be used in new
        /// activations or be modified.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A customer-facing name for the license fee. This name is used in Stripe-hosted products
        /// like the Customer Portal and Checkout. It does not show up on Invoices. Maximum length
        /// of 250 characters.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The ID of the license fee's most recently created version.
        /// </summary>
        [JsonProperty("latest_version")]
        [STJS.JsonPropertyName("latest_version")]
        public string LatestVersion { get; set; }

        /// <summary>
        /// A Licensed Item represents a billable item whose pricing is based on license fees. You
        /// can use license fees to specify the pricing and create subscriptions to these items.
        /// </summary>
        [JsonProperty("licensed_item")]
        [STJS.JsonPropertyName("licensed_item")]
        public LicensedItem LicensedItem { get; set; }

        /// <summary>
        /// The ID of the License Fee Version used by all subscriptions when no specific version is
        /// specified.
        /// </summary>
        [JsonProperty("live_version")]
        [STJS.JsonPropertyName("live_version")]
        public string LiveVersion { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// An internal key you can use to search for a particular License Fee. Maximum length of
        /// 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The service cycle configuration for this License Fee.
        /// </summary>
        [JsonProperty("service_cycle")]
        [STJS.JsonPropertyName("service_cycle")]
        public LicenseFeeServiceCycle ServiceCycle { get; set; }

        /// <summary>
        /// The interval for assessing service.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("service_interval")]
        [STJS.JsonPropertyName("service_interval")]
        public string ServiceInterval { get; set; }

        /// <summary>
        /// The length of the interval for assessing service. For example, set this to 3 and
        /// <c>service_interval</c> to <c>"month"</c> to specify quarterly service.
        /// </summary>
        [JsonProperty("service_interval_count")]
        [STJS.JsonPropertyName("service_interval_count")]
        public long ServiceIntervalCount { get; set; }

        /// <summary>
        /// The tax behavior for Stripe Tax — whether the license fee price includes or excludes
        /// tax.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }

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
        public List<LicenseFeeTier> Tiers { get; set; }

        /// <summary>
        /// Apply a transformation to the reported usage or set quantity before computing the amount
        /// billed.
        /// </summary>
        [JsonProperty("transform_quantity")]
        [STJS.JsonPropertyName("transform_quantity")]
        public LicenseFeeTransformQuantity TransformQuantity { get; set; }

        /// <summary>
        /// The per-unit amount to be charged, represented as a decimal string in minor currency
        /// units with at most 12 decimal places. Cannot be set if <c>tiers</c> is provided.
        /// </summary>
        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public string UnitAmount { get; set; }
    }
}
