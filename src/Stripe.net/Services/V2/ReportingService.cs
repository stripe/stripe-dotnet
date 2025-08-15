// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReportingService : Service
    {
        private V2.Reporting.ReportRunService reportRuns;
        private V2.Reporting.ReportService reports;

        internal ReportingService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ReportingService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Reporting.ReportRunService ReportRuns => this.reportRuns ??= new V2.Reporting.ReportRunService(
            this.Requestor);

        public virtual V2.Reporting.ReportService Reports => this.reports ??= new V2.Reporting.ReportService(
            this.Requestor);
    }
}
