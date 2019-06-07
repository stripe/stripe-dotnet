namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ApplicationFee : StripeEntity<ApplicationFee>, IHasId, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable Account
        [JsonIgnore]
        public string AccountId => this.InternalAccount.Id;

        [JsonIgnore]
        public Account Account => this.InternalAccount.ExpandedObject;

        [JsonProperty("account")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalAccount { get; set; }
        #endregion

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("amount_refunded")]
        public long AmountRefunded { get; set; }

        #region Expandable Application
        [JsonIgnore]
        public string ApplicationId => this.InternalApplication.Id;

        [JsonIgnore]
        public Application Application => this.InternalApplication.ExpandedObject;

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

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

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable Originating Transaction
        [JsonIgnore]
        public string OriginatingTransactionId => this.InternalOriginatingTransaction.Id;

        [JsonIgnore]
        public Charge OriginatingTransaction => this.InternalOriginatingTransaction.ExpandedObject;

        [JsonProperty("originating_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalOriginatingTransaction { get; set; }
        #endregion

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("refunds")]
        public StripeList<ApplicationFeeRefund> Refunds { get; set; }
    }
}
