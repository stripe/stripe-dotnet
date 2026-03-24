// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertSpendThresholdFiltersOptions : INestedOptions
    {
        /// <summary>
        /// Filter by billable item IDs. Maximum of 20 billable items.
        /// </summary>
        [JsonProperty("billable_items")]
        [STJS.JsonPropertyName("billable_items")]
        public List<string> BillableItems { get; set; }

        /// <summary>
        /// Filter by billing cadence ID.
        /// </summary>
        [JsonProperty("billing_cadence")]
        [STJS.JsonPropertyName("billing_cadence")]
        public string BillingCadence { get; set; }

        /// <summary>
        /// Filter by pricing plan ID.
        /// </summary>
        [JsonProperty("pricing_plan")]
        [STJS.JsonPropertyName("pricing_plan")]
        public string PricingPlan { get; set; }

        /// <summary>
        /// Filter by pricing plan subscription ID.
        /// </summary>
        [JsonProperty("pricing_plan_subscription")]
        [STJS.JsonPropertyName("pricing_plan_subscription")]
        public string PricingPlanSubscription { get; set; }
    }
}
