// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardUpdateOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// Reason why the <c>status</c> of this card is <c>canceled</c>.
        /// One of: <c>lost</c>, or <c>stolen</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
        [STJS.JsonPropertyName("cancellation_reason")]
        public string CancellationReason { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        [JsonProperty("personalization_design")]
        [STJS.JsonPropertyName("personalization_design")]
        public string PersonalizationDesign { get; set; }

        /// <summary>
        /// The desired new PIN for this card.
        /// </summary>
        [JsonProperty("pin")]
        [STJS.JsonPropertyName("pin")]
        public CardPinOptions Pin { get; set; }

        /// <summary>
        /// Updated shipping information for the card.
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
        /// Dictates whether authorizations can be approved on this card. May be blocked from
        /// activating cards depending on past-due Cardholder requirements. Defaults to
        /// <c>inactive</c>. If this card is being canceled because it was lost or stolen, this
        /// information should be provided as <c>cancellation_reason</c>.
        /// One of: <c>active</c>, <c>canceled</c>, or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
