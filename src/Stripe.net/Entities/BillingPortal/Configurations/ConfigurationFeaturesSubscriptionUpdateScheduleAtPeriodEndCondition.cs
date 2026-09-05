// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndCondition : StripeEntity<ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndCondition>
    {
        /// <summary>
        /// The type of condition.
        /// One of: <c>decreasing_item_amount</c>, or <c>shortening_interval</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
