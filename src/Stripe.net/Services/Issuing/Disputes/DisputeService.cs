namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class DisputeService : Service<Dispute>,
        ICreatable<Dispute, DisputeCreateOptions>,
        IListable<Dispute, DisputeListOptions>,
        IRetrievable<Dispute>,
        IUpdatable<Dispute, DisputeUpdateOptions>
    {
        public DisputeService()
            : base(null)
        {
        }

        public DisputeService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/issuing/disputes";

        public virtual Dispute Create(DisputeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Dispute> CreateAsync(DisputeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Dispute Get(string disputeId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(disputeId, null, requestOptions);
        }

        public virtual Task<Dispute> GetAsync(string disputeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(disputeId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<Dispute> List(DisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Dispute>> ListAsync(DisputeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Dispute> ListAutoPaging(DisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Dispute Update(string disputeId, DisputeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(disputeId, options, requestOptions);
        }

        public virtual Task<Dispute> UpdateAsync(string disputeId, DisputeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(disputeId, options, requestOptions, cancellationToken);
        }
    }
}
