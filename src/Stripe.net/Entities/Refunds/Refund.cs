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
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction.Id;
            set => this.InternalBalanceTransaction.Id = value;
        }

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction.ExpandedObject;
            set => this.InternalBalanceTransaction.ExpandedObject = value;
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        #region Expandable Charge
        [JsonIgnore]
        public string ChargeId
        {
            get => this.InternalCharge.Id;
            set => this.InternalCharge.Id = value;
        }

        [JsonIgnore]
        public Charge Charge
        {
            get => this.InternalCharge.ExpandedObject;
            set => this.InternalCharge.ExpandedObject = value;
        }

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
        public string FailureBalanceTransactionId
        {
            get => this.InternalFailureBalanceTransaction.Id;
            set => this.InternalFailureBalanceTransaction.Id = value;
        }

        [JsonIgnore]
        public BalanceTransaction FailureBalanceTransaction
        {
            get => this.InternalFailureBalanceTransaction.ExpandedObject;
            set => this.InternalFailureBalanceTransaction.ExpandedObject = value;
        }

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
        public string SourceTransferReversalId
        {
            get => this.InternalSourceTransferReversal.Id;
            set => this.InternalSourceTransferReversal.Id = value;
        }

        [JsonIgnore]
        public TransferReversal SourceTransferReversal
        {
            get => this.InternalSourceTransferReversal.ExpandedObject;
            set => this.InternalSourceTransferReversal.ExpandedObject = value;
        }

        [JsonProperty("source_transfer_reversal")]
        [JsonConverter(typeof(ExpandableFieldConverter<TransferReversal>))]
        internal ExpandableField<TransferReversal> InternalSourceTransferReversal { get; set; }
        #endregion

        [JsonProperty("status")]
        public string Status { get; set; }

        #region Expandable  Transfer Reversal
        [JsonIgnore]
        public string TransferReversalId
        {
            get => this.InternalTransferReversal.Id;
            set => this.InternalTransferReversal.Id = value;
        }

        [JsonIgnore]
        public TransferReversal TransferReversal
        {
            get => this.InternalTransferReversal.ExpandedObject;
            set => this.InternalTransferReversal.ExpandedObject = value;
        }

        [JsonProperty("transfer_reversal")]
        [JsonConverter(typeof(ExpandableFieldConverter<TransferReversal>))]
        internal ExpandableField<TransferReversal> InternalTransferReversal { get; set; }
        #endregion
    }
}
