// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class HealthService : Service
    {
        private V2.Core.Health.AlertService alerts;

        internal HealthService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal HealthService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Core.Health.AlertService Alerts => this.alerts ??= new V2.Core.Health.AlertService(
            this.Requestor);
    }
}
