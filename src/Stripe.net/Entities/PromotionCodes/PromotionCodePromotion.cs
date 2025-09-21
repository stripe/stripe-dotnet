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
    public class PromotionCodePromotion : StripeEntity<PromotionCodePromotion>
    {
        #region Expandable Coupon

        /// <summary>
        /// (ID of the Coupon)
        /// If promotion type is 'coupon', the coupon for this promotion.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string CouponId
        {
            get => this.InternalCoupon?.Id;
            set => this.InternalCoupon = SetExpandableFieldId(value, this.InternalCoupon);
        }

        /// <summary>
        /// (Expanded)
        /// If promotion type is 'coupon', the coupon for this promotion.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Coupon Coupon
        {
            get => this.InternalCoupon?.ExpandedObject;
            set => this.InternalCoupon = SetExpandableFieldObject(value, this.InternalCoupon);
        }

        [JsonProperty("coupon")]
        [JsonConverter(typeof(ExpandableFieldConverter<Coupon>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Coupon>))]
#endif
        internal ExpandableField<Coupon> InternalCoupon { get; set; }
        #endregion

        /// <summary>
        /// The type of promotion.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
