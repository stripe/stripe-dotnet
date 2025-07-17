// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class SigmaService : Service
    {
        private Sigma.ScheduledQueryRunService scheduledQueryRuns;
        private Sigma.SchemaService schemas;

        internal SigmaService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal SigmaService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Sigma.ScheduledQueryRunService ScheduledQueryRuns => this.scheduledQueryRuns ??= new Sigma.ScheduledQueryRunService(
            this.Requestor);

        public virtual Sigma.SchemaService Schemas => this.schemas ??= new Sigma.SchemaService(
            this.Requestor);
    }
}
