namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Payout : StripeEntity<Payout>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("arrival_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ArrivalDate { get; set; }

        [JsonProperty("automatic")]
        public bool Automatic { get; set; }

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
        public IExternalAccount Destination => this.InternalDestination.ExpandedObject;

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<IExternalAccount>))]
        internal ExpandableField<IExternalAccount> InternalDestination { get; set; }
        #endregion

        #region Expandable Failure Balance Transaction

        /// <summary>
        /// If the payout failed or was canceled, this will be the ID of the balance transaction that reversed the initial balance transaction, and puts the funds from the failed payout back in your balance.
        /// </summary>
        [JsonIgnore]
        public string FailureBalanceTransactionId => this.InternalFailureBalanceTransaction.Id;

        [JsonIgnore]
        public BalanceTransaction FailureBalanceTransaction => this.InternalFailureBalanceTransaction.ExpandedObject;

        [JsonProperty("failure_balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalFailureBalanceTransaction { get; set; }
        #endregion

        [JsonProperty("failure_code")]
        public string FailureCode { get; set; }

        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        // example: bank_account
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
