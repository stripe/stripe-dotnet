// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditBankTransfer : StripeEntity<ReceivedCreditBankTransfer>
    {
        /// <summary>
        /// Financial Address on which funds for ReceivedCredit were received.
        /// </summary>
        [JsonProperty("financial_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_address")]
#endif
        public string FinancialAddress { get; set; }

        /// <summary>
        /// Open Enum. Indicates the type of source via from which external funds originated.
        /// One of: <c>gb_bank_account</c>, or <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("payment_method_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_type")]
#endif
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// Freeform string set by originator of the external ReceivedCredit.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Hash containing the transaction bank details. Present if <c>payment_method_type</c>
        /// field value is <c>gb_bank_account</c>.
        /// </summary>
        [JsonProperty("gb_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gb_bank_account")]
#endif
        public ReceivedCreditBankTransferGbBankAccount GbBankAccount { get; set; }

        /// <summary>
        /// Hash containing the transaction bank details. Present if <c>payment_method_type</c>
        /// field value is <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif
        public ReceivedCreditBankTransferUsBankAccount UsBankAccount { get; set; }
    }
}
