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
        public string BalanceTransactionId => this.InternalBalanceTransaction.Id;

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction => this.InternalBalanceTransaction.ExpandedObject;

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
        public string DestinationPaymentRefundId => this.InternalDestinationPaymentRefund.Id;

        [JsonIgnore]
        public Refund DestinationPaymentRefund => this.InternalDestinationPaymentRefund.ExpandedObject;

        [JsonProperty("destination_payment_refund")]
        [JsonConverter(typeof(ExpandableFieldConverter<Refund>))]
        internal ExpandableField<Refund> InternalDestinationPaymentRefund { get; set; }
        #endregion

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable Source Refund
        [JsonIgnore]
        public string SourceRefundId => this.InternalSourceRefund.Id;

        [JsonIgnore]
        public Refund SourceRefund => this.InternalSourceRefund.ExpandedObject;

        [JsonProperty("source_refund")]
        [JsonConverter(typeof(ExpandableFieldConverter<Refund>))]
        internal ExpandableField<Refund> InternalSourceRefund { get; set; }
        #endregion

        #region Expandable Transfer
        [JsonIgnore]
        public string TransferId => this.InternalTransfer.Id;

        [JsonIgnore]
        public Transfer Transfer => this.InternalTransfer.ExpandedObject;

        [JsonProperty("transfer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transfer>))]
        internal ExpandableField<Transfer> InternalTransfer { get; set; }
        #endregion
    }
}
