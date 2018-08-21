namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ScheduledQueryService : BasicService<ScheduledQueryRun>
    {
        public ScheduledQueryService()
            : base(null)
        {
        }

        public ScheduledQueryService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual ScheduledQueryRun Get(string queryRunId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntity($"{Urls.BaseUrl}/sigma/scheduled_query_runs/{queryRunId}", requestOptions);
        }

        public virtual StripeList<ScheduledQueryRun> List(ScheduledQueryListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityList($"{Urls.BaseUrl}/sigma/scheduled_query_runs", requestOptions, listOptions);
        }

        public virtual Task<ScheduledQueryRun> GetAsync(string queryRunId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/sigma/scheduled_query_runs/{queryRunId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<ScheduledQueryRun>> ListAsync(ScheduledQueryListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/sigma/scheduled_query_runs", requestOptions, cancellationToken, listOptions);
        }
    }
}