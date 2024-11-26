// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Reason why the <c>status</c> of this card is <c>canceled</c>.
        /// One of: <c>lost</c>, or <c>stolen</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancellation_reason")]
#endif
        public string CancellationReason { get; set; }

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

        [JsonProperty("personalization_design")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("personalization_design")]
#endif
        public string PersonalizationDesign { get; set; }

        /// <summary>
        /// The desired new PIN for this card.
        /// </summary>
        [JsonProperty("pin")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pin")]
#endif
        public CardPinOptions Pin { get; set; }

        /// <summary>
        /// Updated shipping information for the card.
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
        /// Dictates whether authorizations can be approved on this card. May be blocked from
        /// activating cards depending on past-due Cardholder requirements. Defaults to
        /// <c>inactive</c>. If this card is being canceled because it was lost or stolen, this
        /// information should be provided as <c>cancellation_reason</c>.
        /// One of: <c>active</c>, <c>canceled</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
