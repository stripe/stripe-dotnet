namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class ParametersOptions : INestedOptions
    {
        [FormProperty("connected_account")]
        public string ConnectedAccount { get; set; }

        [FormProperty("currency")]
        public string Currency { get; set; }

        [FormProperty("interval_end")]
        public DateTime? IntervalEnd { get; set; }

        [FormProperty("interval_start")]
        public DateTime? IntervalStart { get; set; }

        [FormProperty("payout")]
        public string Payout { get; set; }

        [FormProperty("reporting_category")]
        public string ReportingCategory { get; set; }
    }
}
