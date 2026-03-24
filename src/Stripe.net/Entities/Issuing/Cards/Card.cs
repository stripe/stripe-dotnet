// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// You can <a href="https://docs.stripe.com/issuing">create physical or virtual cards</a>
    /// that are issued to cardholders.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Card : StripeEntity<Card>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The brand of the card.
        /// </summary>
        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The reason why the card was canceled.
        /// One of: <c>design_rejected</c>, <c>lost</c>, or <c>stolen</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
        [STJS.JsonPropertyName("cancellation_reason")]
        public string CancellationReason { get; set; }

        /// <summary>
        /// An Issuing <c>Cardholder</c> object represents an individual or business entity who is
        /// <a href="https://docs.stripe.com/issuing">issued</a> cards.
        ///
        /// Related guide: <a
        /// href="https://docs.stripe.com/issuing/cards/virtual/issue-cards#create-cardholder">How
        /// to create a cardholder</a>.
        /// </summary>
        [JsonProperty("cardholder")]
        [STJS.JsonPropertyName("cardholder")]
        public Cardholder Cardholder { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Supported currencies are <c>usd</c> in the US, <c>eur</c> in the
        /// EU, and <c>gbp</c> in the UK.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The card's CVC. For security reasons, this is only available for virtual cards, and will
        /// be omitted unless you explicitly request it with <a
        /// href="https://docs.stripe.com/api/expanding_objects">the <c>expand</c> parameter</a>.
        /// Additionally, it's only available via the <a
        /// href="https://docs.stripe.com/api/issuing/cards/retrieve">"Retrieve a card"
        /// endpoint</a>, not via "List all cards" or any other endpoint.
        /// </summary>
        [JsonProperty("cvc")]
        [STJS.JsonPropertyName("cvc")]
        public string Cvc { get; set; }

        /// <summary>
        /// The expiration month of the card.
        /// </summary>
        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public long ExpMonth { get; set; }

        /// <summary>
        /// The expiration year of the card.
        /// </summary>
        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public long ExpYear { get; set; }

        /// <summary>
        /// The financial account this card is attached to.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// The last 4 digits of the card number.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Stripe’s assessment of whether this card’s details have been compromised. If this
        /// property isn't null, cancel and reissue the card to prevent fraudulent activity risk.
        /// </summary>
        [JsonProperty("latest_fraud_warning")]
        [STJS.JsonPropertyName("latest_fraud_warning")]
        public CardLatestFraudWarning LatestFraudWarning { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The full unredacted card number. For security reasons, this is only available for
        /// virtual cards, and will be omitted unless you explicitly request it with <a
        /// href="https://docs.stripe.com/api/expanding_objects">the <c>expand</c> parameter</a>.
        /// Additionally, it's only available via the <a
        /// href="https://docs.stripe.com/api/issuing/cards/retrieve">"Retrieve a card"
        /// endpoint</a>, not via "List all cards" or any other endpoint.
        /// </summary>
        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public string Number { get; set; }

        #region Expandable PersonalizationDesign

        /// <summary>
        /// (ID of the PersonalizationDesign)
        /// The personalization design object belonging to this card.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string PersonalizationDesignId
        {
            get => this.InternalPersonalizationDesign?.Id;
            set => this.InternalPersonalizationDesign = SetExpandableFieldId(value, this.InternalPersonalizationDesign);
        }

        /// <summary>
        /// (Expanded)
        /// The personalization design object belonging to this card.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public PersonalizationDesign PersonalizationDesign
        {
            get => this.InternalPersonalizationDesign?.ExpandedObject;
            set => this.InternalPersonalizationDesign = SetExpandableFieldObject(value, this.InternalPersonalizationDesign);
        }

        [JsonProperty("personalization_design")]
        [JsonConverter(typeof(ExpandableFieldConverter<PersonalizationDesign>))]
        [STJS.JsonPropertyName("personalization_design")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PersonalizationDesign>))]
        internal ExpandableField<PersonalizationDesign> InternalPersonalizationDesign { get; set; }
        #endregion

        #region Expandable ReplacedBy

        /// <summary>
        /// (ID of the Card)
        /// The latest card that replaces this card, if any.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string ReplacedById
        {
            get => this.InternalReplacedBy?.Id;
            set => this.InternalReplacedBy = SetExpandableFieldId(value, this.InternalReplacedBy);
        }

        /// <summary>
        /// (Expanded)
        /// The latest card that replaces this card, if any.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Card ReplacedBy
        {
            get => this.InternalReplacedBy?.ExpandedObject;
            set => this.InternalReplacedBy = SetExpandableFieldObject(value, this.InternalReplacedBy);
        }

        [JsonProperty("replaced_by")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
        [STJS.JsonPropertyName("replaced_by")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Card>))]
        internal ExpandableField<Card> InternalReplacedBy { get; set; }
        #endregion

        #region Expandable ReplacementFor

        /// <summary>
        /// (ID of the Card)
        /// The card this card replaces, if any.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string ReplacementForId
        {
            get => this.InternalReplacementFor?.Id;
            set => this.InternalReplacementFor = SetExpandableFieldId(value, this.InternalReplacementFor);
        }

        /// <summary>
        /// (Expanded)
        /// The card this card replaces, if any.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Card ReplacementFor
        {
            get => this.InternalReplacementFor?.ExpandedObject;
            set => this.InternalReplacementFor = SetExpandableFieldObject(value, this.InternalReplacementFor);
        }

        [JsonProperty("replacement_for")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
        [STJS.JsonPropertyName("replacement_for")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Card>))]
        internal ExpandableField<Card> InternalReplacementFor { get; set; }
        #endregion

        /// <summary>
        /// The reason why the previous card needed to be replaced.
        /// One of: <c>damaged</c>, <c>expired</c>, <c>lost</c>, or <c>stolen</c>.
        /// </summary>
        [JsonProperty("replacement_reason")]
        [STJS.JsonPropertyName("replacement_reason")]
        public string ReplacementReason { get; set; }

        /// <summary>
        /// Text separate from cardholder name, printed on the card.
        /// </summary>
        [JsonProperty("second_line")]
        [STJS.JsonPropertyName("second_line")]
        public string SecondLine { get; set; }

        /// <summary>
        /// Where and how the card will be shipped.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public CardShipping Shipping { get; set; }

        [JsonProperty("spending_controls")]
        [STJS.JsonPropertyName("spending_controls")]
        public CardSpendingControls SpendingControls { get; set; }

        /// <summary>
        /// Whether authorizations can be approved on this card. May be blocked from activating
        /// cards depending on past-due Cardholder requirements. Defaults to <c>inactive</c>.
        /// One of: <c>active</c>, <c>canceled</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of the card.
        /// One of: <c>physical</c>, or <c>virtual</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Information relating to digital wallets (like Apple Pay and Google Pay).
        /// </summary>
        [JsonProperty("wallets")]
        [STJS.JsonPropertyName("wallets")]
        public CardWallets Wallets { get; set; }
    }
}
