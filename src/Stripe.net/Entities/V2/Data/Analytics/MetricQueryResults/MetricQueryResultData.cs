// File generated from our OpenAPI spec
namespace Stripe.V2.Data.Analytics
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class MetricQueryResultData : StripeEntity<MetricQueryResultData>, IHasId
    {
        /// <summary>
        /// A hash of dimension type to dimension instance, if group_by was specified.
        /// </summary>
        [JsonProperty("dimensions")]
        [STJS.JsonPropertyName("dimensions")]
        public Dictionary<string, string> Dimensions { get; set; }

        /// <summary>
        /// A unique identifier for this row.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Array of metric values returned from this query.
        /// </summary>
        [JsonProperty("results")]
        [STJS.JsonPropertyName("results")]
        public List<MetricQueryResultDataResult> Results { get; set; }

        /// <summary>
        /// Timestamp denoting the start of this time bucket.
        /// </summary>
        [JsonProperty("timestamp")]
        [STJS.JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
