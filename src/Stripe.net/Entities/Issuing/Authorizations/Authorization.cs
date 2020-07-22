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
        /// The total amount in the card's currency that was authorized or rejected.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Whether the authorization has been approved.
        /// </summary>
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        /// <summary>
        /// How the card details were provided. The possible values are <c>keyed_in</c>,
        /// <c>swipe</c>, <c>chip</c>, <c>contactless</c> or <c>online</c>.
        /// </summary>
        [JsonProperty("authorization_method")]
        public string AuthorizationMethod { get; set; }

        /// <summary>
        /// List of balance transactions associated with this authorization.
        /// </summary>
        [JsonProperty("balance_transactions")]
        public List<BalanceTransaction> BalanceTransactions { get; set; }

        /// <summary>
        /// Card associated with this authorization.
        /// </summary>
        [JsonProperty("card")]
        public Card Card { get; set; }

        #region Expandable Cardholder

        /// <summary>
        /// ID of the cardholder to whom this authorization belongs.
        /// </summary>
        [JsonIgnore]
        public string CardholderId
        {
            get => this.InternalCardholder?.Id;
            set => this.InternalCardholder = SetExpandableFieldId(value, this.InternalCardholder);
        }

        /// <summary>
        /// The cardholder to whom this authorization belongs.
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
        public DateTime Created { get; set; }

        /// <summary>
        /// Three-letter ISO currency code. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value
        /// <c>false</c> if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The total amount that was authorized or rejected in the local
        /// <see cref="MerchantCurrency"/>.
        /// </summary>
        [JsonProperty("merchant_amount")]
        public long MerchantAmount { get; set; }

        /// <summary>
        /// The currency of the held amount. This will always be the card currency.
        /// </summary>
        [JsonProperty("merchant_currency")]
        public string MerchantCurrency { get; set; }

        /// <summary>
        /// Details about the merchant (grocery store, e-commerce website, etc.) where the card
        /// authorization happened.
        /// </summary>
        [JsonProperty("merchant_data")]
        public AuthorizationMerchantData MerchantData { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format. Individual keys can be
        /// unset by posting an empty value to them. All keys can be unset by posting an empty
        /// value to metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The pending authorization request. This field will only be non-null during an
        /// <see cref="Events.IssuingAuthorizationRequest" /> webhook.
        /// </summary>
        [JsonProperty("pending_request")]
        public AuthorizationPendingRequest PendingRequest { get; set; }

        /// <summary>
        /// History of every time the authorization was approved/denied (whether approved/denied by
        /// you directly, or by Stripe based on your authorization controls). If the merchant
        /// changes the authorization by performing an incremental authorization or partial capture,
        /// you can look at the request history to see the previous states of the authorization.
        /// </summary>
        [JsonProperty("request_history")]
        public List<AuthorizationRequestHistory> RequestHistory { get; set; }

        /// <summary>
        /// The current status of the authorization in its lifecycle. One of <c>pending</c>,
        /// <c>closed</c>, or <c>reversed</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// List of transactions associated with this authorization.
        /// </summary>
        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Verifications that Stripe performed on information that the cardholder provided to the
        /// merchant.
        /// </summary>
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
