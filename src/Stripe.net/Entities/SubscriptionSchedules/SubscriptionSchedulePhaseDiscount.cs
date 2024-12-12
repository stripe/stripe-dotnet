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
    public class SubscriptionSchedulePhaseDiscount : StripeEntity<SubscriptionSchedulePhaseDiscount>
    {
        #region Expandable Coupon

        /// <summary>
        /// (ID of the Coupon)
        /// ID of the coupon to create a new discount for.
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
        /// ID of the coupon to create a new discount for.
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

        #region Expandable Discount

        /// <summary>
        /// (ID of the Discount)
        /// ID of an existing discount on the object (or one of its ancestors) to reuse.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string DiscountId
        {
            get => this.InternalDiscount?.Id;
            set => this.InternalDiscount = SetExpandableFieldId(value, this.InternalDiscount);
        }

        /// <summary>
        /// (Expanded)
        /// ID of an existing discount on the object (or one of its ancestors) to reuse.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Discount Discount
        {
            get => this.InternalDiscount?.ExpandedObject;
            set => this.InternalDiscount = SetExpandableFieldObject(value, this.InternalDiscount);
        }

        [JsonProperty("discount")]
        [JsonConverter(typeof(ExpandableFieldConverter<Discount>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Discount>))]
#endif
        internal ExpandableField<Discount> InternalDiscount { get; set; }
        #endregion

        /// <summary>
        /// Details to determine how long the discount should be applied for.
        /// </summary>
        [JsonProperty("discount_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_end")]
#endif
        public SubscriptionSchedulePhaseDiscountDiscountEnd DiscountEnd { get; set; }

        #region Expandable PromotionCode

        /// <summary>
        /// (ID of the PromotionCode)
        /// ID of the promotion code to create a new discount for.
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
        /// ID of the promotion code to create a new discount for.
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
