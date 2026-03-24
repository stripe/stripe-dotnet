// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertTriggeredGroupBy : StripeEntity<AlertTriggeredGroupBy>
    {
        /// <summary>
        /// The billing cadence ID, populated when type is <c>billing_cadence</c>.
        /// </summary>
        [JsonProperty("billing_cadence")]
        [STJS.JsonPropertyName("billing_cadence")]
        public string BillingCadence { get; set; }

        /// <summary>
        /// The pricing plan subscription ID, populated when type is
        /// <c>pricing_plan_subscription</c>.
        /// </summary>
        [JsonProperty("pricing_plan_subscription")]
        [STJS.JsonPropertyName("pricing_plan_subscription")]
        public string PricingPlanSubscription { get; set; }

        /// <summary>
        /// The type of grouping used for this alert notification.
        /// One of: <c>billing_cadence</c>, or <c>pricing_plan_subscription</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
