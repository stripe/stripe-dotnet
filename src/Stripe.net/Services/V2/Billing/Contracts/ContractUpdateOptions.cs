// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Additional fields to include in the response.
        /// One of: <c>contract_line_details</c>, <c>license_quantities</c>, <c>one_time_fees</c>,
        /// <c>pricing_lines</c>, or <c>pricing_overrides</c>.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// Schema-only: License quantity actions (implementation to follow).
        /// </summary>
        [JsonProperty("license_quantity_actions")]
        [STJS.JsonPropertyName("license_quantity_actions")]
        public List<ContractUpdateLicenseQuantityActionOptions> LicenseQuantityActions { get; set; }

        /// <summary>
        /// Pricing line actions to apply.
        /// </summary>
        [JsonProperty("pricing_line_actions")]
        [STJS.JsonPropertyName("pricing_line_actions")]
        public List<ContractUpdatePricingLineActionOptions> PricingLineActions { get; set; }

        /// <summary>
        /// Pricing override actions to apply.
        /// </summary>
        [JsonProperty("pricing_override_actions")]
        [STJS.JsonPropertyName("pricing_override_actions")]
        public List<ContractUpdatePricingOverrideActionOptions> PricingOverrideActions { get; set; }
    }
}
