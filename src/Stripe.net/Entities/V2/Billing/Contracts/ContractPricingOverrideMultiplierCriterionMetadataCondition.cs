// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractPricingOverrideMultiplierCriterionMetadataCondition : StripeEntity<ContractPricingOverrideMultiplierCriterionMetadataCondition>
    {
        /// <summary>
        /// All of these key-value conditions must match.
        /// </summary>
        [JsonProperty("all_of")]
        [STJS.JsonPropertyName("all_of")]
        public List<ContractPricingOverrideMultiplierCriterionMetadataConditionAllOf> AllOf { get; set; }
    }
}
