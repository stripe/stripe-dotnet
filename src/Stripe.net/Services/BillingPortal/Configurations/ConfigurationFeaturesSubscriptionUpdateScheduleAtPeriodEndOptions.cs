// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndOptions : INestedOptions
    {
        /// <summary>
        /// List of conditions. When any condition is true, the update will be scheduled at the end
        /// of the current period.
        /// </summary>
        [JsonProperty("conditions")]
        [STJS.JsonPropertyName("conditions")]
        public List<ConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEndConditionOptions> Conditions { get; set; }
    }
}
