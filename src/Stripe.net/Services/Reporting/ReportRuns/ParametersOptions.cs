namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ParametersOptions : INestedOptions
    {
        [JsonProperty("connected_account")]
        public string ConnectedAccount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        public DateTime? IntervalEnd { get; set; }

        [JsonProperty("interval_end")]
        internal long? IntervalEndInternal
        {
            get
            {
                if (!this.IntervalEnd.HasValue)
                {
                    return null;
                }

                return EpochTime.ConvertDateTimeToEpoch(this.IntervalEnd.Value);
            }
        }

        public DateTime? IntervalStart { get; set; }

        [JsonProperty("interval_start")]
        internal long? IntervalStartInternal
        {
            get
            {
                if (!this.IntervalStart.HasValue)
                {
                    return null;
                }

                return EpochTime.ConvertDateTimeToEpoch(this.IntervalStart.Value);
            }
        }

        [JsonProperty("payout")]
        public string Payout { get; set; }

        [JsonProperty("reporting_category")]
        public string ReportingCategory { get; set; }
    }
}
