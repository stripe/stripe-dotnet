// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndCondition : StripeEntity<ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndCondition>
    {
        /// <summary>
        /// The type of condition.
        /// One of: <c>decreasing_item_amount</c>, or <c>shortening_interval</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
