// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndCondition : StripeEntity<ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndCondition>
    {
        /// <summary>
        /// The type of condition.
        /// One of: <c>decreasing_item_amount</c>, or <c>shortening_interval</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
