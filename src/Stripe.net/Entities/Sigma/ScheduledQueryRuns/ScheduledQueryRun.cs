// File generated from our OpenAPI spec
namespace Stripe.Sigma
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// If you have <a href="https://stripe.com/docs/sigma/scheduled-queries">scheduled a Sigma
    /// query</a>, you'll receive a <c>sigma.scheduled_query_run.created</c> webhook each time
    /// the query runs. The webhook contains a <c>ScheduledQueryRun</c> object, which you can
    /// use to retrieve the query results.
    /// </summary>
    public class ScheduledQueryRun : StripeEntity<ScheduledQueryRun>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// When the query was run, Sigma contained a snapshot of your Stripe data at this time.
        /// </summary>
        [JsonProperty("data_load_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data_load_time")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime DataLoadTime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("error")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error")]
#endif
        public ScheduledQueryRunError Error { get; set; }

        /// <summary>
        /// The file object representing the results of the query.
        /// </summary>
        [JsonProperty("file")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("file")]
#endif
        public File File { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Time at which the result expires and is no longer available for download.
        /// </summary>
        [JsonProperty("result_available_until")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("result_available_until")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ResultAvailableUntil { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// SQL for the query.
        /// </summary>
        [JsonProperty("sql")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sql")]
#endif
        public string Sql { get; set; }

        /// <summary>
        /// The query's execution status, which will be <c>completed</c> for successful runs, and
        /// <c>canceled</c>, <c>failed</c>, or <c>timed_out</c> otherwise.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Title of the query.
        /// </summary>
        [JsonProperty("title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("title")]
#endif
        public string Title { get; set; }
    }
}
