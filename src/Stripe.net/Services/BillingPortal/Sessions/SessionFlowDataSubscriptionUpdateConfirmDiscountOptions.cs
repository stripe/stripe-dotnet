// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionFlowDataSubscriptionUpdateConfirmDiscountOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the coupon to apply to this subscription update.
        /// </summary>
        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// The ID of a promotion code to apply to this subscription update.
        /// </summary>
        [JsonProperty("promotion_code")]
        public string PromotionCode { get; set; }
    }
}
