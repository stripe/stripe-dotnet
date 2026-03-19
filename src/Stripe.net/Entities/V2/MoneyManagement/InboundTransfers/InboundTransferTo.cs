// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferTo : StripeEntity<InboundTransferTo>
    {
        /// <summary>
        /// The amount by which the FinancialAccount balance is credited.
        /// </summary>
        [JsonProperty("credited")]
        [STJS.JsonPropertyName("credited")]
        public V2.Amount Credited { get; set; }

        /// <summary>
        /// The FinancialAccount that funds will land in.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }
    }
}
