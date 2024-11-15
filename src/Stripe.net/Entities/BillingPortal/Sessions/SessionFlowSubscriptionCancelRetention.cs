// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionFlowSubscriptionCancelRetention : StripeEntity<SessionFlowSubscriptionCancelRetention>
    {
        /// <summary>
        /// Configuration when <c>retention.type=coupon_offer</c>.
        /// </summary>
        [JsonProperty("coupon_offer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon_offer")]
#endif

        public SessionFlowSubscriptionCancelRetentionCouponOffer CouponOffer { get; set; }

        /// <summary>
        /// Type of retention strategy that will be used.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
