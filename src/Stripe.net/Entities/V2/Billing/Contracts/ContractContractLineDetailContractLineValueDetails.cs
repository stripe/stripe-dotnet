// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractContractLineDetailContractLineValueDetails : StripeEntity<ContractContractLineDetailContractLineValueDetails>
    {
        /// <summary>
        /// Computed sum of all licensed fees. Represented as a decimal string in minor currency
        /// units.
        /// </summary>
        [JsonProperty("total")]
        [STJS.JsonPropertyName("total")]
        public string Total { get; set; }
    }
}
