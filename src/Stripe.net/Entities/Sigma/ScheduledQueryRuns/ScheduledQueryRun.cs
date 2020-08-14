namespace Stripe.Sigma
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ScheduledQueryRun : StripeEntity<ScheduledQueryRun>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// When the query was run, Sigma contained a snapshot of your Stripe data at this time.
        /// </summary>
        [JsonProperty("data_load_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DataLoadTime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("error")]
        public ScheduledQueryRunError Error { get; set; }

        /// <summary>
        /// The file object representing the results of the query.
        /// </summary>
        [JsonProperty("file")]
        public File File { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Time at which the result expires and is no longer available for download.
        /// </summary>
        [JsonProperty("result_available_until")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ResultAvailableUntil { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// SQL for the query.
        /// </summary>
        [JsonProperty("sql")]
        public string Sql { get; set; }

        /// <summary>
        /// The query's execution status, which will be <c>completed</c> for successful runs, and
        /// <c>canceled</c>, <c>failed</c>, or <c>timed_out</c> otherwise.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Title of the query.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
