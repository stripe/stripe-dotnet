// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractPricingLines : StripeEntity<ContractPricingLines>
    {
        /// <summary>
        /// The pricing lines for this page.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public List<ContractPricingLinesData> Data { get; set; }
    }
}
