// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PricingPlanSubscriptionComponentsComponent : StripeEntity<PricingPlanSubscriptionComponentsComponent>
    {
        /// <summary>
        /// The Pricing Plan Component associated with this component subscription.
        /// </summary>
        [JsonProperty("pricing_plan_component")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_component")]
#endif
        public string PricingPlanComponent { get; set; }

        /// <summary>
        /// The type of subscription.
        /// One of: <c>license_fee_subscription</c>, or <c>rate_card_subscription</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The ID of the License Fee Subscription.
        /// </summary>
        [JsonProperty("license_fee_subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("license_fee_subscription")]
#endif
        public string LicenseFeeSubscription { get; set; }

        /// <summary>
        /// The ID of the Rate Card Subscription.
        /// </summary>
        [JsonProperty("rate_card_subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_subscription")]
#endif
        public string RateCardSubscription { get; set; }
    }
}
