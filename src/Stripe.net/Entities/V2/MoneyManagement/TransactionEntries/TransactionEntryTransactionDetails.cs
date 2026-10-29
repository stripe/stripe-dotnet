// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionEntryTransactionDetails : StripeEntity<TransactionEntryTransactionDetails>
    {
        /// <summary>
        /// Open Enum. The category of this TransactionEntry's parent Transaction.
        /// One of: <c>adjustment</c>, <c>currency_conversion</c>, <c>inbound_transfer</c>,
        /// <c>inbound_transfer_reversal</c>, <c>outbound_payment</c>,
        /// <c>outbound_payment_reversal</c>, <c>outbound_transfer</c>,
        /// <c>outbound_transfer_reversal</c>, <c>received_credit</c>,
        /// <c>received_credit_reversal</c>, <c>received_debit</c>, <c>received_debit_reversal</c>,
        /// <c>stripe_fee</c>, or <c>stripe_fee_tax</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("category")]
        [STJS.JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// The ID of the FinancialAccount affected by this Transaction.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Details about the flow object that created the Transaction this entry belongs to, such
        /// as an InboundTransfer or OutboundPayment. <c>transaction_details.flow.type</c>
        /// identifies the kind of object. The corresponding field contains its ID, when available:
        /// for an InboundTransfer, <c>transaction_details.flow.inbound_transfer</c> contains the
        /// InboundTransfer's ID. To list entries for the parent Transaction, pass the
        /// TransactionEntry's <c>transaction</c> ID to the <c>transaction</c> parameter on List
        /// Transaction Entries.
        /// </summary>
        [JsonProperty("flow")]
        [STJS.JsonPropertyName("flow")]
        public TransactionEntryTransactionDetailsFlow Flow { get; set; }
    }
}
