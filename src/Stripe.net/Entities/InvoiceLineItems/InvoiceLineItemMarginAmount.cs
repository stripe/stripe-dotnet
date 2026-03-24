// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceLineItemMarginAmount : StripeEntity<InvoiceLineItemMarginAmount>
    {
        /// <summary>
        /// The amount, in cents (or local equivalent), of the reduction in line item amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        #region Expandable Margin

        /// <summary>
        /// (ID of the Margin)
        /// The margin that was applied to get this margin amount.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
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
        [STJS.JsonIgnore]
        public Margin Margin
        {
            get => this.InternalMargin?.ExpandedObject;
            set => this.InternalMargin = SetExpandableFieldObject(value, this.InternalMargin);
        }

        [JsonProperty("margin")]
        [JsonConverter(typeof(ExpandableFieldConverter<Margin>))]
        [STJS.JsonPropertyName("margin")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Margin>))]
        internal ExpandableField<Margin> InternalMargin { get; set; }
        #endregion
    }
}
