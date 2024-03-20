// File generated from our OpenAPI spec
namespace Stripe.Sigma
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ScheduledQueryRunService : Service<ScheduledQueryRun>,
        IListable<ScheduledQueryRun, ScheduledQueryRunListOptions>,
        IRetrievable<ScheduledQueryRun, ScheduledQueryRunGetOptions>
    {
        public ScheduledQueryRunService()
        {
        }

        public ScheduledQueryRunService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/sigma/scheduled_query_runs";

        /// <summary>
        /// <p>Retrieves the details of an scheduled query run.</p>.
        /// </summary>
        public virtual ScheduledQueryRun Get(string id, ScheduledQueryRunGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ScheduledQueryRun>(HttpMethod.Get, $"/v1/sigma/scheduled_query_runs/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an scheduled query run.</p>.
        /// </summary>
        public virtual Task<ScheduledQueryRun> GetAsync(string id, ScheduledQueryRunGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ScheduledQueryRun>(HttpMethod.Get, $"/v1/sigma/scheduled_query_runs/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of scheduled query runs.</p>.
        /// </summary>
        public virtual StripeList<ScheduledQueryRun> List(ScheduledQueryRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ScheduledQueryRun>>(HttpMethod.Get, $"/v1/sigma/scheduled_query_runs", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of scheduled query runs.</p>.
        /// </summary>
        public virtual Task<StripeList<ScheduledQueryRun>> ListAsync(ScheduledQueryRunListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ScheduledQueryRun>>(HttpMethod.Get, $"/v1/sigma/scheduled_query_runs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of scheduled query runs.</p>.
        /// </summary>
        public virtual IEnumerable<ScheduledQueryRun> ListAutoPaging(ScheduledQueryRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ScheduledQueryRun>($"/v1/sigma/scheduled_query_runs", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of scheduled query runs.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<ScheduledQueryRun> ListAutoPagingAsync(ScheduledQueryRunListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ScheduledQueryRun>($"/v1/sigma/scheduled_query_runs", options, requestOptions, cancellationToken);
        }
    }
}
