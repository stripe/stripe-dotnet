namespace Stripe.Reporting
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ReportRunCreateOptions : StripeBaseOptions
    {
        [JsonProperty("parameters")]
        public ParametersOptions Parameters { get; set; }

        [JsonProperty("report_type")]
        public string ReportType { get; set; }
    }
}
