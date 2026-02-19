// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class ApplicationFee : StripeEntity<ApplicationFee>, IHasId, IHasObject, IBalanceTransactionSource
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        #region Expandable Account

        /// <summary>
        /// (ID of the Account)
        /// ID of the Stripe account this fee was taken from.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string AccountId
        {
            get => this.InternalAccount?.Id;
            set => this.InternalAccount = SetExpandableFieldId(value, this.InternalAccount);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Stripe account this fee was taken from.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Account Account
        {
            get => this.InternalAccount?.ExpandedObject;
            set => this.InternalAccount = SetExpandableFieldObject(value, this.InternalAccount);
        }

        [JsonProperty("account")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Account>))]
#endif
        internal ExpandableField<Account> InternalAccount { get; set; }
        #endregion

        /// <summary>
        /// Amount earned, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Amount in cents (or local equivalent) refunded (can be less than the amount attribute on
        /// the fee if a partial refund was issued).
        /// </summary>
        [JsonProperty("amount_refunded")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_refunded")]
#endif
        public long AmountRefunded { get; set; }

        #region Expandable Application

        /// <summary>
        /// (ID of the Application)
        /// ID of the Connect application that earned the fee.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ApplicationId
        {
            get => this.InternalApplication?.Id;
            set => this.InternalApplication = SetExpandableFieldId(value, this.InternalApplication);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Connect application that earned the fee.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Application Application
        {
            get => this.InternalApplication?.ExpandedObject;
            set => this.InternalApplication = SetExpandableFieldObject(value, this.InternalApplication);
        }

        [JsonProperty("application")]
        [JsonConverter(typeof(ExpandableFieldConverter<Application>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Application>))]
#endif
        internal ExpandableField<Application> InternalApplication { get; set; }
        #endregion

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// Balance transaction that describes the impact of this collected application fee on your
        /// account balance (not including refunds).
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// Balance transaction that describes the impact of this collected application fee on your
        /// account balance (not including refunds).
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<BalanceTransaction>))]
#endif
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// ID of the charge that the application fee was taken from.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ChargeId
        {
            get => this.InternalCharge?.Id;
            set => this.InternalCharge = SetExpandableFieldId(value, this.InternalCharge);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the charge that the application fee was taken from.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Charge Charge
        {
            get => this.InternalCharge?.ExpandedObject;
            set => this.InternalCharge = SetExpandableFieldObject(value, this.InternalCharge);
        }

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Charge>))]
#endif
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Polymorphic source of the application fee. Includes the ID of the object the application
        /// fee was created from.
        /// </summary>
        [JsonProperty("fee_source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fee_source")]
#endif
        public ApplicationFeeFeeSource FeeSource { get; set; }

        /// <summary>
        /// Polymorphic funding source of the application fee. Includes the type and details of the
        /// funding source.
        /// </summary>
        [JsonProperty("funding_source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("funding_source")]
#endif
        public ApplicationFeeFundingSource FundingSource { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        #region Expandable OriginatingTransaction

        /// <summary>
        /// (ID of the Charge)
        /// ID of the corresponding charge on the platform account, if this fee was the result of a
        /// charge using the <c>destination</c> parameter.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string OriginatingTransactionId
        {
            get => this.InternalOriginatingTransaction?.Id;
            set => this.InternalOriginatingTransaction = SetExpandableFieldId(value, this.InternalOriginatingTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the corresponding charge on the platform account, if this fee was the result of a
        /// charge using the <c>destination</c> parameter.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Charge OriginatingTransaction
        {
            get => this.InternalOriginatingTransaction?.ExpandedObject;
            set => this.InternalOriginatingTransaction = SetExpandableFieldObject(value, this.InternalOriginatingTransaction);
        }

        [JsonProperty("originating_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("originating_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Charge>))]
#endif
        internal ExpandableField<Charge> InternalOriginatingTransaction { get; set; }
        #endregion

        /// <summary>
        /// Whether the fee has been fully refunded. If the fee is only partially refunded, this
        /// attribute will still be false.
        /// </summary>
        [JsonProperty("refunded")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refunded")]
#endif
        public bool Refunded { get; set; }

        /// <summary>
        /// A list of refunds that have been applied to the fee.
        /// </summary>
        [JsonProperty("refunds")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refunds")]
#endif
        public StripeList<ApplicationFeeRefund> Refunds { get; set; }

        /// <summary>
        /// Type of settlement for the application fee. One of <c>net_settled</c> or
        /// <c>gross_settled</c>.
        /// One of: <c>gross_settled</c>, or <c>net_settled</c>.
        /// </summary>
        [JsonProperty("settlement_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settlement_type")]
#endif
        public string SettlementType { get; set; }
    }
}
