namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Transfer : StripeEntity<Transfer>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("amount_reversed")]
        public long AmountReversed { get; set; }

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

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Destination
        [JsonIgnore]
        public string DestinationId
        {
            get => this.InternalDestination.Id;
            set => this.InternalDestination.Id = value;
        }

        [JsonIgnore]
        public Account Destination
        {
            get => this.InternalDestination.ExpandedObject;
            set => this.InternalDestination.ExpandedObject = value;
        }

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalDestination { get; set; }
        #endregion

        #region Expandable Destination Payment
        [JsonIgnore]
        public string DestinationPaymentId
        {
            get => this.InternalDestinationPayment.Id;
            set => this.InternalDestinationPayment.Id = value;
        }

        [JsonIgnore]
        public Charge DestinationPayment
        {
            get => this.InternalDestinationPayment.ExpandedObject;
            set => this.InternalDestinationPayment.ExpandedObject = value;
        }

        [JsonProperty("destination_payment")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalDestinationPayment { get; set; }
        #endregion

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("reversals")]
        public StripeList<TransferReversal> Reversals { get; set; }

        [JsonProperty("reversed")]
        public bool Reversed { get; set; }

        #region Expandable Source Transaction
        [JsonIgnore]
        public string SourceTransactionId
        {
            get => this.InternalSourceTransaction.Id;
            set => this.InternalSourceTransaction.Id = value;
        }

        [JsonIgnore]
        public Charge SourceTransaction
        {
            get => this.InternalSourceTransaction.ExpandedObject;
            set => this.InternalSourceTransaction.ExpandedObject = value;
        }

        [JsonProperty("source_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalSourceTransaction { get; set; }
        #endregion

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
