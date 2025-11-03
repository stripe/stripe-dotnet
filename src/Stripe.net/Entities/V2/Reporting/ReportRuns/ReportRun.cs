// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The <c>ReportRun</c> object represents an instance of a <c>Report</c> generated with
    /// specific run parameters. Once the object is created, Stripe begins processing the
    /// report. When the report has finished running, it will give you a reference to the
    /// results.
    /// </summary>
    public class ReportRun : StripeEntity<ReportRun>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique identifier of the <c>ReportRun</c> object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

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
        /// The unique identifier of the <c>Report</c> object which was run.
        /// </summary>
        [JsonProperty("report")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("report")]
#endif
        public string Report { get; set; }

        /// <summary>
        /// The human-readable name of the <c>Report</c> which was run.
        /// </summary>
        [JsonProperty("report_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("report_name")]
#endif
        public string ReportName { get; set; }

        /// <summary>
        /// The parameters used to customize the generation of the report.
        /// </summary>
        [JsonProperty("report_parameters")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("report_parameters")]
#endif
        public Dictionary<string, object> ReportParameters { get; set; }

        /// <summary>
        /// Details how to retrieve the results of a successfully completed <c>ReportRun</c>.
        /// </summary>
        [JsonProperty("result")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("result")]
#endif
        public ReportRunResult Result { get; set; }

        /// <summary>
        /// The options specified for customizing the output file of the <c>ReportRun</c>.
        /// </summary>
        [JsonProperty("result_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("result_options")]
#endif
        public ReportRunResultOptions ResultOptions { get; set; }

        /// <summary>
        /// The current status of the <c>ReportRun</c>.
        /// One of: <c>failed</c>, <c>running</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Additional details about the current state of the <c>ReportRun</c>. The field is
        /// currently only populated when a <c>ReportRun</c> is in the <c>failed</c> state,
        /// providing more information about why the report failed to generate successfully.
        /// </summary>
        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif
        public Dictionary<string, ReportRunStatusDetails> StatusDetails { get; set; }
    }
}
