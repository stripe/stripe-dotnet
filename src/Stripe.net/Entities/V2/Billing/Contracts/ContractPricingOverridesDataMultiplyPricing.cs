// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractPricingOverridesDataMultiplyPricing : StripeEntity<ContractPricingOverridesDataMultiplyPricing>
    {
        /// <summary>
        /// Criteria determining which rates the multiply_pricing override applies to.
        /// </summary>
        [JsonProperty("criteria")]
        [STJS.JsonPropertyName("criteria")]
        public List<ContractPricingOverridesDataMultiplyPricingCriterion> Criteria { get; set; }

        /// <summary>
        /// The multiply_pricing factor, represented as a decimal string. e.g. "0.8" for a 20%
        /// reduction.
        /// </summary>
        [JsonProperty("factor")]
        [STJS.JsonPropertyName("factor")]
        public string Factor { get; set; }
    }
}
