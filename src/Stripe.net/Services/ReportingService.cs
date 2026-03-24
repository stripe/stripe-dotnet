// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReportingService : Service
    {
        private Reporting.ReportRunService reportRuns;
        private Reporting.ReportTypeService reportTypes;

        internal ReportingService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ReportingService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Reporting.ReportRunService ReportRuns => this.reportRuns ??= new Reporting.ReportRunService(
            this.Requestor);

        public virtual Reporting.ReportTypeService ReportTypes => this.reportTypes ??= new Reporting.ReportTypeService(
            this.Requestor);
    }
}
