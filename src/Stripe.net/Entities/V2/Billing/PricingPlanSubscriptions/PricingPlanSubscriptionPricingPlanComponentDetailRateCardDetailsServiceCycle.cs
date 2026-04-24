// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanSubscriptionPricingPlanComponentDetailRateCardDetailsServiceCycle : StripeEntity<PricingPlanSubscriptionPricingPlanComponentDetailRateCardDetailsServiceCycle>
    {
        /// <summary>
        /// The interval for assessing service.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
        [STJS.JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The length of the interval for assessing service. For example, set this to 3 and
        /// <c>interval</c> to <c>"month"</c> to specify quarterly service.
        /// </summary>
        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long IntervalCount { get; set; }
    }
}
