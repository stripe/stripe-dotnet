namespace Stripe
{
    using System.Collections.Generic;
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
            return this.CreateNestedEntity(parentId, options, requestOptions);
        }

        public virtual Task<TransferReversal> CreateAsync(string parentId, TransferReversalCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateNestedEntityAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual TransferReversal Get(string parentId, string id, TransferReversalGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(parentId, id, options, requestOptions);
        }

        public virtual Task<TransferReversal> GetAsync(string parentId, string id, TransferReversalGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<TransferReversal> List(string parentId, TransferReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(parentId, options, requestOptions);
        }

        public virtual Task<StripeList<TransferReversal>> ListAsync(string parentId, TransferReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<TransferReversal> ListAutoPaging(string parentId, TransferReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(parentId, options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<TransferReversal> ListAutoPagingAsync(string parentId, TransferReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(parentId, options, requestOptions, cancellationToken);
        }
#endif

        public virtual TransferReversal Update(string parentId, string id, TransferReversalUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(parentId, id, options, requestOptions);
        }

        public virtual Task<TransferReversal> UpdateAsync(string parentId, string id, TransferReversalUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }
    }
}
