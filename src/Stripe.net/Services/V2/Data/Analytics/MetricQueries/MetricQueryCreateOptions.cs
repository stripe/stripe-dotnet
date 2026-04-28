// File generated from our OpenAPI spec
namespace Stripe.V2.Data.Analytics
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class MetricQueryCreateOptions : BaseOptions
    {
        /// <summary>
        /// Which currency to return monetary metric results in.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Timestamp denoting the end of the time range to request data for.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public DateTime? EndsAt { get; set; }

        /// <summary>
        /// Which dimension values to filter on; keys are dimension names, values are arrays of
        /// dimension values to filter on.
        /// </summary>
        [JsonProperty("filters")]
        [STJS.JsonPropertyName("filters")]
        public Dictionary<string, object> Filters { get; set; }

        /// <summary>
        /// The time granularity to aggregate results by.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("granularity")]
        [STJS.JsonPropertyName("granularity")]
        public string Granularity { get; set; }

        /// <summary>
        /// Which dimension keys to group by; if not specified no grouping is performed.
        /// </summary>
        [JsonProperty("group_by")]
        [STJS.JsonPropertyName("group_by")]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// The maximum number of rows in the response.
        /// </summary>
        [JsonProperty("limit")]
        [STJS.JsonPropertyName("limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// A list of the metrics to be returned; all metrics must share the same metric namespace.
        /// </summary>
        [JsonProperty("metrics")]
        [STJS.JsonPropertyName("metrics")]
        public List<MetricQueryCreateMetricOptions> Metrics { get; set; }

        /// <summary>
        /// Pagination future-proofing: page token for navigating to next/previous batch of rows.
        /// </summary>
        [JsonProperty("page")]
        [STJS.JsonPropertyName("page")]
        public string Page { get; set; }

        /// <summary>
        /// Timestamp denoting the beginning of the time range to request data for.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public DateTime? StartsAt { get; set; }

        /// <summary>
        /// The timezone results should be in; defaults to the merchant's timezone.
        /// </summary>
        [JsonProperty("timezone")]
        [STJS.JsonPropertyName("timezone")]
        public string Timezone { get; set; }
    }
}
