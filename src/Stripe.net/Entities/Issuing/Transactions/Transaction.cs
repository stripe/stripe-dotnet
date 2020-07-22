namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Transaction : StripeEntity<Transaction>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        /// The transaction amount, which will be reflected in your balance.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable Authorization

        /// <summary>
        /// ID of the <see cref="Authorization"/> associated with this transaction.
        /// </summary>
        [JsonIgnore]
        public string AuthorizationId
        {
            get => this.InternalAuthorization?.Id;
            set => this.InternalAuthorization = SetExpandableFieldId(value, this.InternalAuthorization);
        }

        /// <summary>
        /// (Expanded) The <see cref="Authorization"/> associated with this transaction.
        /// </summary>
        [JsonIgnore]
        public Authorization Authorization
        {
            get => this.InternalAuthorization?.ExpandedObject;
            set => this.InternalAuthorization = SetExpandableFieldObject(value, this.InternalAuthorization);
        }

        [JsonProperty("authorization")]
        [JsonConverter(typeof(ExpandableFieldConverter<Authorization>))]
        internal ExpandableField<Authorization> InternalAuthorization { get; set; }
        #endregion

        #region Expandable BalanceTransaction

        /// <summary>
        /// ID of the <see cref="BalanceTransaction"/> associated with this transaction.
        /// </summary>
        [JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        /// <summary>
        /// (Expanded) The <see cref="BalanceTransaction"/> associated with this transaction.
        /// </summary>
        [JsonIgnore]
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        #region Expandable Card

        /// <summary>
        /// ID of the <see cref="Card"/> associated with this transaction.
        /// </summary>
        [JsonIgnore]
        public string CardId
        {
            get => this.InternalCard?.Id;
            set => this.InternalCard = SetExpandableFieldId(value, this.InternalCard);
        }

        /// <summary>
        /// (Expanded) The <see cref="Card"/> associated with this transaction.
        /// </summary>
        [JsonIgnore]
        public Card Card
        {
            get => this.InternalCard?.ExpandedObject;
            set => this.InternalCard = SetExpandableFieldObject(value, this.InternalCard);
        }

        [JsonProperty("card")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
        internal ExpandableField<Card> InternalCard { get; set; }
        #endregion

        #region Expandable Cardholder

        /// <summary>
        /// ID of the <see cref="Cardholder"/> associated with this transaction.
        /// </summary>
        [JsonIgnore]
        public string CardholderId
        {
            get => this.InternalCardholder?.Id;
            set => this.InternalCardholder = SetExpandableFieldId(value, this.InternalCardholder);
        }

        /// <summary>
        /// (Expanded) The <see cref="Cardholder"/> associated with this transaction.
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
        /// Currency associated with this transaction.
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
        /// The amount that the merchant will receive.
        /// </summary>
        [JsonProperty("merchant_amount")]
        public long MerchantAmount { get; set; }

        /// <summary>
        /// The currency with which the merchant is taking payment.
        /// </summary>
        [JsonProperty("merchant_currency")]
        public string MerchantCurrency { get; set; }

        /// <summary>
        /// Details about the merchant (grocery store, e-commerce website, etc.) where the payment
        /// happened.
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
        /// Additional purchase information that is optionally provided by the merchant.
        /// </summary>
        [JsonProperty("purchase_details")]
        public TransactionPurchaseDetails PurchaseDetails { get; set; }

        /// <summary>
        /// The nature of the transaction. One of <c>capture</c>, or <c>refund</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
