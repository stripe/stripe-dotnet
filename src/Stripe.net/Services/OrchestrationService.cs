// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class OrchestrationService : Service
    {
        private Orchestration.PaymentAttemptService paymentAttempts;

        internal OrchestrationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal OrchestrationService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Orchestration.PaymentAttemptService PaymentAttempts => this.paymentAttempts ??= new Orchestration.PaymentAttemptService(
            this.Requestor);
    }
}
