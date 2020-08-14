namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Authorization : StripeEntity<Authorization>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The total amount that was authorized or rejected. This amount is in the card's currency
        /// and in the <a href="https://stripe.com/docs/currencies#zero-decimal">smallest currency
        /// unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Whether the authorization has been approved.
        /// </summary>
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        /// <summary>
        /// How the card details were provided.
        /// One of: <c>chip</c>, <c>contactless</c>, <c>keyed_in</c>, <c>online</c>, or
        /// <c>swipe</c>.
        /// </summary>
        [JsonProperty("authorization_method")]
        public string AuthorizationMethod { get; set; }

        /// <summary>
        /// List of balance transactions associated with this authorization.
        /// </summary>
        [JsonProperty("balance_transactions")]
        public List<BalanceTransaction> BalanceTransactions { get; set; }

        /// <summary>
        /// You can <a href="https://stripe.com/docs/issuing/cards">create physical or virtual
        /// cards</a> that are issued to cardholders.
        /// </summary>
        [JsonProperty("card")]
        public Card Card { get; set; }

        #region Expandable Cardholder

        /// <summary>
        /// (ID of the Cardholder)
        /// The cardholder to whom this authorization belongs.
        /// </summary>
        [JsonIgnore]
        public string CardholderId
        {
            get => this.InternalCardholder?.Id;
            set => this.InternalCardholder = SetExpandableFieldId(value, this.InternalCardholder);
        }

        /// <summary>
        /// (Expanded)
        /// The cardholder to whom this authorization belongs.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Cardholder Cardholder
        {
            get => this.InternalCardholder?.ExpandedObject;
            set => this.InternalCardholder = SetExpandableFieldObject(value, this.InternalCardholder);
        }

        [JsonProperty("cardholder")]
        [JsonConverter(typeof(ExpandableFieldConverter<Cardholder>))]
        internal ExpandableField<Cardholder> InternalCardholder { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The total amount that was authorized or rejected. This amount is in the
        /// <c>merchant_currency</c> and in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("merchant_amount")]
        public long MerchantAmount { get; set; }

        /// <summary>
        /// The currency that was presented to the cardholder for the authorization. Three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a>, in
        /// lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("merchant_currency")]
        public string MerchantCurrency { get; set; }

        [JsonProperty("merchant_data")]
        public AuthorizationMerchantData MerchantData { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The pending authorization request. This field will only be non-null during an
        /// <c>issuing_authorization.request</c> webhook.
        /// </summary>
        [JsonProperty("pending_request")]
        public AuthorizationPendingRequest PendingRequest { get; set; }

        /// <summary>
        /// History of every time the authorization was approved/denied (whether approved/denied by
        /// you directly or by Stripe based on your <c>spending_controls</c>). If the merchant
        /// changes the authorization by performing an <a
        /// href="https://stripe.com/docs/issuing/purchases/authorizations">incremental
        /// authorization or partial capture</a>, you can look at this field to see the previous
        /// states of the authorization.
        /// </summary>
        [JsonProperty("request_history")]
        public List<AuthorizationRequestHistory> RequestHistory { get; set; }

        /// <summary>
        /// The current status of the authorization in its lifecycle.
        /// One of: <c>closed</c>, <c>pending</c>, or <c>reversed</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// List of <a href="https://stripe.com/docs/api/issuing/transactions">transactions</a>
        /// associated with this authorization.
        /// </summary>
        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }

        [JsonProperty("verification_data")]
        public AuthorizationVerificationData VerificationData { get; set; }

        /// <summary>
        /// What, if any, digital wallet was used for this authorization. One of <c>apple_pay</c>,
        /// <c>google_pay</c>, or <c>samsung_pay</c>.
        /// </summary>
        [JsonProperty("wallet")]
        public string Wallet { get; set; }
    }
}
