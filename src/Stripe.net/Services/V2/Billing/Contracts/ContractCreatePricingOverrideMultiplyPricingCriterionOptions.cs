// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreatePricingOverrideMultiplyPricingCriterionOptions : INestedOptions
    {
        /// <summary>
        /// Filter by pricing line IDs.
        /// </summary>
        [JsonProperty("pricing_line_ids")]
        [STJS.JsonPropertyName("pricing_line_ids")]
        public List<string> PricingLineIds { get; set; }

        /// <summary>
        /// Filter by pricing line lookup keys.
        /// </summary>
        [JsonProperty("pricing_line_lookup_keys")]
        [STJS.JsonPropertyName("pricing_line_lookup_keys")]
        public List<string> PricingLineLookupKeys { get; set; }

        /// <summary>
        /// Whether to include or exclude items matching these criteria.
        /// One of: <c>exclude</c>, or <c>include</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
