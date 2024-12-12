// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class QuotePreviewInvoiceTotalMarginAmount : StripeEntity<QuotePreviewInvoiceTotalMarginAmount>
    {
        /// <summary>
        /// The amount, in cents (or local equivalent), of the reduction in line item amount.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        #region Expandable Margin

        /// <summary>
        /// (ID of the Margin)
        /// The margin that was applied to get this margin amount.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string MarginId
        {
            get => this.InternalMargin?.Id;
            set => this.InternalMargin = SetExpandableFieldId(value, this.InternalMargin);
        }

        /// <summary>
        /// (Expanded)
        /// The margin that was applied to get this margin amount.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Margin Margin
        {
            get => this.InternalMargin?.ExpandedObject;
            set => this.InternalMargin = SetExpandableFieldObject(value, this.InternalMargin);
        }

        [JsonProperty("margin")]
        [JsonConverter(typeof(ExpandableFieldConverter<Margin>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("margin")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Margin>))]
#endif
        internal ExpandableField<Margin> InternalMargin { get; set; }
        #endregion
    }
}
