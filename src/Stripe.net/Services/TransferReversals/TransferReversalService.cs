namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransferReversalService : ServiceNested<TransferReversal>,
        INestedCreatable<TransferReversal, TransferReversalCreateOptions>,
        INestedListable<TransferReversal, TransferReversalListOptions>,
        INestedRetrievable<TransferReversal>,
        INestedUpdatable<TransferReversal, TransferReversalUpdateOptions>
    {
        public TransferReversalService()
            : base(null)
        {
        }

        public TransferReversalService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/transfers/{PARENT_ID}/reversals";

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandTransfer { get; set; }

        public virtual TransferReversal Create(string transferId, TransferReversalCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.CreateNestedEntity(transferId, options, requestOptions);
        }

        public virtual Task<TransferReversal> CreateAsync(string transferId, TransferReversalCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateNestedEntityAsync(transferId, options, requestOptions, cancellationToken);
        }

        public virtual TransferReversal Get(string transferId, string reversalId, RequestOptions requestOptions = null)
        {
            return this.GetNestedEntity(transferId, reversalId, null, requestOptions);
        }

        public virtual Task<TransferReversal> GetAsync(string transferId, string reversalId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetNestedEntityAsync(transferId, reversalId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<TransferReversal> List(string transferId, TransferReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(transferId, options, requestOptions);
        }

        public virtual Task<StripeList<TransferReversal>> ListAsync(string transferId, TransferReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListNestedEntitiesAsync(transferId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<TransferReversal> ListAutoPaging(string transferId, TransferReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(transferId, options, requestOptions);
        }

        public virtual TransferReversal Update(string transferId,  string reversalId, TransferReversalUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateNestedEntity(transferId, reversalId, options, requestOptions);
        }

        public virtual Task<TransferReversal> UpdateAsync(string transferId,  string reversalId, TransferReversalUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateNestedEntityAsync(transferId, reversalId, options, requestOptions, cancellationToken);
        }
    }
}
