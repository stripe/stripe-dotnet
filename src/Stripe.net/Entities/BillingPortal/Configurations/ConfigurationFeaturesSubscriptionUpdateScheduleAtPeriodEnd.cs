// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd : StripeEntity<ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd>
    {
        /// <summary>
        /// List of conditions. When any condition is true, an update will be scheduled at the end
        /// of the current period.
        /// </summary>
        [JsonProperty("conditions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("conditions")]
#endif

        public List<ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndCondition> Conditions { get; set; }
    }
}
