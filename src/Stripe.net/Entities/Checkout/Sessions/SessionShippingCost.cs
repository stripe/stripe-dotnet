// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class SessionShippingCost : StripeEntity<SessionShippingCost>
    {
        /// <summary>
        /// Total shipping cost before any discounts or taxes are applied.
        /// </summary>
        [JsonProperty("amount_subtotal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_subtotal")]
#endif
        public long AmountSubtotal { get; set; }

        /// <summary>
        /// Total tax amount applied due to shipping costs. If no tax was applied, defaults to 0.
        /// </summary>
        [JsonProperty("amount_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_tax")]
#endif
        public long AmountTax { get; set; }

        /// <summary>
        /// Total shipping cost after discounts and taxes are applied.
        /// </summary>
        [JsonProperty("amount_total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_total")]
#endif
        public long AmountTotal { get; set; }

        #region Expandable ShippingRate

        /// <summary>
        /// (ID of the ShippingRate)
        /// The ID of the ShippingRate for this order.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ShippingRateId
        {
            get => this.InternalShippingRate?.Id;
            set => this.InternalShippingRate = SetExpandableFieldId(value, this.InternalShippingRate);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the ShippingRate for this order.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public ShippingRate ShippingRate
        {
            get => this.InternalShippingRate?.ExpandedObject;
            set => this.InternalShippingRate = SetExpandableFieldObject(value, this.InternalShippingRate);
        }

        [JsonProperty("shipping_rate")]
        [JsonConverter(typeof(ExpandableFieldConverter<ShippingRate>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_rate")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<ShippingRate>))]
#endif
        internal ExpandableField<ShippingRate> InternalShippingRate { get; set; }
        #endregion

        /// <summary>
        /// The taxes applied to the shipping rate.
        /// </summary>
        [JsonProperty("taxes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("taxes")]
#endif
        public List<SessionShippingCostTax> Taxes { get; set; }
    }
}
