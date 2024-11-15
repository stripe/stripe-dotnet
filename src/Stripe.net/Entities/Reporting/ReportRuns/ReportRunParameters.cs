// File generated from our OpenAPI spec
namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReportRunParameters : StripeEntity<ReportRunParameters>
    {
        /// <summary>
        /// The set of output columns requested for inclusion in the report run.
        /// </summary>
        [JsonProperty("columns")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("columns")]
#endif

        public List<string> Columns { get; set; }

        /// <summary>
        /// Connected account ID by which to filter the report run.
        /// </summary>
        [JsonProperty("connected_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("connected_account")]
#endif

        public string ConnectedAccount { get; set; }

        /// <summary>
        /// Currency of objects to be included in the report run.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        /// <summary>
        /// Ending timestamp of data to be included in the report run. Can be any UTC timestamp
        /// between 1 second after the user specified <c>interval_start</c> and 1 second before this
        /// report's last <c>data_available_end</c> value.
        /// </summary>
        [JsonProperty("interval_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval_end")]
#endif

        public DateTime IntervalEnd { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Starting timestamp of data to be included in the report run. Can be any UTC timestamp
        /// between 1 second after this report's <c>data_available_start</c> and 1 second before the
        /// user specified <c>interval_end</c> value.
        /// </summary>
        [JsonProperty("interval_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval_start")]
#endif

        public DateTime IntervalStart { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Payout ID by which to filter the report run.
        /// </summary>
        [JsonProperty("payout")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payout")]
#endif

        public string Payout { get; set; }

        /// <summary>
        /// Category of balance transactions to be included in the report run.
        /// </summary>
        [JsonProperty("reporting_category")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reporting_category")]
#endif

        public string ReportingCategory { get; set; }

        /// <summary>
        /// Defaults to <c>Etc/UTC</c>. The output timezone for all timestamps in the report. A list
        /// of possible time zone values is maintained at the <a
        /// href="http://www.iana.org/time-zones">IANA Time Zone Database</a>. Has no effect on
        /// <c>interval_start</c> or <c>interval_end</c>.
        /// </summary>
        [JsonProperty("timezone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timezone")]
#endif

        public string Timezone { get; set; }
    }
}
