// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReportingService : Service
    {
        private V2.Data.Reporting.QueryRunService queryRuns;

        internal ReportingService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ReportingService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Data.Reporting.QueryRunService QueryRuns => this.queryRuns ??= new V2.Data.Reporting.QueryRunService(
            this.Requestor);
    }
}
