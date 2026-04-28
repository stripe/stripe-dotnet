// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class DataService : Service
    {
        private V2.Data.AnalyticsService analytics;
        private V2.Data.ReportingService reporting;

        internal DataService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal DataService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Data.AnalyticsService Analytics => this.analytics ??= new V2.Data.AnalyticsService(
            this.Requestor);

        public virtual V2.Data.ReportingService Reporting => this.reporting ??= new V2.Data.ReportingService(
            this.Requestor);
    }
}
