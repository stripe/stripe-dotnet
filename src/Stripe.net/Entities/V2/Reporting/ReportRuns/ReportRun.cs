// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// The <c>ReportRun</c> object represents an instance of a <c>Report</c> generated with
    /// specific run parameters. Once the object is created, Stripe begins processing the
    /// report. When the report has finished running, it will give you a reference to the
    /// results.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReportRun : StripeEntity<ReportRun>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique identifier of the <c>ReportRun</c> object.
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
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The unique identifier of the <c>Report</c> object which was run.
        /// </summary>
        [JsonProperty("report")]
        [STJS.JsonPropertyName("report")]
        public string Report { get; set; }

        /// <summary>
        /// The human-readable name of the <c>Report</c> which was run.
        /// </summary>
        [JsonProperty("report_name")]
        [STJS.JsonPropertyName("report_name")]
        public string ReportName { get; set; }

        /// <summary>
        /// The parameters used to customize the generation of the report.
        /// </summary>
        [JsonProperty("report_parameters")]
        [STJS.JsonPropertyName("report_parameters")]
        public Dictionary<string, object> ReportParameters { get; set; }

        /// <summary>
        /// Details how to retrieve the results of a successfully completed <c>ReportRun</c>.
        /// </summary>
        [JsonProperty("result")]
        [STJS.JsonPropertyName("result")]
        public ReportRunResult Result { get; set; }

        /// <summary>
        /// The options specified for customizing the output file of the <c>ReportRun</c>.
        /// </summary>
        [JsonProperty("result_options")]
        [STJS.JsonPropertyName("result_options")]
        public ReportRunResultOptions ResultOptions { get; set; }

        /// <summary>
        /// The current status of the <c>ReportRun</c>.
        /// One of: <c>failed</c>, <c>running</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional details about the current state of the <c>ReportRun</c>. The field is
        /// currently only populated when a <c>ReportRun</c> is in the <c>failed</c> state,
        /// providing more information about why the report failed to generate successfully.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public Dictionary<string, ReportRunStatusDetails> StatusDetails { get; set; }
    }
}
