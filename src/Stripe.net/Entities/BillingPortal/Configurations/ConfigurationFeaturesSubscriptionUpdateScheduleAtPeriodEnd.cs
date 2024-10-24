// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd : StripeEntity<ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd>
    {
        /// <summary>
        /// List of conditions. When any condition is true, an update will be scheduled at the end
        /// of the current period.
        /// </summary>
        [JsonProperty("conditions")]
        public List<ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndCondition> Conditions { get; set; }
    }
}
