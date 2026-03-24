// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionFlowSubscriptionCancelRetentionCouponOffer : StripeEntity<SessionFlowSubscriptionCancelRetentionCouponOffer>
    {
        /// <summary>
        /// The ID of the coupon to be offered.
        /// </summary>
        [JsonProperty("coupon")]
        [STJS.JsonPropertyName("coupon")]
        public string Coupon { get; set; }
    }
}
