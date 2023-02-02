// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CreditNoteShippingCost : StripeEntity<CreditNoteShippingCost>
    {
        /// <summary>
        /// Total shipping cost before any taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total tax amount applied due to shipping costs. If no tax was applied, defaults to 0.
        /// </summary>
        [JsonProperty("amount_tax")]
        public long AmountTax { get; set; }

        /// <summary>
        /// Total shipping cost after taxes are applied.
        /// </summary>
        [JsonProperty("amount_total")]
        public long AmountTotal { get; set; }

        #region Expandable ShippingRate

        /// <summary>
        /// (ID of the ShippingRate)
        /// The ID of the ShippingRate for this invoice.
        /// </summary>
        [JsonIgnore]
        public string ShippingRateId
        {
            get => this.InternalShippingRate?.Id;
            set => this.InternalShippingRate = SetExpandableFieldId(value, this.InternalShippingRate);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the ShippingRate for this invoice.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public ShippingRate ShippingRate
        {
            get => this.InternalShippingRate?.ExpandedObject;
            set => this.InternalShippingRate = SetExpandableFieldObject(value, this.InternalShippingRate);
        }

        [JsonProperty("shipping_rate")]
        [JsonConverter(typeof(ExpandableFieldConverter<ShippingRate>))]
        internal ExpandableField<ShippingRate> InternalShippingRate { get; set; }
        #endregion

        /// <summary>
        /// The taxes applied to the shipping rate.
        /// </summary>
        [JsonProperty("taxes")]
        public List<CreditNoteShippingCostTax> Taxes { get; set; }
    }
}
