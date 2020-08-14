namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class UsageRecordSummaryPeriod : StripeEntity<UsageRecordSummaryPeriod>
    {
        /// <summary>
        /// The end date of this usage period. All usage up to and including this point in time is
        /// included.
        /// </summary>
        [JsonProperty("end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? End { get; set; }

        /// <summary>
        /// The start date of this usage period. All usage after this point in time is included.
        /// </summary>
        [JsonProperty("start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Start { get; set; }
    }
}
