// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class SignalsService : Service
    {
        private V2.Signals.AccountSignalService accountSignals;

        internal SignalsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal SignalsService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Signals.AccountSignalService AccountSignals => this.accountSignals ??= new V2.Signals.AccountSignalService(
            this.Requestor);
    }
}
