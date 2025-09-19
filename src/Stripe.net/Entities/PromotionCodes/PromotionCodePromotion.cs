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

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string CouponId
        {
            get => this.InternalCoupon?.Id;
            set => this.InternalCoupon = SetExpandableFieldId(value, this.InternalCoupon);
        }

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

        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
