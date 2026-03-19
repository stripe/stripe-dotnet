// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanSubscriptionComponentsComponent : StripeEntity<PricingPlanSubscriptionComponentsComponent>
    {
        /// <summary>
        /// The Pricing Plan Component associated with this component subscription.
        /// </summary>
        [JsonProperty("pricing_plan_component")]
        [STJS.JsonPropertyName("pricing_plan_component")]
        public string PricingPlanComponent { get; set; }

        /// <summary>
        /// The type of subscription.
        /// One of: <c>license_fee_subscription</c>, or <c>rate_card_subscription</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The ID of the License Fee Subscription.
        /// </summary>
        [JsonProperty("license_fee_subscription")]
        [STJS.JsonPropertyName("license_fee_subscription")]
        public string LicenseFeeSubscription { get; set; }

        /// <summary>
        /// The ID of the Rate Card Subscription.
        /// </summary>
        [JsonProperty("rate_card_subscription")]
        [STJS.JsonPropertyName("rate_card_subscription")]
        public string RateCardSubscription { get; set; }
    }
}
