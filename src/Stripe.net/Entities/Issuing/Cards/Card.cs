namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Card : StripeEntity<Card>, IHasId, IHasMetadata, IHasObject
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
        /// The brand of the card.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The reason why the card was canceled. One of <c>lost</c> or <c>stolen</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }

        /// <summary>
        /// The Cardholder object to which the card belongs.
        /// </summary>
        [JsonProperty("cardholder")]
        public Cardholder Cardholder { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The card's CVC. For security reasons, this is only available for virtual cards, and will
        /// be omitted unless you explicitly expand it in the request.
        /// </summary>
        [JsonProperty("cvc")]
        public string Cvc { get; set; }

        /// <summary>
        /// The expiration month of the card.
        /// </summary>
        [JsonProperty("exp_month")]
        public long ExpMonth { get; set; }

        /// <summary>
        /// The expiration year of the card.
        /// </summary>
        [JsonProperty("exp_year")]
        public long ExpYear { get; set; }

        /// <summary>
        /// The last 4 digits of the card number.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value
        /// <c>false</c> if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format. Individual keys can be
        /// unset by posting an empty value to them. All keys can be unset by posting an empty
        /// value to metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The full unredacted card number. For security reasons, this is only available for
        /// virtual cards, and will be omitted unless you explicitly expand it in the request.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        #region Expandable ReplacedBy

        /// <summary>
        /// ID of the latest <see cref="Card"/> that replaces this card, if any.
        /// </summary>
        [JsonIgnore]
        public string ReplacedById
        {
            get => this.InternalReplacedBy?.Id;
            set => this.InternalReplacedBy = SetExpandableFieldId(value, this.InternalReplacedBy);
        }

        /// <summary>
        /// (Expanded) The latest <see cref="Card"/> that replaces this card, if any.
        /// </summary>
        [JsonIgnore]
        public Card ReplacedBy
        {
            get => this.InternalReplacedBy?.ExpandedObject;
            set => this.InternalReplacedBy = SetExpandableFieldObject(value, this.InternalReplacedBy);
        }

        [JsonProperty("replaced_by")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
        internal ExpandableField<Card> InternalReplacedBy { get; set; }
        #endregion

        #region Expandable ReplacementFor

        /// <summary>
        /// ID of the <see cref="Card"/> that this card replaces.
        /// </summary>
        [JsonIgnore]
        public string ReplacementForId
        {
            get => this.InternalReplacementFor?.Id;
            set => this.InternalReplacementFor = SetExpandableFieldId(value, this.InternalReplacementFor);
        }

        /// <summary>
        /// (Expanded) The <see cref="Card"/> that this card replaces.
        /// </summary>
        [JsonIgnore]
        public Card ReplacementFor
        {
            get => this.InternalReplacementFor?.ExpandedObject;
            set => this.InternalReplacementFor = SetExpandableFieldObject(value, this.InternalReplacementFor);
        }

        [JsonProperty("replacement_for")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
        internal ExpandableField<Card> InternalReplacementFor { get; set; }
        #endregion

        /// <summary>
        /// Why the card that this card replaces (if any) needed to be replaced. One of
        /// <c>damaged</c>, <c>expired</c>, <c>lost</c>, or <c>stolen</c>.
        /// </summary>
        [JsonProperty("replacement_reason")]
        public string ReplacementReason { get; set; }

        /// <summary>
        /// Where and how the card will be shipped.
        /// </summary>
        [JsonProperty("shipping")]
        public CardShipping Shipping { get; set; }

        /// <summary>
        /// Spending rules that give you some control over how this card can be used.
        /// </summary>
        [JsonProperty("spending_controls")]
        public CardSpendingControls SpendingControls { get; set; }

        /// <summary>
        /// One of <c>active</c>, <c>canceled</c>, <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// One of <c>virtual</c> or p<c>hysical</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
