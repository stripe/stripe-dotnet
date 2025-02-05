// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class BillingPortalService : Service
    {
        private BillingPortal.ConfigurationService configurations;
        private BillingPortal.SessionService sessions;

        internal BillingPortalService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal BillingPortalService(IStripeClient client)
            : base(client)
        {
        }

        public virtual BillingPortal.ConfigurationService Configurations => this.configurations ??= new BillingPortal.ConfigurationService(
            this.Requestor);

        public virtual BillingPortal.SessionService Sessions => this.sessions ??= new BillingPortal.SessionService(
            this.Requestor);
    }
}
