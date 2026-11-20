// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class RiskService : Service
    {
        private V2.Risk.EvaluationOutcomeService evaluationOutcomes;
        private V2.Risk.FormService forms;

        internal RiskService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal RiskService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Risk.EvaluationOutcomeService EvaluationOutcomes => this.evaluationOutcomes ??= new V2.Risk.EvaluationOutcomeService(
            this.Requestor);

        public virtual V2.Risk.FormService Forms => this.forms ??= new V2.Risk.FormService(
            this.Requestor);
    }
}
