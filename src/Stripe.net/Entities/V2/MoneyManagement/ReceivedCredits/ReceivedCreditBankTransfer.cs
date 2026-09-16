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
        /// Deprecated. Use <c>originating_bank_account.cpa</c> instead.
        /// </summary>
        [JsonProperty("ca_bank_account")]
        [STJS.JsonPropertyName("ca_bank_account")]
        public ReceivedCreditBankTransferCaBankAccount CaBankAccount { get; set; }

        /// <summary>
        /// Deprecated. Use <c>originating_bank_account.iban</c> instead.
        /// </summary>
        [JsonProperty("eu_bank_account")]
        [STJS.JsonPropertyName("eu_bank_account")]
        public ReceivedCreditBankTransferEuBankAccount EuBankAccount { get; set; }

        /// <summary>
        /// Financial Address on which funds for ReceivedCredit were received.
        /// </summary>
        [JsonProperty("financial_address")]
        [STJS.JsonPropertyName("financial_address")]
        public string FinancialAddress { get; set; }

        /// <summary>
        /// Deprecated. Use <c>originating_bank_account.sort_code</c> instead.
        /// </summary>
        [JsonProperty("gb_bank_account")]
        [STJS.JsonPropertyName("gb_bank_account")]
        public ReceivedCreditBankTransferGbBankAccount GbBankAccount { get; set; }

        /// <summary>
        /// Deprecated. Use <c>originating_bank_account.clabe</c> instead.
        /// </summary>
        [JsonProperty("mx_bank_account")]
        [STJS.JsonPropertyName("mx_bank_account")]
        public ReceivedCreditBankTransferMxBankAccount MxBankAccount { get; set; }

        /// <summary>
        /// Hash containing the originating bank account details and type for this bank transfer.
        /// </summary>
        [JsonProperty("originating_bank_account")]
        [STJS.JsonPropertyName("originating_bank_account")]
        public ReceivedCreditBankTransferOriginatingBankAccount OriginatingBankAccount { get; set; }

        /// <summary>
        /// Deprecated. Use <c>originating_bank_account.iban</c> instead.
        /// </summary>
        [JsonProperty("sepa_bank_account")]
        [STJS.JsonPropertyName("sepa_bank_account")]
        public ReceivedCreditBankTransferSepaBankAccount SepaBankAccount { get; set; }

        /// <summary>
        /// Freeform string set by originator of the external ReceivedCredit.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Deprecated. Use <c>originating_bank_account.aba</c> instead.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public ReceivedCreditBankTransferUsBankAccount UsBankAccount { get; set; }
    }
}
