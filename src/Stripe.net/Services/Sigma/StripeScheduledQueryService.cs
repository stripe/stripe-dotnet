using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeScheduledQueryService : StripeBasicService<StripeScheduledQueryRun>
    {
        public StripeScheduledQueryService() : base(null) { }
        public StripeScheduledQueryService(string apiKey) : base(apiKey) { }



        // Sync
        public virtual StripeScheduledQueryRun Get(string queryRunId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntity($"{Urls.BaseUrl}/sigma/scheduled_query_runs/{queryRunId}", requestOptions);
        }

        public virtual StripeList<StripeScheduledQueryRun> List(StripeScheduledQueryListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityList($"{Urls.BaseUrl}/sigma/scheduled_query_runs", requestOptions, listOptions);
        }



        // Async
        public virtual Task<StripeScheduledQueryRun> GetAsync(string queryRunId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/sigma/scheduled_query_runs/{queryRunId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<StripeScheduledQueryRun>> ListAsync(StripeScheduledQueryListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/sigma/scheduled_query_runs", requestOptions, cancellationToken, listOptions);
        }
    }
}