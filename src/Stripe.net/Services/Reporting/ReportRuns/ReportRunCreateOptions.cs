namespace Stripe.Reporting
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ReportRunCreateOptions : BaseOptions
    {
        [JsonProperty("parameters")]
        public ReportRunParametersOptions Parameters { get; set; }

        [JsonProperty("report_type")]
        public string ReportType { get; set; }
    }
}
