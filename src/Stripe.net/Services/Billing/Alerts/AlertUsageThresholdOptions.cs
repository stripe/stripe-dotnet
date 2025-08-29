// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertUsageThresholdOptions : INestedOptions
    {
        /// <summary>
        /// The filters allows limiting the scope of this usage alert. You can only specify up to
        /// one filter at this time.
        /// </summary>
        [JsonProperty("filters")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("filters")]
#endif
        public List<AlertUsageThresholdFilterOptions> Filters { get; set; }

        /// <summary>
        /// Defines at which value the alert will fire.
        /// </summary>
        [JsonProperty("gte")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gte")]
#endif
        public long? Gte { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/api/billing/meter">Billing Meter</a> ID whose usage is
        /// monitored.
        /// </summary>
        [JsonProperty("meter")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("meter")]
#endif
        public string Meter { get; set; }

        /// <summary>
        /// Defines how the alert will behave.
        /// </summary>
        [JsonProperty("recurrence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recurrence")]
#endif
        public string Recurrence { get; set; }
    }
}
