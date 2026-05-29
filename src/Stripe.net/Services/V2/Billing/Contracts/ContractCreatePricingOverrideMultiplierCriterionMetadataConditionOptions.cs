// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreatePricingOverrideMultiplierCriterionMetadataConditionOptions : INestedOptions
    {
        /// <summary>
        /// All of these key-value conditions must match.
        /// </summary>
        [JsonProperty("all_of")]
        [STJS.JsonPropertyName("all_of")]
        public List<ContractCreatePricingOverrideMultiplierCriterionMetadataConditionAllOfOptions> AllOf { get; set; }
    }
}
