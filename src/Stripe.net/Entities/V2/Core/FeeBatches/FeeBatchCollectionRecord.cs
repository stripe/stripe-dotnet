// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FeeBatchCollectionRecord : StripeEntity<FeeBatchCollectionRecord>
    {
        /// <summary>
        /// The fee amount collected via this record.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// The ID of the associated v1 balance transaction.
        /// </summary>
        [JsonProperty("balance_transaction")]
        [STJS.JsonPropertyName("balance_transaction")]
        public string BalanceTransaction { get; set; }

        /// <summary>
        /// The ID of the associated credit transaction.
        /// </summary>
        [JsonProperty("credit_transaction")]
        [STJS.JsonPropertyName("credit_transaction")]
        public string CreditTransaction { get; set; }

        /// <summary>
        /// The ID of the associated v2 money management transaction.
        /// </summary>
        [JsonProperty("money_management_transaction")]
        [STJS.JsonPropertyName("money_management_transaction")]
        public string MoneyManagementTransaction { get; set; }

        /// <summary>
        /// The ID of the associated accounts-receivable invoice.
        /// </summary>
        [JsonProperty("payable_invoice")]
        [STJS.JsonPropertyName("payable_invoice")]
        public string PayableInvoice { get; set; }

        /// <summary>
        /// The tax amount collected via this record.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public FeeBatchCollectionRecordTax Tax { get; set; }

        /// <summary>
        /// The type of money movement object.
        /// One of: <c>balance_transaction</c>, <c>credit_transaction</c>,
        /// <c>money_management_transaction</c>, or <c>payable_invoice</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
