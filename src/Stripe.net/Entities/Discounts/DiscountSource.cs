// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DiscountSource : StripeEntity<DiscountSource>
    {
        #region Expandable Coupon

        /// <summary>
        /// (ID of the Coupon)
        /// The coupon that was redeemed to create this discount.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string CouponId
        {
            get => this.InternalCoupon?.Id;
            set => this.InternalCoupon = SetExpandableFieldId(value, this.InternalCoupon);
        }

        /// <summary>
        /// (Expanded)
        /// The coupon that was redeemed to create this discount.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Coupon Coupon
        {
            get => this.InternalCoupon?.ExpandedObject;
            set => this.InternalCoupon = SetExpandableFieldObject(value, this.InternalCoupon);
        }

        [JsonProperty("coupon")]
        [JsonConverter(typeof(ExpandableFieldConverter<Coupon>))]
        [STJS.JsonPropertyName("coupon")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Coupon>))]
        internal ExpandableField<Coupon> InternalCoupon { get; set; }
        #endregion

        /// <summary>
        /// The source type of the discount.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
