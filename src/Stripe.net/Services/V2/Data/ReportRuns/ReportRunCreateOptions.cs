// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReportRunCreateOptions : BaseOptions
    {
        /// <summary>
        /// The file format for the result.
        /// One of: <c>csv</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("format")]
        [STJS.JsonPropertyName("format")]
        public string Format { get; set; }

        /// <summary>
        /// A map of parameter names to values, specifying how the report should be customized. The
        /// accepted parameters depend on the specific <c>Report</c> being run.
        /// </summary>
        [JsonProperty("parameters")]
        [STJS.JsonPropertyName("parameters")]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// A reference to the <c>Report</c> to run, by ID or name.
        /// </summary>
        [JsonProperty("report")]
        [STJS.JsonPropertyName("report")]
        public ReportRunCreateReportOptions Report { get; set; }

        /// <summary>
        /// Optional settings that customize the generated result file.
        /// </summary>
        [JsonProperty("result_options")]
        [STJS.JsonPropertyName("result_options")]
        public ReportRunCreateResultOptionsOptions ResultOptions { get; set; }
    }
}
