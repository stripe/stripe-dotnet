namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReportRunParameters : StripeEntity<ReportRunParameters>
    {
        [JsonProperty("columns")]
        public List<string> Columns { get; set; }

        [JsonProperty("connected_account")]
        public string ConnectedAccount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("interval_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime IntervalEnd { get; set; }

        [JsonProperty("interval_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime IntervalStart { get; set; }

        [JsonProperty("payout")]
        public string Payout { get; set; }

        [JsonProperty("reporting_category")]
        public string ReportingCategory { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}
