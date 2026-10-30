// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateActionAddTermPricingOverrideCriterionOptions : INestedOptions
    {
        /// <summary>
        /// Term selectors. Each ID or lookup key resolves to one fixed term ID. Omitted or empty
        /// selects all charge-bearing terms. Override terms cannot be targets.
        /// </summary>
        [JsonProperty("terms")]
        [STJS.JsonPropertyName("terms")]
        public List<ContractUpdateActionAddTermPricingOverrideCriterionTermOptions> Terms { get; set; }

        /// <summary>
        /// Whether to include or exclude the selected recurring or ad_hoc_product terms.
        /// One of: <c>exclude</c>, or <c>include</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
