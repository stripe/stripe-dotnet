// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractTerms : StripeEntity<ContractTerms>
    {
        /// <summary>
        /// All terms in display order.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public List<ContractTerm> Data { get; set; }
    }
}
