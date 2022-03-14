// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionShippingOption : StripeEntity<SessionShippingOption>
    {
        /// <summary>
        /// A non-negative integer in cents representing how much to charge.
        /// </summary>
        [JsonProperty("shipping_amount")]
        public long ShippingAmount { get; set; }

        #region Expandable ShippingRate

        /// <summary>
        /// (ID of the ShippingRate)
        /// The shipping rate.
        /// </summary>
        [JsonIgnore]
        public string ShippingRateId
        {
            get => this.InternalShippingRate?.Id;
            set => this.InternalShippingRate = SetExpandableFieldId(value, this.InternalShippingRate);
        }

        /// <summary>
        /// (Expanded)
        /// The shipping rate.
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
    }
}
