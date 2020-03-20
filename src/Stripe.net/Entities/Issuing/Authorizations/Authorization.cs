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
        /// String representing the object’s type. Objects of the same type share the same value.
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

        [Obsolete]
        [JsonProperty("authorized_amount")]
        public long AuthorizedAmount { get; set; }

        [Obsolete]
        [JsonProperty("authorized_currency")]
        public string AuthorizedCurrency { get; set; }

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
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// Three-letter ISO currency code. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [Obsolete]
        [JsonProperty("held_amount")]
        public long HeldAmount { get; set; }

        [Obsolete]
        [JsonProperty("held_currency")]
        public string HeldCurrency { get; set; }

        [Obsolete]
        [JsonProperty("is_held_amount_controllable")]
        public bool IsHeldAmountControllable { get; set; }

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
        public MerchantData MerchantData { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a subscription schedule object.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [Obsolete]
        [JsonProperty("pending_authorized_amount")]
        public long PendingAuthorizedAmount { get; set; }

        [Obsolete]
        [JsonProperty("pending_held_amount")]
        public long PendingHeldAmount { get; set; }

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
        public List<RequestHistory> RequestHistory { get; set; }

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
        public VerificationData VerificationData { get; set; }

        /// <summary>
        /// What, if any, digital wallet was used for this authorization. One of <c>apple_pay</c>,
        /// <c>google_pay</c>, or <c>samsung_pay</c>.
        /// </summary>
        [JsonProperty("wallet")]
        public string Wallet { get; set; }

        [Obsolete("Use Wallet instead")]
        [JsonProperty("wallet_provider")]
        public string WalletProvider { get; set; }
    }
}
