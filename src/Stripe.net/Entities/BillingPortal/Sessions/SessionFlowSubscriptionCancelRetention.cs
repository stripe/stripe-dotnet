// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionFlowSubscriptionCancelRetention : StripeEntity<SessionFlowSubscriptionCancelRetention>
    {
        /// <summary>
        /// Configuration when <c>retention.type=coupon_offer</c>.
        /// </summary>
        [JsonProperty("coupon_offer")]
        public SessionFlowSubscriptionCancelRetentionCouponOffer CouponOffer { get; set; }

        /// <summary>
        /// Type of retention strategy that will be used.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
