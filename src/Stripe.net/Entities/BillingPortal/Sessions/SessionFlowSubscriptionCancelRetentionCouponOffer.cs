// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionFlowSubscriptionCancelRetentionCouponOffer : StripeEntity<SessionFlowSubscriptionCancelRetentionCouponOffer>
    {
        /// <summary>
        /// The ID of the coupon to be offered.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }
    }
}
