// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitBankTransfer : StripeEntity<ReceivedDebitBankTransfer>
    {
        /// <summary>
        /// The Financial Address that was debited.
        /// </summary>
        [JsonProperty("financial_address")]
        [STJS.JsonPropertyName("financial_address")]
        public string FinancialAddress { get; set; }

        /// <summary>
        /// Object containing details of the GB Bank Account that originated the debit. Present when
        /// the debit was originated via BACS.
        /// </summary>
        [JsonProperty("gb_bank_account")]
        [STJS.JsonPropertyName("gb_bank_account")]
        public ReceivedDebitBankTransferGbBankAccount GbBankAccount { get; set; }

        /// <summary>
        /// Open Enum. Indicates the origin type through which this debit was initiated.
        /// One of: <c>gb_bank_account</c>, or <c>us_bank_account</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("origin_type")]
        [STJS.JsonPropertyName("origin_type")]
        public string OriginType { get; set; }

        /// <summary>
        /// Open Enum. The type of the payment method used to originate the debit.
        /// One of: <c>gb_bank_account</c>, or <c>us_bank_account</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("payment_method_type")]
        [STJS.JsonPropertyName("payment_method_type")]
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// The statement descriptor set by the originator of the debit.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Object containing details of the US Bank Account that originated the debit. Present when
        /// the debit was originated via ACH.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public ReceivedDebitBankTransferUsBankAccount UsBankAccount { get; set; }
    }
}
