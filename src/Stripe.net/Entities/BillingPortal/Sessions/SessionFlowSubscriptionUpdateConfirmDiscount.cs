// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionFlowSubscriptionUpdateConfirmDiscount : StripeEntity<SessionFlowSubscriptionUpdateConfirmDiscount>
    {
        /// <summary>
        /// The ID of the coupon to apply to this subscription update.
        /// </summary>
        [JsonProperty("coupon")]
        [STJS.JsonPropertyName("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// The ID of a promotion code to apply to this subscription update.
        /// </summary>
        [JsonProperty("promotion_code")]
        [STJS.JsonPropertyName("promotion_code")]
        public string PromotionCode { get; set; }
    }
}
