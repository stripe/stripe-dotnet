namespace Stripe.Reporting
{
    using Newtonsoft.Json;

    public class ReportRunCreateOptions : BaseOptions
    {
        /// <summary>
        /// Parameters specifying how the report should be run. Different Report Types have
        /// different required and optional parameters, listed in the <a
        /// href="https://stripe.com/docs/reporting/statements/api">API Access to Reports</a>
        /// documentation.
        /// </summary>
        [JsonProperty("parameters")]
        public ReportRunParametersOptions Parameters { get; set; }

        /// <summary>
        /// The ID of the <a
        /// href="https://stripe.com/docs/reporting/statements/api#report-types">report type</a> to
        /// run, such as <c>"balance.summary.1"</c>.
        /// </summary>
        [JsonProperty("report_type")]
        public string ReportType { get; set; }
    }
}
