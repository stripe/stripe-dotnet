// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuoteFromQuote : StripeEntity<QuoteFromQuote>
    {
        /// <summary>
        /// Whether this quote is a revision of a different quote.
        /// </summary>
        [JsonProperty("is_revision")]
        [STJS.JsonPropertyName("is_revision")]
        public bool IsRevision { get; set; }

        #region Expandable Quote

        /// <summary>
        /// (ID of the Quote)
        /// The quote that was cloned.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string QuoteId
        {
            get => this.InternalQuote?.Id;
            set => this.InternalQuote = SetExpandableFieldId(value, this.InternalQuote);
        }

        /// <summary>
        /// (Expanded)
        /// The quote that was cloned.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Quote Quote
        {
            get => this.InternalQuote?.ExpandedObject;
            set => this.InternalQuote = SetExpandableFieldObject(value, this.InternalQuote);
        }

        [JsonProperty("quote")]
        [JsonConverter(typeof(ExpandableFieldConverter<Quote>))]
        [STJS.JsonPropertyName("quote")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Quote>))]
        internal ExpandableField<Quote> InternalQuote { get; set; }
        #endregion
    }
}
