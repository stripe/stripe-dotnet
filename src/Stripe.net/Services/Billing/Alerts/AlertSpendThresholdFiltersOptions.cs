// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertSpendThresholdFiltersOptions : INestedOptions
    {
        /// <summary>
        /// Filter by billable item IDs. Maximum of 20 billable items.
        /// </summary>
        [JsonProperty("billable_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billable_items")]
#endif
        public List<string> BillableItems { get; set; }

        /// <summary>
        /// Filter by billing cadence ID.
        /// </summary>
        [JsonProperty("billing_cadence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cadence")]
#endif
        public string BillingCadence { get; set; }

        /// <summary>
        /// Filter by pricing plan ID.
        /// </summary>
        [JsonProperty("pricing_plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan")]
#endif
        public string PricingPlan { get; set; }

        /// <summary>
        /// Filter by pricing plan subscription ID.
        /// </summary>
        [JsonProperty("pricing_plan_subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_subscription")]
#endif
        public string PricingPlanSubscription { get; set; }
    }
}
