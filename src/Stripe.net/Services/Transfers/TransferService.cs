namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class TransferService : Service<Transfer>,
        ICreatable<Transfer, TransferCreateOptions>,
        IListable<Transfer, TransferListOptions>,
        IRetrievable<Transfer, TransferGetOptions>,
        IUpdatable<Transfer, TransferUpdateOptions>
    {
        public TransferService()
            : base(null)
        {
        }

        public TransferService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/transfers";

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandBalanceTransaction { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandDestination { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandDestinationPayment { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandSourceTransaction { get; set; }

        public virtual Transfer Create(TransferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Transfer> CreateAsync(TransferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Transfer Get(string transferId, TransferGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(transferId, options, requestOptions);
        }

        public virtual Task<Transfer> GetAsync(string transferId, TransferGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(transferId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Transfer> List(TransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Transfer>> ListAsync(TransferListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Transfer> ListAutoPaging(TransferListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Transfer Update(string transferId, TransferUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(transferId, options, requestOptions);
        }

        public virtual Task<Transfer> UpdateAsync(string transferId, TransferUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(transferId, options, requestOptions, cancellationToken);
        }
    }
}
