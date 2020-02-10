namespace Stripe.Sigma
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ScheduledQueryRunService : Service<ScheduledQueryRun>,
        IListable<ScheduledQueryRun, ScheduledQueryRunListOptions>,
        IRetrievable<ScheduledQueryRun, ScheduledQueryRunGetOptions>
    {
        public ScheduledQueryRunService()
            : base(null)
        {
        }

        public ScheduledQueryRunService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/sigma/scheduled_query_runs";

        public virtual ScheduledQueryRun Get(string id, ScheduledQueryRunGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<ScheduledQueryRun> GetAsync(string id, ScheduledQueryRunGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ScheduledQueryRun> List(ScheduledQueryRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ScheduledQueryRun>> ListAsync(ScheduledQueryRunListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ScheduledQueryRun> ListAutoPaging(ScheduledQueryRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
