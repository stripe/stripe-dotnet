namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The <a href="https://stripe.com/docs/api#issuing_cardholder_object">Cardholder</a>
        /// object with which the card will be associated.
        /// </summary>
        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }

        /// <summary>
        /// The currency for the card. This currently must be <c>usd</c>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The card this is meant to be a replacement for (if any).
        /// </summary>
        [JsonProperty("replacement_for")]
        public string ReplacementFor { get; set; }

        /// <summary>
        /// If <c>replacement_for</c> is specified, this should indicate why that card is being
        /// replaced.
        /// One of: <c>damaged</c>, <c>expired</c>, <c>lost</c>, or <c>stolen</c>.
        /// </summary>
        [JsonProperty("replacement_reason")]
        public string ReplacementReason { get; set; }

        /// <summary>
        /// The address where the card will be shipped.
        /// </summary>
        [JsonProperty("shipping")]
        public CardShippingOptions Shipping { get; set; }

        /// <summary>
        /// Rules that control spending for this card. Refer to our <a
        /// href="https://stripe.com/docs/issuing/controls/spending-controls">documentation</a> for
        /// more details.
        /// </summary>
        [JsonProperty("spending_controls")]
        public CardSpendingControlsOptions SpendingControls { get; set; }

        /// <summary>
        /// Whether authorizations can be approved on this card. Defaults to <c>inactive</c>.
        /// One of: <c>active</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of card to issue. Possible values are <c>physical</c> or <c>virtual</c>.
        /// One of: <c>physical</c>, or <c>virtual</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
