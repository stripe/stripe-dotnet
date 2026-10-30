// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractTermPricingOverrideCriterion : StripeEntity<ContractTermPricingOverrideCriterion>
    {
        /// <summary>
        /// Resolved IDs of recurring or ad_hoc_product terms. Override terms are not valid targets.
        /// </summary>
        [JsonProperty("terms")]
        [STJS.JsonPropertyName("terms")]
        public List<string> Terms { get; set; }

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
