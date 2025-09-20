// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class AnalyticsService : Service
    {
        private Billing.Analytics.MeterUsageService meterUsage;

        internal AnalyticsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AnalyticsService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Billing.Analytics.MeterUsageService MeterUsage => this.meterUsage ??= new Billing.Analytics.MeterUsageService(
            this.Requestor);
    }
}
