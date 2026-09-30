// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class QueryRunService : Service
    {
        internal QueryRunService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal QueryRunService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Submits a SQL query for execution against a dataset and returns a <c>QueryRun</c> object
        /// to track progress and retrieve results.
        /// </summary>
        public virtual QueryRun Create(QueryRunCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<QueryRun>(BaseAddress.Api, HttpMethod.Post, $"/v2/data/query_runs", options, requestOptions);
        }

        /// <summary>
        /// Submits a SQL query for execution against a dataset and returns a <c>QueryRun</c> object
        /// to track progress and retrieve results.
        /// </summary>
        public virtual Task<QueryRun> CreateAsync(QueryRunCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<QueryRun>(BaseAddress.Api, HttpMethod.Post, $"/v2/data/query_runs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the status and results of a previously created <c>QueryRun</c>.
        /// </summary>
        public virtual QueryRun Get(string id, QueryRunGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<QueryRun>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/query_runs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the status and results of a previously created <c>QueryRun</c>.
        /// </summary>
        public virtual Task<QueryRun> GetAsync(string id, QueryRunGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<QueryRun>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/query_runs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
