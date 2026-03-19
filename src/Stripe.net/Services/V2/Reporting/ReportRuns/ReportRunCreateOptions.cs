// File generated from our OpenAPI spec
namespace Stripe.V2.Reporting
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReportRunCreateOptions : BaseOptions
    {
        /// <summary>
        /// The unique identifier of the <c>Report</c> being requested.
        /// </summary>
        [JsonProperty("report")]
        [STJS.JsonPropertyName("report")]
        public string Report { get; set; }

        /// <summary>
        /// A map of parameter names to values, specifying how the report should be customized. The
        /// accepted parameters depend on the specific <c>Report</c> being run.
        /// </summary>
        [JsonProperty("report_parameters")]
        [STJS.JsonPropertyName("report_parameters")]
        public Dictionary<string, object> ReportParameters { get; set; }

        /// <summary>
        /// Optional settings to customize the results of the <c>ReportRun</c>.
        /// </summary>
        [JsonProperty("result_options")]
        [STJS.JsonPropertyName("result_options")]
        public ReportRunCreateResultOptionsOptions ResultOptions { get; set; }
    }
}
