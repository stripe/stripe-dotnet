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
        public string AccountId
        {
            get => this.InternalAccount.Id;
            set => this.InternalAccount.Id = value;
        }

        [JsonIgnore]
        public Account Account
        {
            get => this.InternalAccount.ExpandedObject;
            set => this.InternalAccount.ExpandedObject = value;
        }

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
        public string ApplicationId
        {
            get => this.InternalApplication.Id;
            set => this.InternalApplication.Id = value;
        }

        [JsonIgnore]
        public Application Application
        {
            get => this.InternalApplication.ExpandedObject;
            set => this.InternalApplication.ExpandedObject = value;
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

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

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable Originating Transaction
        [JsonIgnore]
        public string OriginatingTransactionId
        {
            get => this.InternalOriginatingTransaction.Id;
            set => this.InternalOriginatingTransaction.Id = value;
        }

        [JsonIgnore]
        public Charge OriginatingTransaction
        {
            get => this.InternalOriginatingTransaction.ExpandedObject;
            set => this.InternalOriginatingTransaction.ExpandedObject = value;
        }

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
