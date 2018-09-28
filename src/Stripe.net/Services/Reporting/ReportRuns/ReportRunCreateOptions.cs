namespace Stripe.Reporting
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class ReportRunCreateOptions : BaseOptions
    {
        [FormProperty("parameters")]
        public ParametersOptions Parameters { get; set; }

        [FormProperty("report_type")]
        public string ReportType { get; set; }
    }
}
