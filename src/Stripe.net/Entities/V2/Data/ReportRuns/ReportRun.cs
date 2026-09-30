// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The <c>ReportRun</c> resource represents an instance of a <c>Report</c> generated with
    /// specific parameter values. Once the object is created, Stripe begins processing the
    /// report. When the report has finished running, it provides a reference to the results.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReportRun : StripeEntity<ReportRun>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique identifier of the <c>ReportRun</c>.
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
        /// Time at which the <c>ReportRun</c> was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether the <c>ReportRun</c> was executed in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The human-readable name of the <c>Report</c> which was run.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The parameters used to customize the generation of the report.
        /// </summary>
        [JsonProperty("parameters")]
        [STJS.JsonPropertyName("parameters")]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// Time at which the data used by this report was last refreshed.
        /// </summary>
        [JsonProperty("refreshed_at")]
        [STJS.JsonPropertyName("refreshed_at")]
        public DateTime? RefreshedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The unique identifier of the <c>Report</c> which was run.
        /// </summary>
        [JsonProperty("report")]
        [STJS.JsonPropertyName("report")]
        public string Report { get; set; }

        /// <summary>
        /// The result of the <c>ReportRun</c>, populated when it has completed.
        /// </summary>
        [JsonProperty("result")]
        [STJS.JsonPropertyName("result")]
        public ReportRunResult Result { get; set; }

        /// <summary>
        /// Settings applied to the generated result file.
        /// </summary>
        [JsonProperty("result_options")]
        [STJS.JsonPropertyName("result_options")]
        public ReportRunResultOptions ResultOptions { get; set; }

        /// <summary>
        /// The fully-resolved SQL that was executed. Only present when requested via
        /// <c>include[0]=sql</c>.
        /// </summary>
        [JsonProperty("sql")]
        [STJS.JsonPropertyName("sql")]
        public string Sql { get; set; }

        /// <summary>
        /// The current status of the <c>ReportRun</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>running</c>, or <c>succeeded</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional details about the current state of the <c>ReportRun</c>.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public ReportRunStatusDetails StatusDetails { get; set; }
    }
}
