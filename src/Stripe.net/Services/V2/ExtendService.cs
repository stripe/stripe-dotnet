// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class ExtendService : Service
    {
        private V2.Extend.WorkflowService workflows;
        private V2.Extend.WorkflowRunService workflowRuns;

        internal ExtendService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ExtendService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Extend.WorkflowService Workflows => this.workflows ??= new V2.Extend.WorkflowService(
            this.Requestor);

        public virtual V2.Extend.WorkflowRunService WorkflowRuns => this.workflowRuns ??= new V2.Extend.WorkflowRunService(
            this.Requestor);
    }
}
