namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class RefundService : Service<Refund>,
        ICreatable<Refund, RefundCreateOptions>,
        IListable<Refund, RefundListOptions>,
        IRetrievable<Refund, RefundGetOptions>,
        IUpdatable<Refund, RefundUpdateOptions>
    {
        public RefundService()
            : base(null)
        {
        }

        public RefundService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/refunds";

        public virtual Refund Create(RefundCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Refund> CreateAsync(RefundCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Refund Get(string refundId, RefundGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(refundId, options, requestOptions);
        }

        public virtual Task<Refund> GetAsync(string refundId, RefundGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(refundId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Refund> List(RefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Refund>> ListAsync(RefundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Refund> ListAutoPaging(RefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Refund> ListAutoPagingAsync(RefundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual Refund Update(string refundId, RefundUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(refundId, options, requestOptions);
        }

        public virtual Task<Refund> UpdateAsync(string refundId, RefundUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(refundId, options, requestOptions, cancellationToken);
        }
    }
}
