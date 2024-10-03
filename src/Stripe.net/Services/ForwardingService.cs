// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class ForwardingService : Service
    {
        private Forwarding.RequestService requests;

        internal ForwardingService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ForwardingService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Forwarding.RequestService Requests => this.requests ??= new Forwarding.RequestService(
            this.Requestor);
    }
}
