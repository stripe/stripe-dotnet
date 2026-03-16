// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundTransferFrom : StripeEntity<OutboundTransferFrom>
    {
        /// <summary>
        /// The monetary amount debited from the sender, only set on responses.
        /// </summary>
        [JsonProperty("debited")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("debited")]
#endif
        public OutboundTransferFromDebited Debited { get; set; }

        /// <summary>
        /// The FinancialAccount that funds were pulled from.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }
    }
}
