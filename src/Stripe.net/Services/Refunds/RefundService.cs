namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class RefundService : Service<Refund>,
        ICreatable<Refund, RefundCreateOptions>,
        IListable<Refund, RefundListOptions>,
        IRetrievable<Refund>,
        IUpdatable<Refund, RefundUpdateOptions>
    {
        public RefundService()
            : base(null)
        {
        }

        public RefundService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/refunds";

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandCharge { get; set; }

        public bool ExpandFailureBalanceTransaction { get; set; }

        public virtual Refund Create(RefundCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Refund> CreateAsync(RefundCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Refund Get(string refundId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(refundId, null, requestOptions);
        }

        public virtual Task<Refund> GetAsync(string refundId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(refundId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Refund> List(RefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Refund>> ListAsync(RefundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Refund> ListAutoPaging(RefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Refund Update(string refundId, RefundUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(refundId, options, requestOptions);
        }

        public virtual Task<Refund> UpdateAsync(string refundId, RefundUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(refundId, options, requestOptions, cancellationToken);
        }
    }
}
