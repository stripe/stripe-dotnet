namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ParametersOptions : INestedOptions
    {
        [JsonProperty("columns")]
        public List<string> Columns { get; set; }

        [JsonProperty("connected_account")]
        public string ConnectedAccount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("interval_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? IntervalEnd { get; set; }

        [JsonProperty("interval_start")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? IntervalStart { get; set; }

        [JsonProperty("payout")]
        public string Payout { get; set; }

        [JsonProperty("reporting_category")]
        public string ReportingCategory { get; set; }
    }
}
