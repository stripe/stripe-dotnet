namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReportRunParameters : StripeEntity<ReportRunParameters>
    {
        /// <summary>
        /// The set of output columns requested for inclusion in the report run.
        /// </summary>
        [JsonProperty("columns")]
        public List<string> Columns { get; set; }

        /// <summary>
        /// Connected account ID by which to filter the report run.
        /// </summary>
        [JsonProperty("connected_account")]
        public string ConnectedAccount { get; set; }

        /// <summary>
        /// Currency of objects to be included in the report run.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Ending timestamp of data to be included in the report run (exclusive).
        /// </summary>
        [JsonProperty("interval_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime IntervalEnd { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Starting timestamp of data to be included in the report run.
        /// </summary>
        [JsonProperty("interval_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime IntervalStart { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Payout ID by which to filter the report run.
        /// </summary>
        [JsonProperty("payout")]
        public string Payout { get; set; }

        /// <summary>
        /// Category of balance transactions to be included in the report run.
        /// </summary>
        [JsonProperty("reporting_category")]
        public string ReportingCategory { get; set; }

        /// <summary>
        /// Defaults to <c>Etc/UTC</c>. The output timezone for all timestamps in the report. A list
        /// of possible time zone values is maintained at the <a
        /// href="http://www.iana.org/time-zones">IANA Time Zone Database</a>. Has no effect on
        /// <c>interval_start</c> or <c>interval_end</c>.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}
