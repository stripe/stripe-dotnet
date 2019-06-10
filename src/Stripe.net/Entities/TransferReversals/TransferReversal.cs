namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransferReversal : StripeEntity<TransferReversal>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Destination Payment Refund
        [JsonIgnore]
        public string DestinationPaymentRefundId
        {
            get => this.InternalDestinationPaymentRefund.Id;
            set => this.InternalDestinationPaymentRefund.Id = value;
        }

        [JsonIgnore]
        public Refund DestinationPaymentRefund
        {
            get => this.InternalDestinationPaymentRefund.ExpandedObject;
            set => this.InternalDestinationPaymentRefund.ExpandedObject = value;
        }

        [JsonProperty("destination_payment_refund")]
        [JsonConverter(typeof(ExpandableFieldConverter<Refund>))]
        internal ExpandableField<Refund> InternalDestinationPaymentRefund { get; set; }
        #endregion

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable Source Refund
        [JsonIgnore]
        public string SourceRefundId
        {
            get => this.InternalSourceRefund.Id;
            set => this.InternalSourceRefund.Id = value;
        }

        [JsonIgnore]
        public Refund SourceRefund
        {
            get => this.InternalSourceRefund.ExpandedObject;
            set => this.InternalSourceRefund.ExpandedObject = value;
        }

        [JsonProperty("source_refund")]
        [JsonConverter(typeof(ExpandableFieldConverter<Refund>))]
        internal ExpandableField<Refund> InternalSourceRefund { get; set; }
        #endregion

        #region Expandable Transfer
        [JsonIgnore]
        public string TransferId
        {
            get => this.InternalTransfer.Id;
            set => this.InternalTransfer.Id = value;
        }

        [JsonIgnore]
        public Transfer Transfer
        {
            get => this.InternalTransfer.ExpandedObject;
            set => this.InternalTransfer.ExpandedObject = value;
        }

        [JsonProperty("transfer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transfer>))]
        internal ExpandableField<Transfer> InternalTransfer { get; set; }
        #endregion
    }
}
