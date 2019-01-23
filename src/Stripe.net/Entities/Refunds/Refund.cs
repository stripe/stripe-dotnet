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
        public string BalanceTransactionId { get; set; }

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction { get; set; }

        [JsonProperty("balance_transaction")]
        internal object InternalBalanceTransaction
        {
            get
            {
                return this.BalanceTransaction ?? (object)this.BalanceTransactionId;
            }

            set
            {
                StringOrObject<BalanceTransaction>.Map(value, s => this.BalanceTransactionId = s, o => this.BalanceTransaction = o);
            }
        }
        #endregion

        #region Expandable Charge
        [JsonIgnore]
        public string ChargeId { get; set; }

        [JsonIgnore]
        public Charge Charge { get; set; }

        [JsonProperty("charge")]
        internal object InternalCharge
        {
            get
            {
                return this.Charge ?? (object)this.ChargeId;
            }

            set
            {
                StringOrObject<Charge>.Map(value, s => this.ChargeId = s, o => this.Charge = o);
            }
        }
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
        public string FailureBalanceTransactionId { get; set; }

        [JsonIgnore]
        public BalanceTransaction FailureBalanceTransaction { get; set; }

        [JsonProperty("failure_balance_transaction")]
        internal object InternalFailureBalanceTransaction
        {
            get
            {
                return this.FailureBalanceTransaction ?? (object)this.FailureBalanceTransactionId;
            }

            set
            {
                StringOrObject<BalanceTransaction>.Map(value, s => this.FailureBalanceTransactionId = s, o => this.FailureBalanceTransaction = o);
            }
        }
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
        public string SourceTransferReversalId { get; set; }

        [JsonIgnore]
        public TransferReversal SourceTransferReversal { get; set; }

        [JsonProperty("source_transfer_reversal")]
        internal object InternalSourceTransferReversal
        {
            get
            {
                return this.SourceTransferReversal ?? (object)this.SourceTransferReversalId;
            }

            set
            {
                StringOrObject<TransferReversal>.Map(value, s => this.SourceTransferReversalId = s, o => this.SourceTransferReversal = o);
            }
        }
        #endregion

        [JsonProperty("status")]
        public string Status { get; set; }

        #region Expandable  Transfer Reversal
        [JsonIgnore]
        public string TransferReversalId { get; set; }

        [JsonIgnore]
        public TransferReversal TransferReversal { get; set; }

        [JsonProperty("transfer_reversal")]
        internal object InternalTransferReversal
        {
            get
            {
                return this.TransferReversal ?? (object)this.TransferReversalId;
            }

            set
            {
                StringOrObject<TransferReversal>.Map(value, s => this.TransferReversalId = s, o => this.TransferReversal = o);
            }
        }
        #endregion
    }
}
