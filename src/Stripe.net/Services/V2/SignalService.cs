// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class SignalService : Service
    {
        private V2.Signals.AccountSignalService accountSignals;

        internal SignalService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal SignalService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Signals.AccountSignalService AccountSignals => this.accountSignals ??= new V2.Signals.AccountSignalService(
            this.Requestor);
    }
}
