// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndOptions : INestedOptions
    {
        /// <summary>
        /// List of conditions. When any condition is true, the update will be scheduled at the end
        /// of the current period.
        /// </summary>
        [JsonProperty("conditions")]
        public List<ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditionOptions> Conditions { get; set; }
    }
}
