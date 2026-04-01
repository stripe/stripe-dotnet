// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class DatumService : Service
    {
        private V2.Data.ReportingService reporting;

        internal DatumService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal DatumService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Data.ReportingService Reporting => this.reporting ??= new V2.Data.ReportingService(
            this.Requestor);
    }
}
