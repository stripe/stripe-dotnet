// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The <a href="https://docs.stripe.com/api#issuing_cardholder_object">Cardholder</a>
        /// object with which the card will be associated.
        /// </summary>
        [JsonProperty("cardholder")]
        [STJS.JsonPropertyName("cardholder")]
        public string Cardholder { get; set; }

        /// <summary>
        /// The currency for the card.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The desired expiration month (1-12) for this card if <a
        /// href="https://stripe.com/issuing/cards/virtual/issue-cards?testing-method=with-code#exp-dates">specifying
        /// a custom expiration date</a>.
        /// </summary>
        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// The desired 4-digit expiration year for this card if <a
        /// href="https://stripe.com/issuing/cards/virtual/issue-cards?testing-method=with-code#exp-dates">specifying
        /// a custom expiration date</a>.
        /// </summary>
        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// The new financial account ID the card will be associated with. This field allows a card
        /// to be reassigned to a different financial account.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Rules that control the lifecycle of this card, such as automatic cancellation. Refer to
        /// our <a href="https://stripe.com/issuing/controls/lifecycle-controls">documentation</a>
        /// for more details.
        /// </summary>
        [JsonProperty("lifecycle_controls")]
        [STJS.JsonPropertyName("lifecycle_controls")]
        public CardLifecycleControlsOptions LifecycleControls { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The personalization design object belonging to this card.
        /// </summary>
        [JsonProperty("personalization_design")]
        [STJS.JsonPropertyName("personalization_design")]
        public string PersonalizationDesign { get; set; }

        /// <summary>
        /// The desired PIN for this card.
        /// </summary>
        [JsonProperty("pin")]
        [STJS.JsonPropertyName("pin")]
        public CardPinOptions Pin { get; set; }

        /// <summary>
        /// The card this is meant to be a replacement for (if any).
        /// </summary>
        [JsonProperty("replacement_for")]
        [STJS.JsonPropertyName("replacement_for")]
        public string ReplacementFor { get; set; }

        /// <summary>
        /// If <c>replacement_for</c> is specified, this should indicate why that card is being
        /// replaced.
        /// One of: <c>damaged</c>, <c>expired</c>, <c>lost</c>, or <c>stolen</c>.
        /// </summary>
        [JsonProperty("replacement_reason")]
        [STJS.JsonPropertyName("replacement_reason")]
        public string ReplacementReason { get; set; }

        /// <summary>
        /// The second line to print on the card. Max length: 24 characters.
        /// </summary>
        [JsonProperty("second_line")]
        [STJS.JsonPropertyName("second_line")]
        public string SecondLine { get; set; }

        /// <summary>
        /// The address where the card will be shipped.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public CardShippingOptions Shipping { get; set; }

        /// <summary>
        /// Rules that control spending for this card. Refer to our <a
        /// href="https://docs.stripe.com/issuing/controls/spending-controls">documentation</a> for
        /// more details.
        /// </summary>
        [JsonProperty("spending_controls")]
        [STJS.JsonPropertyName("spending_controls")]
        public CardSpendingControlsOptions SpendingControls { get; set; }

        /// <summary>
        /// Whether authorizations can be approved on this card. May be blocked from activating
        /// cards depending on past-due Cardholder requirements. Defaults to <c>inactive</c>.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of card to issue. Possible values are <c>physical</c> or <c>virtual</c>.
        /// One of: <c>physical</c>, or <c>virtual</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
