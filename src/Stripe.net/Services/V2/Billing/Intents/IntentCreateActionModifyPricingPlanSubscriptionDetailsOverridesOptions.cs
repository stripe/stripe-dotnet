// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateActionModifyPricingPlanSubscriptionDetailsOverridesOptions : INestedOptions
    {
        /// <summary>
        /// Configurations for behaviors when the action takes effect during the service period.
        /// </summary>
        [JsonProperty("partial_period_behaviors")]
        [STJS.JsonPropertyName("partial_period_behaviors")]
        public List<IntentCreateActionModifyPricingPlanSubscriptionDetailsOverridesPartialPeriodBehaviorOptions> PartialPeriodBehaviors { get; set; }
    }
}
