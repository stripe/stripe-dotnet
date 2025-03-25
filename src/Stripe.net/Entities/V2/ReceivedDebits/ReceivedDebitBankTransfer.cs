// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedDebitBankTransfer : StripeEntity<ReceivedDebitBankTransfer>
    {
        /// <summary>
        /// The Financial Address that was debited.
        /// </summary>
        [JsonProperty("financial_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_address")]
#endif
        public string FinancialAddress { get; set; }

        /// <summary>
        /// Open Enum. The type of the payment method used to originate the debit.
        /// </summary>
        [JsonProperty("payment_method_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_type")]
#endif
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// The statement descriptor set by the originator of the debit.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The payment method used to originate the debit.
        /// </summary>
        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif
        public ReceivedDebitBankTransferUsBankAccount UsBankAccount { get; set; }
    }
}
