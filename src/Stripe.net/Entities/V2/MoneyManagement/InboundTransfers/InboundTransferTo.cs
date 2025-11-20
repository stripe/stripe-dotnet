// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InboundTransferTo : StripeEntity<InboundTransferTo>
    {
        /// <summary>
        /// The amount by which the FinancialAccount balance is credited.
        /// </summary>
        [JsonProperty("credited")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credited")]
#endif
        public InboundTransferToCredited Credited { get; set; }

        /// <summary>
        /// The FinancialAccount that funds will land in.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }
    }
}
