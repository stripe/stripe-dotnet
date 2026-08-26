// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class SignalsService : Service
    {
        private V2.Signals.AccountActivityService accountActivity;
        private V2.Signals.AccountEvaluationService accountEvaluations;
        private V2.Signals.AccountSignalService accountSignals;

        internal SignalsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal SignalsService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Signals.AccountActivityService AccountActivity => this.accountActivity ??= new V2.Signals.AccountActivityService(
            this.Requestor);

        public virtual V2.Signals.AccountEvaluationService AccountEvaluations => this.accountEvaluations ??= new V2.Signals.AccountEvaluationService(
            this.Requestor);

        public virtual V2.Signals.AccountSignalService AccountSignals => this.accountSignals ??= new V2.Signals.AccountSignalService(
            this.Requestor);
    }
}
