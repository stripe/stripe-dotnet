// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Any use of an <a href="https://docs.stripe.com/issuing">issued card</a> that results in
    /// funds entering or leaving your Stripe account, such as a completed purchase or refund,
    /// is represented by an Issuing <c>Transaction</c> object.
    ///
    /// Related guide: <a href="https://docs.stripe.com/issuing/purchases/transactions">Issued
    /// card transactions</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class Transaction : StripeEntity<Transaction>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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

        /// <summary>
        /// The transaction amount, which will be reflected in your balance. This amount is in your
        /// currency and in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest
        /// currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Detailed breakdown of amount components. These amounts are denominated in
        /// <c>currency</c> and in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_details")]
#endif
        public TransactionAmountDetails AmountDetails { get; set; }

        #region Expandable Authorization

        /// <summary>
        /// (ID of the Authorization)
        /// The <c>Authorization</c> object that led to this transaction.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string AuthorizationId
        {
            get => this.InternalAuthorization?.Id;
            set => this.InternalAuthorization = SetExpandableFieldId(value, this.InternalAuthorization);
        }

        /// <summary>
        /// (Expanded)
        /// The <c>Authorization</c> object that led to this transaction.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Authorization Authorization
        {
            get => this.InternalAuthorization?.ExpandedObject;
            set => this.InternalAuthorization = SetExpandableFieldObject(value, this.InternalAuthorization);
        }

        [JsonProperty("authorization")]
        [JsonConverter(typeof(ExpandableFieldConverter<Authorization>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Authorization>))]
#endif
        internal ExpandableField<Authorization> InternalAuthorization { get; set; }
        #endregion

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// ID of the <a href="https://docs.stripe.com/api/balance_transactions">balance
        /// transaction</a> associated with this transaction.
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
        /// ID of the <a href="https://docs.stripe.com/api/balance_transactions">balance
        /// transaction</a> associated with this transaction.
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

        #region Expandable Card

        /// <summary>
        /// (ID of the Card)
        /// The card used to make this transaction.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string CardId
        {
            get => this.InternalCard?.Id;
            set => this.InternalCard = SetExpandableFieldId(value, this.InternalCard);
        }

        /// <summary>
        /// (Expanded)
        /// The card used to make this transaction.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Card Card
        {
            get => this.InternalCard?.ExpandedObject;
            set => this.InternalCard = SetExpandableFieldObject(value, this.InternalCard);
        }

        [JsonProperty("card")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Card>))]
