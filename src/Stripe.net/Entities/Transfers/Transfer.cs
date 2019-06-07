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

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Destination
        [JsonIgnore]
        public string DestinationId => this.InternalDestination.Id;

        [JsonIgnore]
        public Account Destination => this.InternalDestination.ExpandedObject;

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalDestination { get; set; }
        #endregion

        #region Expandable Destination Payment
        [JsonIgnore]
        public string DestinationPaymentId => this.InternalDestinationPayment.Id;

        [JsonIgnore]
        public Charge DestinationPayment => this.InternalDestinationPayment.ExpandedObject;

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
        public string SourceTransactionId => this.InternalSourceTransaction.Id;

        [JsonIgnore]
        public Charge SourceTransaction => this.InternalSourceTransaction.ExpandedObject;

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
