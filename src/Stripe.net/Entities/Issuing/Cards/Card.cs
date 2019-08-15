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
        /// String representing the object’s type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Spending rules that give you some control over how your cards can be used.
        /// </summary>
        [JsonProperty("authorization_controls")]
        public AuthorizationControls AuthorizationControls { get; set; }

        /// <summary>
        /// The brand of the card.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The Cardholder object to which the card belongs.
        /// </summary>
        [JsonProperty("cardholder")]
        public Cardholder Cardholder { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

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
        /// A set of key/value pairs that you can attach to a subscription schedule object.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The name of the cardholder, printed on the card.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Metadata about the PIN on the card.
        /// </summary>
        [JsonProperty("pin")]
        public CardPin Pin { get; set; }

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
        /// <c>damage</c>, <c>expiration</c>, <c>loss</c>, or <c>theft</c>.
        /// </summary>
        [JsonProperty("replacement_reason")]
        public string ReplacementReason { get; set; }

        /// <summary>
        /// Where and how the card will be shipped.
        /// </summary>
        [JsonProperty("shipping")]
        public CardShipping Shipping { get; set; }

        /// <summary>
        /// One of <c>active</c>, <c>inactive</c>, <c>canceled</c>, <c>lost</c>, <c>stolen</c>, or
        /// <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// One of <c>virtual</c> or p<c>hysical</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [Obsolete("This property has never been filled and should be ignored.")]
        [JsonProperty("billing")]
        public Billing Billing { get; set; }
    }
}
