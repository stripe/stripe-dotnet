// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AlertUsageThresholdOptions : INestedOptions
    {
        /// <summary>
        /// The filters allows limiting the scope of this usage alert. You can only specify up to
        /// one filter at this time.
        /// </summary>
        [JsonProperty("filters")]
        public List<AlertUsageThresholdFilterOptions> Filters { get; set; }

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
