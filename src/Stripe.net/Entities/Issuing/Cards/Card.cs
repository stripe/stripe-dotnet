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
    /// You can <a href="https://stripe.com/docs/issuing/cards">create physical or virtual
    /// cards</a> that are issued to cardholders.
    /// </summary>
    public class Card : StripeEntity<Card>, IHasId, IHasMetadata, IHasObject
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
        /// The brand of the card.
        /// </summary>
        [JsonProperty("brand")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("brand")]
#endif

        public string Brand { get; set; }

        /// <summary>
        /// The reason why the card was canceled.
        /// One of: <c>design_rejected</c>, <c>lost</c>, or <c>stolen</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancellation_reason")]
#endif

        public string CancellationReason { get; set; }

        /// <summary>
        /// An Issuing <c>Cardholder</c> object represents an individual or business entity who is
        /// <a href="https://stripe.com/docs/issuing">issued</a> cards.
        ///
        /// Related guide: <a href="https://stripe.com/docs/issuing/cards#create-cardholder">How to
        /// create a cardholder</a>.
        /// </summary>
        [JsonProperty("cardholder")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cardholder")]
#endif

        public Cardholder Cardholder { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif

        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Supported currencies are <c>usd</c> in the US, <c>eur</c> in the
        /// EU, and <c>gbp</c> in the UK.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        /// <summary>
        /// The card's CVC. For security reasons, this is only available for virtual cards, and will
        /// be omitted unless you explicitly request it with <a
        /// href="https://stripe.com/docs/api/expanding_objects">the <c>expand</c> parameter</a>.
        /// Additionally, it's only available via the <a
        /// href="https://stripe.com/docs/api/issuing/cards/retrieve">"Retrieve a card"
        /// endpoint</a>, not via "List all cards" or any other endpoint.
        /// </summary>
        [JsonProperty("cvc")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc")]
#endif

        public string Cvc { get; set; }

        /// <summary>
        /// The expiration month of the card.
        /// </summary>
        [JsonProperty("exp_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_month")]
#endif

        public long ExpMonth { get; set; }

        /// <summary>
        /// The expiration year of the card.
        /// </summary>
        [JsonProperty("exp_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_year")]
#endif

        public long ExpYear { get; set; }

        /// <summary>
        /// The financial account this card is attached to.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif

        public string FinancialAccount { get; set; }

        /// <summary>
        /// The last 4 digits of the card number.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif

        public string Last4 { get; set; }

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
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The full unredacted card number. For security reasons, this is only available for
        /// virtual cards, and will be omitted unless you explicitly request it with <a
        /// href="https://stripe.com/docs/api/expanding_objects">the <c>expand</c> parameter</a>.
        /// Additionally, it's only available via the <a
        /// href="https://stripe.com/docs/api/issuing/cards/retrieve">"Retrieve a card"
        /// endpoint</a>, not via "List all cards" or any other endpoint.
        /// </summary>
        [JsonProperty("number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number")]
#endif

        public string Number { get; set; }

        #region Expandable PersonalizationDesign

        /// <summary>
        /// (ID of the PersonalizationDesign)
        /// The personalization design object belonging to this card.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public PersonalizationDesign PersonalizationDesign
        {
            get => this.InternalPersonalizationDesign?.ExpandedObject;
            set => this.InternalPersonalizationDesign = SetExpandableFieldObject(value, this.InternalPersonalizationDesign);
        }

        [JsonProperty("personalization_design")]
        [JsonConverter(typeof(ExpandableFieldConverter<PersonalizationDesign>))]
        internal ExpandableField<PersonalizationDesign> InternalPersonalizationDesign { get; set; }
        #endregion

        #region Expandable ReplacedBy

        /// <summary>
        /// (ID of the Card)
        /// The latest card that replaces this card, if any.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
        /// (ID of the Card)
        /// The card this card replaces, if any.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
        /// The reason why the previous card needed to be replaced.
        /// One of: <c>damaged</c>, <c>expired</c>, <c>lost</c>, or <c>stolen</c>.
        /// </summary>
        [JsonProperty("replacement_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("replacement_reason")]
#endif

        public string ReplacementReason { get; set; }

        /// <summary>
        /// Where and how the card will be shipped.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif

        public CardShipping Shipping { get; set; }

        [JsonProperty("spending_controls")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("spending_controls")]
#endif

        public CardSpendingControls SpendingControls { get; set; }

        /// <summary>
        /// Whether authorizations can be approved on this card. May be blocked from activating
        /// cards depending on past-due Cardholder requirements. Defaults to <c>inactive</c>.
        /// One of: <c>active</c>, <c>canceled</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }

        /// <summary>
        /// The type of the card.
        /// One of: <c>physical</c>, or <c>virtual</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }

        /// <summary>
        /// Information relating to digital wallets (like Apple Pay and Google Pay).
        /// </summary>
        [JsonProperty("wallets")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wallets")]
#endif

        public CardWallets Wallets { get; set; }
    }
}
