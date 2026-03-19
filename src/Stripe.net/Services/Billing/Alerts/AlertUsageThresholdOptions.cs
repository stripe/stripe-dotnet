// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertUsageThresholdOptions : INestedOptions
    {
        /// <summary>
        /// The filters allows limiting the scope of this usage alert. You can only specify up to
        /// one filter at this time.
        /// </summary>
        [JsonProperty("filters")]
        [STJS.JsonPropertyName("filters")]
        public List<AlertUsageThresholdFilterOptions> Filters { get; set; }

        /// <summary>
        /// Defines the threshold value that triggers the alert.
        /// </summary>
        [JsonProperty("gte")]
        [STJS.JsonPropertyName("gte")]
        public long? Gte { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/api/billing/meter">Billing Meter</a> ID whose usage is
        /// monitored.
        /// </summary>
        [JsonProperty("meter")]
        [STJS.JsonPropertyName("meter")]
        public string Meter { get; set; }

        /// <summary>
        /// Defines how the alert will behave.
        /// </summary>
        [JsonProperty("recurrence")]
        [STJS.JsonPropertyName("recurrence")]
        public string Recurrence { get; set; }
    }
}
