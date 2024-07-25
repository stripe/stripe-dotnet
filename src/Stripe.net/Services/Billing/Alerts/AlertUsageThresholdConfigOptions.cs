// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class AlertUsageThresholdConfigOptions : INestedOptions
    {
        /// <summary>
        /// Defines at which value the alert will fire.
        /// </summary>
        [JsonProperty("gte")]
        public long? Gte { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/api/billing/meter">Billing Meter</a> ID whose usage is
        /// monitored.
        /// </summary>
        [JsonProperty("meter")]
        public string Meter { get; set; }

        /// <summary>
        /// Whether the alert should only fire only once, or once per billing cycle.
        /// </summary>
        [JsonProperty("recurrence")]
        public string Recurrence { get; set; }
    }
}
