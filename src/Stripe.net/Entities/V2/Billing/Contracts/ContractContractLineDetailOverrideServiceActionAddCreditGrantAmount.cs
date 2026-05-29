// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractContractLineDetailOverrideServiceActionAddCreditGrantAmount : StripeEntity<ContractContractLineDetailOverrideServiceActionAddCreditGrantAmount>
    {
        /// <summary>
        /// The monetary amount of the credit grant. Required if <c>type</c> is <c>monetary</c>.
        /// </summary>
        [JsonProperty("monetary")]
        [STJS.JsonPropertyName("monetary")]
        public V2.Amount Monetary { get; set; }

        /// <summary>
        /// The type of the credit grant amount.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
