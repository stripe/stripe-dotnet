// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System;
    using System.Collections.Generic;
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
        /// Retrieves the status and results of a previously created <c>QueryRun</c>. Returns a
        /// <c>404</c> error if the <c>QueryRun</c> doesn't exist or its retention period has ended.
        /// </summary>
        public virtual QueryRun Get(string id, QueryRunGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<QueryRun>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/query_runs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the status and results of a previously created <c>QueryRun</c>. Returns a
        /// <c>404</c> error if the <c>QueryRun</c> doesn't exist or its retention period has ended.
        /// </summary>
        public virtual Task<QueryRun> GetAsync(string id, QueryRunGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<QueryRun>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/query_runs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of <c>QueryRun</c> objects created through the API, most recent first.
        /// Listed <c>QueryRun</c> objects don't include <c>result</c>. Retrieve a <c>QueryRun</c>
        /// to access its result.
        /// </summary>
        public virtual V2.StripeList<QueryRun> List(QueryRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<QueryRun>>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/query_runs", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of <c>QueryRun</c> objects created through the API, most recent first.
        /// Listed <c>QueryRun</c> objects don't include <c>result</c>. Retrieve a <c>QueryRun</c>
        /// to access its result.
        /// </summary>
        public virtual Task<V2.StripeList<QueryRun>> ListAsync(QueryRunListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<QueryRun>>(BaseAddress.Api, HttpMethod.Get, $"/v2/data/query_runs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of <c>QueryRun</c> objects created through the API, most recent first.
        /// Listed <c>QueryRun</c> objects don't include <c>result</c>. Retrieve a <c>QueryRun</c>
        /// to access its result.
        /// </summary>
        public virtual IEnumerable<QueryRun> ListAutoPaging(QueryRunListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<QueryRun>($"/v2/data/query_runs", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of <c>QueryRun</c> objects created through the API, most recent first.
        /// Listed <c>QueryRun</c> objects don't include <c>result</c>. Retrieve a <c>QueryRun</c>
        /// to access its result.
        /// </summary>
        public virtual IAsyncEnumerable<QueryRun> ListAutoPagingAsync(QueryRunListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<QueryRun>($"/v2/data/query_runs", options, requestOptions, cancellationToken);
        }
    }
}
