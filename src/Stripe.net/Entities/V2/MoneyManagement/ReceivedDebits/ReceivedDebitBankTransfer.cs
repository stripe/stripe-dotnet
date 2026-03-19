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
        /// Open Enum. Indicates the origin type through which this debit was initiated.
        /// </summary>
        [JsonProperty("origin_type")]
        [STJS.JsonPropertyName("origin_type")]
        public string OriginType { get; set; }

        /// <summary>
        /// Open Enum. The type of the payment method used to originate the debit.
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
        /// The payment method used to originate the debit.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public ReceivedDebitBankTransferUsBankAccount UsBankAccount { get; set; }
    }
}
