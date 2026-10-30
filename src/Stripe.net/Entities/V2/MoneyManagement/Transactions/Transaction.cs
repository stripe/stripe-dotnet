// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Transaction records how a money movement flow affects your FinancialAccount balance. A
    /// flow can create one or more Transactions.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Transaction : StripeEntity<Transaction>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The amount of the Transaction.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// The change to the FinancialAccount's balance. This is the sum of the balance impacts of
        /// this Transaction's TransactionEntries with <c>effective_at</c> timestamps in the past.
        /// </summary>
        [JsonProperty("balance_impact")]
        [STJS.JsonPropertyName("balance_impact")]
        public TransactionBalanceImpact BalanceImpact { get; set; }

        /// <summary>
        /// Open Enum. A category used to classify the Transaction.
        /// One of: <c>adjustment</c>, <c>advance</c>, <c>anticipation_repayment</c>,
        /// <c>balance_transfer</c>, <c>climate_order_purchase</c>, <c>climate_order_refund</c>,
        /// <c>connect_collection_transfer</c>, <c>connect_reserved_funds</c>, <c>contribution</c>,
        /// <c>crypto_wallet_export</c>, <c>currency_conversion</c>, <c>debit_dispute</c>,
        /// <c>dispute</c>, <c>dispute_reversal</c>, <c>earned_credit</c>, <c>financing_paydown</c>,
        /// <c>financing_paydown_reversal</c>, <c>inbound_payment</c>,
        /// <c>inbound_payment_failure</c>, <c>inbound_transfer</c>,
        /// <c>inbound_transfer_reversal</c>, <c>india_mdr_processing_fee</c>,
        /// <c>issuing_authorization</c>, <c>issuing_dispute</c>,
        /// <c>issuing_dispute_fraud_liability_debit</c>, <c>issuing_dispute_provisional_credit</c>,
        /// <c>issuing_dispute_provisional_credit_reversal</c>, <c>issuing_transaction</c>,
        /// <c>minimum_balance_hold</c>, <c>network_cost</c>, <c>obligation</c>,
        /// <c>outbound_payment</c>, <c>outbound_payment_reversal</c>, <c>outbound_transfer</c>,
        /// <c>outbound_transfer_reversal</c>, <c>partial_capture_reversal</c>,
        /// <c>payment_method_passthrough_fee</c>, <c>payment_network_reserved_funds</c>,
        /// <c>platform_earning</c>, <c>platform_earning_refund</c>, <c>platform_fee</c>,
        /// <c>platform_funded_credit_transaction</c>, <c>received_credit</c>,
        /// <c>received_credit_reversal</c>, <c>received_debit</c>, <c>received_debit_reversal</c>,
        /// <c>refund</c>, <c>refund_failure</c>, <c>risk_reserved_funds</c>,
        /// <c>stripe_balance_payment_debit</c>, <c>stripe_balance_payment_debit_reversal</c>,
        /// <c>stripe_fee</c>, <c>stripe_fee_tax</c>, <c>tax_fund</c>, <c>tax_withholding</c>,
        /// <c>transfer_reversal</c>, or <c>unreconciled_customer_funds</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("category")]
        [STJS.JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Details about the counterparty to this Transaction.
        /// </summary>
        [JsonProperty("counterparty")]
        [STJS.JsonPropertyName("counterparty")]
        public TransactionCounterparty Counterparty { get; set; }

        /// <summary>
        /// Time at which the object was created. Represented as an RFC 3339 timestamp in UTC with
        /// millisecond precision, for example <c>2022-09-18T13:22:18.123Z</c>.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// A description of the Transaction. When applicable, the description is copied from the
        /// flow object when the Transaction is created. You can update it using the Update
        /// Transaction endpoint.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the FinancialAccount affected by this Transaction.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Details about the flow object that created the Transaction, such as an InboundTransfer
        /// or OutboundPayment. <c>flow.type</c> identifies the kind of object. The corresponding
        /// field contains its ID, when available: for an InboundTransfer,
        /// <c>flow.inbound_transfer</c> contains the InboundTransfer's ID. Pass that ID to the
        /// <c>flow</c> parameter on List Transactions.
        /// </summary>
        [JsonProperty("flow")]
        [STJS.JsonPropertyName("flow")]
        public TransactionFlow Flow { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Hosted transaction receipt that is provided when money movement is considered regulated
        /// under Stripe's money transmission licenses. If not applicable,
        /// <c>regulatory_receipt.status</c> will be <c>not_applicable</c> and no URL will be
        /// provided unless you opt in by calling <c>/refresh_regulatory_receipt</c>.
        /// </summary>
        [JsonProperty("regulatory_receipt")]
        [STJS.JsonPropertyName("regulatory_receipt")]
        public TransactionRegulatoryReceipt RegulatoryReceipt { get; set; }

        /// <summary>
        /// Closed Enum. The current status of the Transaction. A Transaction is <c>pending</c> if
        /// either <c>balance_impact.inbound_pending</c> or <c>balance_impact.outbound_pending</c>
        /// is non-zero. A Transaction is <c>posted</c> if only <c>balance_impact.available</c> is
        /// non-zero. A Transaction is <c>void</c> if there is no balance impact. <c>posted</c> and
        /// <c>void</c> are terminal states, and no additional TransactionEntries will be added to
        /// the Transaction.
        /// One of: <c>pending</c>, <c>posted</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Timestamps for when the Transaction transitioned to each status.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public TransactionStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// The v1 Treasury transaction associated with this transaction.
        /// </summary>
        [JsonProperty("treasury_transaction")]
        [STJS.JsonPropertyName("treasury_transaction")]
        public string TreasuryTransaction { get; set; }
    }
}
