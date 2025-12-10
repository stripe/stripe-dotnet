// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentCreateActionModifyPricingPlanSubscriptionDetailsOverridesOptions : INestedOptions
    {
        /// <summary>
        /// Override for the partial period behavior.
        /// </summary>
        [JsonProperty("partial_period_behaviors")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("partial_period_behaviors")]
#endif
        public List<IntentCreateActionModifyPricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorOptions> PartialPeriodBehaviors { get; set; }
    }
}
