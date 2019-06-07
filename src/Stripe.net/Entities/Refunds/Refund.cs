namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Refund : StripeEntity<Refund>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable Balance Transaction
        [JsonIgnore]
        public string BalanceTransactionId => this.InternalBalanceTransaction.Id;

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction => this.InternalBalanceTransaction.ExpandedObject;

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        #region Expandable Charge
        [JsonIgnore]
        public string ChargeId => this.InternalCharge.Id;

        [JsonIgnore]
        public Charge Charge => this.InternalCharge.ExpandedObject;

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Failure Balance Transaction
        [JsonIgnore]
        public string FailureBalanceTransactionId => this.InternalFailureBalanceTransaction.Id;

        [JsonIgnore]
        public BalanceTransaction FailureBalanceTransaction => this.InternalFailureBalanceTransaction.ExpandedObject;

        [JsonProperty("failure_balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalFailureBalanceTransaction { get; set; }
        #endregion

        [JsonProperty("failure_reason")]
        public string FailureReason { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        #region Expandable Source Transfer Reversal
        [JsonIgnore]
        public string SourceTransferReversalId => this.InternalSourceTransferReversal.Id;

        [JsonIgnore]
        public TransferReversal SourceTransferReversal => this.InternalSourceTransferReversal.ExpandedObject;

        [JsonProperty("source_transfer_reversal")]
        [JsonConverter(typeof(ExpandableFieldConverter<TransferReversal>))]
        internal ExpandableField<TransferReversal> InternalSourceTransferReversal { get; set; }
        #endregion

        [JsonProperty("status")]
        public string Status { get; set; }

        #region Expandable  Transfer Reversal
        [JsonIgnore]
        public string TransferReversalId => this.InternalTransferReversal.Id;

        [JsonIgnore]
        public TransferReversal TransferReversal => this.InternalTransferReversal.ExpandedObject;

        [JsonProperty("transfer_reversal")]
        [JsonConverter(typeof(ExpandableFieldConverter<TransferReversal>))]
        internal ExpandableField<TransferReversal> InternalTransferReversal { get; set; }
        #endregion
    }
}
