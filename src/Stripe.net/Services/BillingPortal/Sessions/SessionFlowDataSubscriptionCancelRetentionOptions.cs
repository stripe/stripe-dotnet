// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionFlowDataSubscriptionCancelRetentionOptions : INestedOptions
    {
        /// <summary>
        /// Configuration when <c>retention.type=coupon_offer</c>.
        /// </summary>
        [JsonProperty("coupon_offer")]
        [STJS.JsonPropertyName("coupon_offer")]
        public SessionFlowDataSubscriptionCancelRetentionCouponOfferOptions CouponOffer { get; set; }

        /// <summary>
        /// Type of retention strategy to use with the customer.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
