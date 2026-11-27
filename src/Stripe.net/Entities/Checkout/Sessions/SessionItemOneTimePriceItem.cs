// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionItemOneTimePriceItem : StripeEntity<SessionItemOneTimePriceItem>
    {
        /// <summary>
        /// The adjustable quantity settings for this one-time price item.
        /// </summary>
        [JsonProperty("adjustable_quantity")]
        [STJS.JsonPropertyName("adjustable_quantity")]
        public SessionItemOneTimePriceItemAdjustableQuantity AdjustableQuantity { get; set; }

        #region Expandable Price

        /// <summary>
        /// (ID of the Price)
        /// The price for this one-time price item.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string PriceId
        {
            get => this.InternalPrice?.Id;
            set => this.InternalPrice = SetExpandableFieldId(value, this.InternalPrice);
        }

        /// <summary>
        /// (Expanded)
        /// The price for this one-time price item.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Price Price
        {
            get => this.InternalPrice?.ExpandedObject;
            set => this.InternalPrice = SetExpandableFieldObject(value, this.InternalPrice);
        }

        [JsonProperty("price")]
        [JsonConverter(typeof(ExpandableFieldConverter<Price>))]
        [STJS.JsonPropertyName("price")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Price>))]
        internal ExpandableField<Price> InternalPrice { get; set; }
        #endregion

        /// <summary>
        /// The quantity for this one-time price item.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// The <a href="https://docs.stripe.com/api/tax_rates">tax rates</a> which apply to this
        /// line item.
        /// </summary>
        [JsonProperty("tax_rates")]
        [STJS.JsonPropertyName("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
