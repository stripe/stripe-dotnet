// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Transactions represent changes to a <a
    /// href="https://api.stripe.com#financial_accounts">FinancialAccount's</a> balance.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Transaction : StripeEntity<Transaction>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Amount (in cents) transferred.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Change to a FinancialAccount's balance.
        /// </summary>
        [JsonProperty("balance_impact")]
        [STJS.JsonPropertyName("balance_impact")]
        public TransactionBalanceImpact BalanceImpact { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// A list of TransactionEntries that are part of this Transaction. This cannot be expanded
        /// in any list endpoints.
        /// </summary>
        [JsonProperty("entries")]
        [STJS.JsonPropertyName("entries")]
        public StripeList<TransactionEntry> Entries { get; set; }

        /// <summary>
        /// The FinancialAccount associated with this object.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// ID of the flow that created the Transaction.
        /// </summary>
        [JsonProperty("flow")]
        [STJS.JsonPropertyName("flow")]
        public string Flow { get; set; }

        /// <summary>
        /// Details of the flow that created the Transaction.
        /// </summary>
        [JsonProperty("flow_details")]
        [STJS.JsonPropertyName("flow_details")]
        public TransactionFlowDetails FlowDetails { get; set; }

        /// <summary>
        /// Type of the flow that created the Transaction.
        /// One of: <c>credit_reversal</c>, <c>debit_reversal</c>, <c>inbound_transfer</c>,
        /// <c>issuing_authorization</c>, <c>other</c>, <c>outbound_payment</c>,
        /// <c>outbound_transfer</c>, <c>received_credit</c>, or <c>received_debit</c>.
        /// </summary>
        [JsonProperty("flow_type")]
        [STJS.JsonPropertyName("flow_type")]
        public string FlowType { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Status of the Transaction.
        /// One of: <c>open</c>, <c>posted</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public TransactionStatusTransitions StatusTransitions { get; set; }
    }
}
