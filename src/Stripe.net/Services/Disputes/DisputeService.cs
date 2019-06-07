namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class DisputeService : Service<Dispute>,
        IListable<Dispute, DisputeListOptions>,
        IRetrievable<Dispute, DisputeGetOptions>,
        IUpdatable<Dispute, DisputeUpdateOptions>
    {
        public DisputeService()
            : base(null)
        {
        }

        public DisputeService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/disputes";

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandCharge { get; set; }

        public virtual Dispute Close(string disputeId, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(disputeId)}/close", null, requestOptions);
        }

        public virtual Task<Dispute> CloseAsync(string disputeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(disputeId)}/close", null, requestOptions, cancellationToken);
        }

        public virtual Dispute Get(string disputeId, DisputeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(disputeId, options, requestOptions);
        }

        public virtual Task<Dispute> GetAsync(string disputeId, DisputeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(disputeId, options, requestOptions, cancellationToken);
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
