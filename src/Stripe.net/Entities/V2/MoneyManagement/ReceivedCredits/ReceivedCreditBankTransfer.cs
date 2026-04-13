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
        /// Hash containing the transaction bank details. Present if <c>origin_type</c> field value
        /// is <c>gb_bank_account</c>.
        /// </summary>
        [JsonProperty("gb_bank_account")]
        [STJS.JsonPropertyName("gb_bank_account")]
        public ReceivedCreditBankTransferGbBankAccount GbBankAccount { get; set; }

        /// <summary>
        /// Open Enum. Indicates the origin of source from which external funds originated from.
        /// One of: <c>gb_bank_account</c>, <c>sepa_bank_account</c>, or <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("origin_type")]
        [STJS.JsonPropertyName("origin_type")]
        public string OriginType { get; set; }

        /// <summary>
        /// Hash containing the transaction bank details. Present if <c>origin_type</c> field value
        /// is <c>sepa_bank_account</c>.
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
        /// Hash containing the transaction bank details. Present if <c>origin_type</c> field value
        /// is <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public ReceivedCreditBankTransferUsBankAccount UsBankAccount { get; set; }
    }
}
