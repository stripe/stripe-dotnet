// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReportRunCreateOptions : BaseOptions
    {
        /// <summary>
        /// The unique identifier of the <c>Report</c> being requested.
        /// </summary>
        [JsonProperty("report")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("report")]
#endif
        public string Report { get; set; }

        /// <summary>
        /// A map of parameter names to values, specifying how the report should be customized. The
        /// accepted parameters depend on the specific <c>Report</c> being run.
        /// </summary>
        [JsonProperty("report_parameters")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("report_parameters")]
#endif
        public Dictionary<string, ReportRunCreateReportParametersOptions> ReportParameters { get; set; }

        /// <summary>
        /// Optional settings to customize the results of the <c>ReportRun</c>.
        /// </summary>
        [JsonProperty("result_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("result_options")]
#endif
        public ReportRunCreateResultOptionsOptions ResultOptions { get; set; }
    }
}
