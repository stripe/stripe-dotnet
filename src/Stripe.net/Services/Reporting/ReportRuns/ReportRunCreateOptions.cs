namespace Stripe.Reporting
{
    using Newtonsoft.Json;

    public class ReportRunCreateOptions : BaseOptions
    {
        [JsonProperty("parameters")]
        public ParametersOptions Parameters { get; set; }

        [JsonProperty("report_type")]
        public string ReportType { get; set; }
    }
}
