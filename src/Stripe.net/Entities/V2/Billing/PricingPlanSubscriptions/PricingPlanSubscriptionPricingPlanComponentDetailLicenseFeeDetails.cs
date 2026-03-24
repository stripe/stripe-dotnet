// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanSubscriptionPricingPlanComponentDetailLicenseFeeDetails : StripeEntity<PricingPlanSubscriptionPricingPlanComponentDetailLicenseFeeDetails>
    {
        /// <summary>
        /// Three-letter ISO currency code, in lowercase.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A customer-facing name for the license fee.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The ID of the License Fee.
        /// </summary>
        [JsonProperty("license_fee")]
        [STJS.JsonPropertyName("license_fee")]
        public string LicenseFee { get; set; }

        /// <summary>
        /// The ID of the License Fee Version.
        /// </summary>
        [JsonProperty("license_fee_version")]
        [STJS.JsonPropertyName("license_fee_version")]
        public string LicenseFeeVersion { get; set; }

        /// <summary>
        /// Quantity of the license fee on the subscription.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// The service cycle configuration.
        /// </summary>
        [JsonProperty("service_cycle")]
        [STJS.JsonPropertyName("service_cycle")]
        public PricingPlanSubscriptionPricingPlanComponentDetailLicenseFeeDetailsServiceCycle ServiceCycle { get; set; }

        /// <summary>
        /// Defines whether the tiering price should be graduated or volume-based.
        /// One of: <c>graduated</c>, or <c>volume</c>.
        /// </summary>
        [JsonProperty("tiering_mode")]
        [STJS.JsonPropertyName("tiering_mode")]
        public string TieringMode { get; set; }

        /// <summary>
        /// Each element represents a pricing tier.
        /// </summary>
        [JsonProperty("tiers")]
        [STJS.JsonPropertyName("tiers")]
        public List<PricingPlanSubscriptionPricingPlanComponentDetailLicenseFeeDetailsTier> Tiers { get; set; }

        /// <summary>
        /// Apply a transformation to the reported usage or set quantity before computing the amount
        /// billed.
        /// </summary>
        [JsonProperty("transform_quantity")]
        [STJS.JsonPropertyName("transform_quantity")]
        public PricingPlanSubscriptionPricingPlanComponentDetailLicenseFeeDetailsTransformQuantity TransformQuantity { get; set; }

        /// <summary>
        /// The per-unit amount to be charged, represented as a decimal string in minor currency
        /// units with at most 12 decimal places.
        /// </summary>
        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public string UnitAmount { get; set; }

        /// <summary>
        /// The unit label from the licensed item, used for display purposes (e.g. "seat",
        /// "environment").
        /// </summary>
        [JsonProperty("unit_label")]
        [STJS.JsonPropertyName("unit_label")]
        public string UnitLabel { get; set; }
    }
}
