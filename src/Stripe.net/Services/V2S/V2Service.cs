// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class V2Service : Service
    {
        private V2.BillingService billing;
        private V2.CoreService core;

        internal V2Service(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal V2Service(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.BillingService Billing => this.billing ??= new V2.BillingService(
            this.Requestor);

        public virtual V2.CoreService Core => this.core ??= new V2.CoreService(
            this.Requestor);
    }
}
