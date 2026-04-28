// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class AnalyticsService : Service
    {
        private V2.Data.Analytics.MetricQueryService metricQuery;

        internal AnalyticsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AnalyticsService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Data.Analytics.MetricQueryService MetricQuery => this.metricQuery ??= new V2.Data.Analytics.MetricQueryService(
            this.Requestor);
    }
}
