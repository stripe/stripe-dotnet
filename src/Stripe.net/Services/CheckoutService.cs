// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class CheckoutService : Service
    {
        private Checkout.SessionService sessions;

        internal CheckoutService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal CheckoutService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Checkout.SessionService Sessions => this.sessions ??= new Checkout.SessionService(
            this.Requestor);
    }
}