#endif
        internal ExpandableField<Card> InternalCard { get; set; }
        #endregion

        #region Expandable Cardholder

        /// <summary>
        /// (ID of the Cardholder)
        /// The cardholder to whom this transaction belongs.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string CardholderId
        {
            get => this.InternalCardholder?.Id;
            set => this.InternalCardholder = SetExpandableFieldId(value, this.InternalCardholder);
        }

        /// <summary>
        /// (Expanded)
        /// The cardholder to whom this transaction belongs.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Cardholder Cardholder
        {
            get => this.InternalCardholder?.ExpandedObject;
            set => this.InternalCardholder = SetExpandableFieldObject(value, this.InternalCardholder);
        }

        [JsonProperty("cardholder")]
        [JsonConverter(typeof(ExpandableFieldConverter<Cardholder>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cardholder")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Cardholder>))]
#endif
        internal ExpandableField<Cardholder> InternalCardholder { get; set; }
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

        #region Expandable Dispute

        /// <summary>
        /// (ID of the Dispute)
        /// If you've disputed the transaction, the ID of the dispute.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string DisputeId
        {
            get => this.InternalDispute?.Id;
            set => this.InternalDispute = SetExpandableFieldId(value, this.InternalDispute);
        }

        /// <summary>
        /// (Expanded)
        /// If you've disputed the transaction, the ID of the dispute.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Dispute Dispute
        {
            get => this.InternalDispute?.ExpandedObject;
            set => this.InternalDispute = SetExpandableFieldObject(value, this.InternalDispute);
        }

        [JsonProperty("dispute")]
        [JsonConverter(typeof(ExpandableFieldConverter<Dispute>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dispute")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Dispute>))]
#endif
        internal ExpandableField<Dispute> InternalDispute { get; set; }
        #endregion

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// The amount that the merchant will receive, denominated in <c>merchant_currency</c> and
        /// in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest currency
        /// unit</a>. It will be different from <c>amount</c> if the merchant is taking payment in a
        /// different currency.
        /// </summary>
        [JsonProperty("merchant_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_amount")]
#endif
        public long MerchantAmount { get; set; }

        /// <summary>
        /// The currency with which the merchant is taking payment.
        /// </summary>
        [JsonProperty("merchant_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_currency")]
#endif
        public string MerchantCurrency { get; set; }

        [JsonProperty("merchant_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_data")]
#endif
        public AuthorizationMerchantData MerchantData { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Details about the transaction, such as processing dates, set by the card network.
        /// </summary>
        [JsonProperty("network_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_data")]
#endif
        public TransactionNetworkData NetworkData { get; set; }

        /// <summary>
        /// Additional purchase information that is optionally provided by the merchant.
        /// </summary>
        [JsonProperty("purchase_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("purchase_details")]
#endif
        public TransactionPurchaseDetails PurchaseDetails { get; set; }

        #region Expandable Settlement

        /// <summary>
        /// (ID of the Settlement)
        /// The ID of the <a href="https://docs.stripe.com/api/issuing/settlements">settlement</a>
        /// to which this transaction belongs.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string SettlementId
        {
            get => this.InternalSettlement?.Id;
            set => this.InternalSettlement = SetExpandableFieldId(value, this.InternalSettlement);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the <a href="https://docs.stripe.com/api/issuing/settlements">settlement</a>
        /// to which this transaction belongs.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Settlement Settlement
        {
            get => this.InternalSettlement?.ExpandedObject;
            set => this.InternalSettlement = SetExpandableFieldObject(value, this.InternalSettlement);
        }

        [JsonProperty("settlement")]
        [JsonConverter(typeof(ExpandableFieldConverter<Settlement>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settlement")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Settlement>))]
#endif
        internal ExpandableField<Settlement> InternalSettlement { get; set; }
        #endregion

        #region Expandable Token

        /// <summary>
        /// (ID of the Token)
        /// <a href="https://docs.stripe.com/api/issuing/tokens/object">Token</a> object used for
        /// this transaction. If a network token was not used for this transaction, this field will
        /// be null.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string TokenId
        {
            get => this.InternalToken?.Id;
            set => this.InternalToken = SetExpandableFieldId(value, this.InternalToken);
        }

        /// <summary>
        /// (Expanded)
        /// <a href="https://docs.stripe.com/api/issuing/tokens/object">Token</a> object used for
        /// this transaction. If a network token was not used for this transaction, this field will
        /// be null.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Token Token
        {
            get => this.InternalToken?.ExpandedObject;
            set => this.InternalToken = SetExpandableFieldObject(value, this.InternalToken);
        }

        [JsonProperty("token")]
        [JsonConverter(typeof(ExpandableFieldConverter<Token>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Token>))]
#endif
        internal ExpandableField<Token> InternalToken { get; set; }
        #endregion

        /// <summary>
        /// <a href="https://docs.stripe.com/api/treasury">Treasury</a> details related to this
        /// transaction if it was created on a
        /// [FinancialAccount](/docs/api/treasury/financial_accounts.
        /// </summary>
        [JsonProperty("treasury")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("treasury")]
#endif
        public TransactionTreasury Treasury { get; set; }

        /// <summary>
        /// The nature of the transaction.
        /// One of: <c>capture</c>, or <c>refund</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The digital wallet used for this transaction. One of <c>apple_pay</c>,
        /// <c>google_pay</c>, or <c>samsung_pay</c>.
        /// One of: <c>apple_pay</c>, <c>google_pay</c>, or <c>samsung_pay</c>.
        /// </summary>
        [JsonProperty("wallet")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wallet")]
#endif
        public string Wallet { get; set; }
    }
}
