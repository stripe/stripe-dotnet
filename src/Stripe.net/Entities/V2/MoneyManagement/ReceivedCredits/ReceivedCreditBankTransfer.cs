// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditBankTransfer : StripeEntity<ReceivedCreditBankTransfer>
    {
        /// <summary>
        /// Financial Address on which funds for ReceivedCredit were received.
        /// </summary>
        [JsonProperty("financial_address")]
        [STJS.JsonPropertyName("financial_address")]
        public string FinancialAddress { get; set; }

        /// <summary>
        /// The money transmission network used to send funds for this ReceivedCredit.
        /// One of: <c>ach</c>, <c>acss</c>, <c>bre_b</c>, <c>chaps</c>, <c>fedwire</c>, <c>fps</c>,
        /// <c>nip</c>, <c>pix</c>, <c>rtp</c>, <c>sepa</c>, <c>sepa_instant</c>, <c>spei</c>, or
        /// <c>swift</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// Network-level detail for the transfer that created this ReceivedCredit. Present only for
        /// ACH.
        /// </summary>
        [JsonProperty("network_details")]
        [STJS.JsonPropertyName("network_details")]
        public ReceivedCreditBankTransferNetworkDetails NetworkDetails { get; set; }

        /// <summary>
        /// Hash containing the originating bank account details and type for this bank transfer.
        /// </summary>
        [JsonProperty("originating_bank_account")]
        [STJS.JsonPropertyName("originating_bank_account")]
        public ReceivedCreditBankTransferOriginatingBankAccount OriginatingBankAccount { get; set; }

        /// <summary>
        /// Freeform string set by originator of the external ReceivedCredit.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
