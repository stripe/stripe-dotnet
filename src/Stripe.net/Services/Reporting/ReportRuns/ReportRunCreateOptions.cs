// File generated from our OpenAPI spec
namespace Stripe.Reporting
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReportRunCreateOptions : BaseOptions
    {
        /// <summary>
        /// Parameters specifying how the report should be run. Different Report Types have
        /// different required and optional parameters, listed in the <a
        /// href="https://docs.stripe.com/reporting/statements/api">API Access to Reports</a>
        /// documentation.
        /// </summary>
        [JsonProperty("parameters")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("parameters")]
#endif
        public ReportRunParametersOptions Parameters { get; set; }

        /// <summary>
        /// The ID of the <a
        /// href="https://docs.stripe.com/reporting/statements/api#report-types">report type</a> to
        /// run, such as <c>"balance.summary.1"</c>.
        /// </summary>
        [JsonProperty("report_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("report_type")]
#endif
        public string ReportType { get; set; }
    }
}
