// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteFromQuote : StripeEntity<QuoteFromQuote>
    {
        /// <summary>
        /// Whether this quote is a revision of a different quote.
        /// </summary>
        [JsonProperty("is_revision")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_revision")]
#endif

        public bool IsRevision { get; set; }

        #region Expandable Quote

        /// <summary>
        /// (ID of the Quote)
        /// The quote that was cloned.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif

        public Quote Quote
        {
            get => this.InternalQuote?.ExpandedObject;
            set => this.InternalQuote = SetExpandableFieldObject(value, this.InternalQuote);
        }

        [JsonProperty("quote")]
        [JsonConverter(typeof(ExpandableFieldConverter<Quote>))]
        internal ExpandableField<Quote> InternalQuote { get; set; }
        #endregion
    }
}
