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

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Destination Payment Refund
        [JsonIgnore]
        public string DestinationPaymentRefundId { get; set; }

        [JsonIgnore]
        public Refund DestinationPaymentRefund { get; set; }

        [JsonProperty("destination_payment_refund")]
        internal object InternalDestinationPaymentRefund
        {
            get
            {
                return this.DestinationPaymentRefund ?? (object)this.DestinationPaymentRefundId;
            }

            set
            {
                StringOrObject<Refund>.Map(value, s => this.DestinationPaymentRefundId = s, o => this.DestinationPaymentRefund = o);
            }
        }
        #endregion

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable Source Refund
        [JsonIgnore]
        public string SourceRefundId { get; set; }

        [JsonIgnore]
        public Refund SourceRefund { get; set; }

        [JsonProperty("source_refund")]
        internal object InternalSourceRefund
        {
            get
            {
                return this.SourceRefund ?? (object)this.SourceRefundId;
            }

            set
            {
                StringOrObject<Refund>.Map(value, s => this.SourceRefundId = s, o => this.SourceRefund = o);
            }
        }
        #endregion

        #region Expandable Transfer
        [JsonIgnore]
        public string TransferId { get; set; }

        [JsonIgnore]
        public Transfer Transfer { get; set; }

        [JsonProperty("transfer")]
        internal object InternalTransfer
        {
            get
            {
                return this.Transfer ?? (object)this.TransferId;
            }

            set
            {
                StringOrObject<Transfer>.Map(value, s => this.TransferId = s, o => this.Transfer = o);
            }
        }
        #endregion
    }
}
