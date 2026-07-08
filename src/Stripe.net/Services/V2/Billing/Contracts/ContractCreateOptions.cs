// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The billing cycle anchor for the contract. If not provided, defaults to the pricing line
        /// start time. It is only at the top-level of the contract with no option to override at
        /// the pricing line level.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [STJS.JsonPropertyName("billing_cycle_anchor")]
        public ContractCreateBillingCycleAnchorOptions BillingCycleAnchor { get; set; }

        /// <summary>
        /// The billing settings for the contract.
        /// </summary>
        [JsonProperty("billing_settings")]
        [STJS.JsonPropertyName("billing_settings")]
        public ContractCreateBillingSettingsOptions BillingSettings { get; set; }

        /// <summary>
        /// A unique user-provided contract number e.g. C-2026-0001.
        /// </summary>
        [JsonProperty("contract_number")]
        [STJS.JsonPropertyName("contract_number")]
        public string ContractNumber { get; set; }

        /// <summary>
        /// Currency of the contract.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Additional fields to include in the response.
        /// One of: <c>billing_settings</c>, <c>pricing_lines</c>, or <c>pricing_overrides</c>.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A list of pricing lines to create with the contract.
        /// </summary>
        [JsonProperty("pricing_lines")]
        [STJS.JsonPropertyName("pricing_lines")]
        public List<ContractCreatePricingLineOptions> PricingLines { get; set; }

        /// <summary>
        /// A list of pricing overrides to create with the contract.
        /// </summary>
        [JsonProperty("pricing_overrides")]
        [STJS.JsonPropertyName("pricing_overrides")]
        public List<ContractCreatePricingOverrideOptions> PricingOverrides { get; set; }
    }
}
