// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The <a href="https://stripe.com/docs/api#issuing_cardholder_object">Cardholder</a>
        /// object with which the card will be associated.
        /// </summary>
        [JsonProperty("cardholder")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cardholder")]
#endif

        public string Cardholder { get; set; }

        /// <summary>
        /// The currency for the card.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif

        public string FinancialAccount { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The personalization design object belonging to this card.
        /// </summary>
        [JsonProperty("personalization_design")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("personalization_design")]
#endif

        public string PersonalizationDesign { get; set; }

        /// <summary>
        /// The desired PIN for this card.
        /// </summary>
        [JsonProperty("pin")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pin")]
#endif

        public CardPinOptions Pin { get; set; }

        /// <summary>
        /// The card this is meant to be a replacement for (if any).
        /// </summary>
        [JsonProperty("replacement_for")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("replacement_for")]
#endif

        public string ReplacementFor { get; set; }

        /// <summary>
        /// If <c>replacement_for</c> is specified, this should indicate why that card is being
        /// replaced.
        /// One of: <c>damaged</c>, <c>expired</c>, <c>lost</c>, or <c>stolen</c>.
        /// </summary>
        [JsonProperty("replacement_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("replacement_reason")]
#endif

        public string ReplacementReason { get; set; }

        /// <summary>
        /// The second line to print on the card. Max length: 24 characters.
        /// </summary>
        [JsonProperty("second_line")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("second_line")]
#endif

        public string SecondLine { get; set; }

        /// <summary>
        /// The address where the card will be shipped.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif

        public CardShippingOptions Shipping { get; set; }

        /// <summary>
        /// Rules that control spending for this card. Refer to our <a
        /// href="https://stripe.com/docs/issuing/controls/spending-controls">documentation</a> for
        /// more details.
        /// </summary>
        [JsonProperty("spending_controls")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("spending_controls")]
#endif

        public CardSpendingControlsOptions SpendingControls { get; set; }

        /// <summary>
        /// Whether authorizations can be approved on this card. May be blocked from activating
        /// cards depending on past-due Cardholder requirements. Defaults to <c>inactive</c>.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }

        /// <summary>
        /// The type of card to issue. Possible values are <c>physical</c> or <c>virtual</c>.
        /// One of: <c>physical</c>, or <c>virtual</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
