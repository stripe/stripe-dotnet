// File generated from our OpenAPI spec
namespace Stripe.V2.Data.Reporting
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
        /// Creates a query run to execute ad-hoc SQL and returns a <c>QueryRun</c> object to track
        /// progress and retrieve results.
        /// </summary>
        public virtual QueryRun Create(QueryRunCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<QueryRun>(BaseAddress.Api, HttpMethod.Post, $"/v2/data/reporting/query_runs", options, requestOptions);
        }

        /// <summary>
        /// Creates a query run to execute ad-hoc SQL and returns a <c>QueryRun</c> object to track
        /// progress and retrieve results.
        /// </summary>
        public virtual Task<QueryRun> CreateAsync(QueryRunCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<QueryRun>(BaseAddress.Api, HttpMethod.Post, $"/v2/data/reporting/query_runs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Fetches the current state and details of a previously created <c>QueryRun</c>. If the
        /// <c>QueryRun</c> has succeeded, the endpoint will provide details for how to retrieve the
        /// results.
        /// </summary>
        public virtual QueryRun Get(string id, QueryRunGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<QueryRun>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/reporting/query_runs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Fetches the current state and details of a previously created <c>QueryRun</c>. If the
        /// <c>QueryRun</c> has succeeded, the endpoint will provide details for how to retrieve the
        /// results.
        /// </summary>
        public virtual Task<QueryRun> GetAsync(string id, QueryRunGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<QueryRun>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/reporting/query_runs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
