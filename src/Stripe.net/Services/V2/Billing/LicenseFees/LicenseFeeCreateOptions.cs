// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class LicenseFeeCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A customer-facing name for the License Fee. This name is used in Stripe-hosted products
        /// like the Customer Portal and Checkout. It does not show up on Invoices. Maximum length
        /// of 250 characters.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The Licensed Item that this License Fee binds to.
        /// </summary>
        [JsonProperty("licensed_item")]
        [STJS.JsonPropertyName("licensed_item")]
        public string LicensedItem { get; set; }

        /// <summary>
        /// An internal key you can use to search for a particular license fee. Maximum length of
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
        /// The interval for assessing service. For example, a monthly license fee with a rate of $1
        /// for the first 10 "workloads" and $2 thereafter means "$1 per workload up to 10 workloads
        /// during a month of service." This is similar to but distinct from billing interval; the
        /// service interval deals with the rate at which the customer accumulates fees, while the
        /// billing interval in Cadence deals with the rate the customer is billed.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("service_interval")]
        [STJS.JsonPropertyName("service_interval")]
        public string ServiceInterval { get; set; }

        /// <summary>
        /// The length of the interval for assessing service. For example, set this to 3 and
        /// <c>service_interval</c> to <c>"month"</c> in order to specify quarterly service.
        /// </summary>
        [JsonProperty("service_interval_count")]
        [STJS.JsonPropertyName("service_interval_count")]
        public long? ServiceIntervalCount { get; set; }

        /// <summary>
        /// The Stripe Tax tax behavior - whether the license fee is inclusive or exclusive of tax.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        [STJS.JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// Defines whether the tiered price should be graduated or volume-based. In volume-based
        /// tiering, the maximum quantity within a period determines the per-unit price. In
        /// graduated tiering, the pricing changes as the quantity grows into new tiers. Can only be
        /// set if <c>tiers</c> is set.
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
        public List<LicenseFeeCreateTierOptions> Tiers { get; set; }

        /// <summary>
        /// Apply a transformation to the reported usage or set quantity before computing the amount
        /// billed.
        /// </summary>
        [JsonProperty("transform_quantity")]
        [STJS.JsonPropertyName("transform_quantity")]
        public LicenseFeeCreateTransformQuantityOptions TransformQuantity { get; set; }

        /// <summary>
        /// The per-unit amount to be charged, represented as a decimal string in minor currency
        /// units with at most 12 decimal places. Cannot be set if <c>tiers</c> is provided.
        /// </summary>
        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public string UnitAmount { get; set; }
    }
}
