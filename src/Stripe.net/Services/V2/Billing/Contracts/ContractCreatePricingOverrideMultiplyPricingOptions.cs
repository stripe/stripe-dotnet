// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreatePricingOverrideMultiplyPricingOptions : INestedOptions
    {
        /// <summary>
        /// Criteria determining which rates the multiply_pricing override applies to.
        /// </summary>
        [JsonProperty("criteria")]
        [STJS.JsonPropertyName("criteria")]
        public List<ContractCreatePricingOverrideMultiplyPricingCriterionOptions> Criteria { get; set; }

        /// <summary>
        /// The multiply_pricing factor. e.g. "0.8" for a 20% reduction.
        /// </summary>
        [JsonProperty("factor")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("factor")]
        public decimal? Factor { get; set; }
    }
}
