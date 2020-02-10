namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReportRunCreateOptions : BaseOptions
    {
        [JsonProperty("parameters")]
        public ReportRunParametersOptions Parameters { get; set; }

        [JsonProperty("report_type")]
        public string ReportType { get; set; }
    }
}
