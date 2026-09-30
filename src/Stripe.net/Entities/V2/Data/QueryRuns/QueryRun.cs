// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The <c>QueryRun</c> resource represents an execution of ad-hoc SQL against a dataset.
    /// Once created, Stripe processes the query. When the query has finished running, the
    /// object provides a reference to the results.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QueryRun : StripeEntity<QueryRun>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique identifier of the <c>QueryRun</c>.
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
        /// Time at which the <c>QueryRun</c> was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The dataset that was queried.
        /// One of: <c>analytical</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("dataset")]
        [STJS.JsonPropertyName("dataset")]
        public string Dataset { get; set; }

        /// <summary>
        /// The file format of the result. Only applicable when the result is a file.
        /// One of: <c>csv</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("format")]
        [STJS.JsonPropertyName("format")]
        public string Format { get; set; }

        /// <summary>
        /// Whether the <c>QueryRun</c> was executed in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The query that was submitted for execution.
        /// </summary>
        [JsonProperty("query")]
        [STJS.JsonPropertyName("query")]
        public QueryRunQuery Query { get; set; }

        /// <summary>
        /// Time at which the data used by this query was last refreshed.
        /// </summary>
        [JsonProperty("refreshed_at")]
        [STJS.JsonPropertyName("refreshed_at")]
        public DateTime? RefreshedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The result of the <c>QueryRun</c>, populated when it has completed.
        /// </summary>
        [JsonProperty("result")]
        [STJS.JsonPropertyName("result")]
        public QueryRunResult Result { get; set; }

        /// <summary>
        /// Settings applied to the generated result file.
        /// </summary>
        [JsonProperty("result_options")]
        [STJS.JsonPropertyName("result_options")]
        public QueryRunResultOptions ResultOptions { get; set; }

        /// <summary>
        /// The current status of the <c>QueryRun</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>running</c>, or <c>succeeded</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional details about the current state of the <c>QueryRun</c>.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public QueryRunStatusDetails StatusDetails { get; set; }
    }
}
