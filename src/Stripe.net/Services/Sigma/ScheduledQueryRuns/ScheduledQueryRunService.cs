namespace Stripe.Sigma
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ScheduledQueryRunService : BasicService<ScheduledQueryRun>,
        IListable<ScheduledQueryRun, ScheduledQueryRunListOptions>,
        IRetrievable<ScheduledQueryRun>
    {
        private static string classUrl = Urls.BaseUrl + "/sigma/scheduled_query_runs";

        public ScheduledQueryRunService()
            : base(null)
        {
        }

        public ScheduledQueryRunService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual ScheduledQueryRun Get(string queryRunId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{classUrl}/{queryRunId}", requestOptions);
        }

        public virtual Task<ScheduledQueryRun> GetAsync(string queryRunId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{classUrl}/{queryRunId}", requestOptions, cancellationToken);
        }

        public virtual StripeList<ScheduledQueryRun> List(ScheduledQueryRunListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList(classUrl, requestOptions, listOptions);
        }

        public virtual Task<StripeList<ScheduledQueryRun>> ListAsync(ScheduledQueryRunListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync(classUrl, requestOptions, cancellationToken, listOptions);
        }
    }
}
