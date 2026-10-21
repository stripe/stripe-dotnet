// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OperationService : Service
    {
        internal OperationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal OperationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Resolve a natural-language query into ranked public analytical resources (schemas,
        /// reports, and metrics) with execution context.
        /// </summary>
        public virtual SearchResultList Search(OperationSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SearchResultList>(BaseAddress.Api, HttpMethod.Post, $"/v2/data/operations/search", options, requestOptions);
        }

        /// <summary>
        /// Resolve a natural-language query into ranked public analytical resources (schemas,
        /// reports, and metrics) with execution context.
        /// </summary>
        public virtual Task<SearchResultList> SearchAsync(OperationSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SearchResultList>(BaseAddress.Api, HttpMethod.Post, $"/v2/data/operations/search", options, requestOptions, cancellationToken);
        }
    }
}
