// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractPricingLinesDataPricingPriceDetailsPricingOverridesData : StripeEntity<ContractPricingLinesDataPricingPriceDetailsPricingOverridesData>
    {
        /// <summary>
        /// Resolved timestamp when this override ends.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractPricingLinesDataPricingPriceDetailsPricingOverridesDataEndsAt EndsAt { get; set; }

        /// <summary>
        /// The user-provided lookup key for this override.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Details for an overwrite_price override.
        /// </summary>
        [JsonProperty("overwrite_price")]
        [STJS.JsonPropertyName("overwrite_price")]
        public ContractPricingLinesDataPricingPriceDetailsPricingOverridesDataOverwritePrice OverwritePrice { get; set; }

        /// <summary>
        /// The ID of the pricing line override.
        /// </summary>
        [JsonProperty("pricing_override")]
        [STJS.JsonPropertyName("pricing_override")]
        public string PricingOverride { get; set; }

        /// <summary>
        /// Resolved timestamp when this override starts.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractPricingLinesDataPricingPriceDetailsPricingOverridesDataStartsAt StartsAt { get; set; }

        /// <summary>
        /// The type of override.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
