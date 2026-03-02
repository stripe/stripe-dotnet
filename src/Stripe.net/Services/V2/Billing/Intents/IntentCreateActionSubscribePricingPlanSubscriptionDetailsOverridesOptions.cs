// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateActionSubscribePricingPlanSubscriptionDetailsOverridesOptions : INestedOptions
    {
        /// <summary>
        /// Configurations for behaviors when the action takes effect during the service period.
        /// </summary>
        [JsonProperty("partial_period_behaviors")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("partial_period_behaviors")]
#endif
        public List<IntentCreateActionSubscribePricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorOptions> PartialPeriodBehaviors { get; set; }
    }
}
