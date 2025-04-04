// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class SessionDiscount : StripeEntity<SessionDiscount>
    {
        #region Expandable Coupon

        /// <summary>
        /// (ID of the Coupon)
        /// Coupon attached to the Checkout Session.
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
        /// Coupon attached to the Checkout Session.
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

        #region Expandable PromotionCode

        /// <summary>
        /// (ID of the PromotionCode)
        /// Promotion code attached to the Checkout Session.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string PromotionCodeId
        {
            get => this.InternalPromotionCode?.Id;
            set => this.InternalPromotionCode = SetExpandableFieldId(value, this.InternalPromotionCode);
        }

        /// <summary>
        /// (Expanded)
        /// Promotion code attached to the Checkout Session.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PromotionCode PromotionCode
        {
            get => this.InternalPromotionCode?.ExpandedObject;
            set => this.InternalPromotionCode = SetExpandableFieldObject(value, this.InternalPromotionCode);
        }

        [JsonProperty("promotion_code")]
        [JsonConverter(typeof(ExpandableFieldConverter<PromotionCode>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promotion_code")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PromotionCode>))]
#endif
        internal ExpandableField<PromotionCode> InternalPromotionCode { get; set; }
        #endregion
    }
}
