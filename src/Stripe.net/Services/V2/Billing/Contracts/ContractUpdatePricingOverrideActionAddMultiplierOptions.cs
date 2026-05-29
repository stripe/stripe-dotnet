// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdatePricingOverrideActionAddMultiplierOptions : INestedOptions
    {
        /// <summary>
        /// Criteria determining which rates the multiplier applies to.
        /// </summary>
        [JsonProperty("criteria")]
        [STJS.JsonPropertyName("criteria")]
        public List<ContractUpdatePricingOverrideActionAddMultiplierCriterionOptions> Criteria { get; set; }

        /// <summary>
        /// The multiplier factor, represented as a decimal string. e.g. "0.8" for a 20% reduction.
        /// </summary>
        [JsonProperty("factor")]
        [STJS.JsonPropertyName("factor")]
        public string Factor { get; set; }
    }
}
