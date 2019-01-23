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
        public string AccountId { get; set; }

        [JsonIgnore]
        public Account Account { get; set; }

        [JsonProperty("account")]
        internal object InternalAccount
        {
            get
            {
                return this.Account ?? (object)this.AccountId;
            }

            set
            {
                StringOrObject<Account>.Map(value, s => this.AccountId = s, o => this.Account = o);
            }
        }
        #endregion

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("amount_refunded")]
        public long AmountRefunded { get; set; }

        #region Expandable Application
        [JsonIgnore]
        public string ApplicationId { get; set; }

        [JsonIgnore]
        public Application Application { get; set; }

        [JsonProperty("application")]
        internal object InternalApplication
        {
            get
            {
                return this.Application ?? (object)this.ApplicationId;
            }

            set
            {
                StringOrObject<Application>.Map(value, s => this.ApplicationId = s, o => this.Application = o);
            }
        }
        #endregion

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

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable Originating Transaction
        [JsonIgnore]
        public string OriginatingTransactionId { get; set; }

        [JsonIgnore]
        public Charge OriginatingTransaction { get; set; }

        [JsonProperty("originating_transaction")]
        internal object InternalOriginatingTransaction
        {
            get
            {
                return this.OriginatingTransaction ?? (object)this.OriginatingTransactionId;
            }

            set
            {
                StringOrObject<Charge>.Map(value, s => this.OriginatingTransactionId = s, o => this.OriginatingTransaction = o);
            }
        }
        #endregion

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("refunds")]
        public StripeList<ApplicationFeeRefund> Refunds { get; set; }
    }
}
