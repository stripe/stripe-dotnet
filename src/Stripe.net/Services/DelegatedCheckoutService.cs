// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class DelegatedCheckoutService : Service
    {
        private DelegatedCheckout.OrderService orders;
        private DelegatedCheckout.RequestedSessionService requestedSessions;

        internal DelegatedCheckoutService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal DelegatedCheckoutService(IStripeClient client)
            : base(client)
        {
        }

        public virtual DelegatedCheckout.OrderService Orders => this.orders ??= new DelegatedCheckout.OrderService(
            this.Requestor);

        public virtual DelegatedCheckout.RequestedSessionService RequestedSessions => this.requestedSessions ??= new DelegatedCheckout.RequestedSessionService(
            this.Requestor);
    }
}
