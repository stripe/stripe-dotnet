// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundFundingHistoryCheckReturned : StripeEntity<InboundFundingHistoryCheckReturned>
    {
        /// <summary>
        /// The raw banking-partner return code, when available.
        /// </summary>
        [JsonProperty("return_code")]
        [STJS.JsonPropertyName("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// The reason the check was returned.
        /// </summary>
        [JsonProperty("return_reason")]
        [STJS.JsonPropertyName("return_reason")]
        public string ReturnReason { get; set; }

        /// <summary>
        /// The ID of the reversal Transaction.
        /// </summary>
        [JsonProperty("reversal_transaction")]
        [STJS.JsonPropertyName("reversal_transaction")]
        public string ReversalTransaction { get; set; }
    }
}
