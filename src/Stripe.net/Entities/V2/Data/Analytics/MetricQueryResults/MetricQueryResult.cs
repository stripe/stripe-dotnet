// File generated from our OpenAPI spec
namespace Stripe.V2.Data.Analytics
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The result of a metric query.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class MetricQueryResult : StripeEntity<MetricQueryResult>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique identifier of this metric query result.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The timestamp at which this metric query result was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// An array of timeseries data rows.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public List<MetricQueryResultData> Data { get; set; }

        /// <summary>
        /// Whether this query was run in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Pagination future-proofing: URL to fetch the next page; always null for now.
        /// </summary>
        [JsonProperty("next_page_url")]
        [STJS.JsonPropertyName("next_page_url")]
        public string NextPageUrl { get; set; }

        /// <summary>
        /// Pagination future-proofing: URL to fetch the previous page; always null for now.
        /// </summary>
        [JsonProperty("previous_page_url")]
        [STJS.JsonPropertyName("previous_page_url")]
        public string PreviousPageUrl { get; set; }

        /// <summary>
        /// A timestamp representing the freshness of the data this metric is aggregated from.
        /// </summary>
        [JsonProperty("refreshed_at")]
        [STJS.JsonPropertyName("refreshed_at")]
        public DateTime RefreshedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
