// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class DataService : Service
    {
        private V2.Data.AnalyticsService analytics;
        private V2.Data.QueryRunService queryRuns;
        private V2.Data.ReportService reports;
        private V2.Data.ReportRunService reportRuns;
        private V2.Data.ReportingService reporting;
        private V2.Data.SchemaService schemas;

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

        public virtual V2.Data.QueryRunService QueryRuns => this.queryRuns ??= new V2.Data.QueryRunService(
            this.Requestor);

        public virtual V2.Data.ReportService Reports => this.reports ??= new V2.Data.ReportService(
            this.Requestor);

        public virtual V2.Data.ReportRunService ReportRuns => this.reportRuns ??= new V2.Data.ReportRunService(
            this.Requestor);

        public virtual V2.Data.ReportingService Reporting => this.reporting ??= new V2.Data.ReportingService(
            this.Requestor);

        public virtual V2.Data.SchemaService Schemas => this.schemas ??= new V2.Data.SchemaService(
            this.Requestor);
    }
}
