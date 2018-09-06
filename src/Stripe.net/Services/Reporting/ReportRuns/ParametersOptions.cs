namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ParametersOptions : INestedOptions
    {
        [JsonProperty("parameters[connected_account]")]
        public string ConnectedAccount { get; set; }

        [JsonProperty("parameters[currency]")]
        public string Currency { get; set; }

        public DateTime? IntervalEnd { get; set; }

        [JsonProperty("parameters[interval_end]")]
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

        [JsonProperty("parameters[interval_start]")]
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

        [JsonProperty("parameters[payout]")]
        public string Payout { get; set; }

        [JsonProperty("parameters[reporting_category]")]
        public string ReportingCategory { get; set; }
    }
}
