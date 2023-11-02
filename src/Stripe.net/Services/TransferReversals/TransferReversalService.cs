// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransferReversalService : ServiceNested<TransferReversal>,
        INestedCreatable<TransferReversal, TransferReversalCreateOptions>,
        INestedListable<TransferReversal, TransferReversalListOptions>,
        INestedRetrievable<TransferReversal, TransferReversalGetOptions>,
        INestedUpdatable<TransferReversal, TransferReversalUpdateOptions>
    {
        public TransferReversalService()
            : base(null)
        {
        }

        public TransferReversalService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/transfers/{PARENT_ID}/reversals";

        public virtual TransferReversal Create(string parentId, TransferReversalCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TransferReversal>(HttpMethod.Post, $"/v1/transfers/{parentId}/reversals", options, requestOptions);
        }

        public virtual Task<TransferReversal> CreateAsync(string parentId, TransferReversalCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TransferReversal>(HttpMethod.Post, $"/v1/transfers/{parentId}/reversals", options, requestOptions, cancellationToken);
        }

        public virtual TransferReversal Get(string parentId, string id, TransferReversalGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<TransferReversal>(HttpMethod.Get, $"/v1/transfers/{parentId}/reversals/{id}", options, requestOptions);
        }

        public virtual Task<TransferReversal> GetAsync(string parentId, string id, TransferReversalGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TransferReversal>(HttpMethod.Get, $"/v1/transfers/{parentId}/reversals/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<TransferReversal> List(string parentId, TransferReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<TransferReversal>>(HttpMethod.Get, $"/v1/transfers/{parentId}/reversals", options, requestOptions);
        }

        public virtual Task<StripeList<TransferReversal>> ListAsync(string parentId, TransferReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<TransferReversal>>(HttpMethod.Get, $"/v1/transfers/{parentId}/reversals", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<TransferReversal> ListAutoPaging(string parentId, TransferReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<TransferReversal>($"/v1/transfers/{parentId}/reversals", options, requestOptions);
        }

        public virtual IAsyncEnumerable<TransferReversal> ListAutoPagingAsync(string parentId, TransferReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<TransferReversal>($"/v1/transfers/{parentId}/reversals", options, requestOptions, cancellationToken);
        }

        public virtual TransferReversal Update(string parentId, string id, TransferReversalUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<TransferReversal>(HttpMethod.Post, $"/v1/transfers/{parentId}/reversals/{id}", options, requestOptions);
        }

        public virtual Task<TransferReversal> UpdateAsync(string parentId, string id, TransferReversalUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<TransferReversal>(HttpMethod.Post, $"/v1/transfers/{parentId}/reversals/{id}", options, requestOptions, cancellationToken);
        }
    }
}
