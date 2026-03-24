// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionFlowSubscriptionCancelRetention : StripeEntity<SessionFlowSubscriptionCancelRetention>
    {
        /// <summary>
        /// Configuration when <c>retention.type=coupon_offer</c>.
        /// </summary>
        [JsonProperty("coupon_offer")]
        [STJS.JsonPropertyName("coupon_offer")]
        public SessionFlowSubscriptionCancelRetentionCouponOffer CouponOffer { get; set; }

        /// <summary>
        /// Type of retention strategy that will be used.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
