namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class DisputeService : BasicService<Dispute>,
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

        public bool ExpandCharge { get; set; }

        public virtual Dispute Get(string disputeId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.Disputes}/{disputeId}", requestOptions);
        }

        public virtual Dispute Update(string disputeId, DisputeUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.Disputes}/{disputeId}", requestOptions, updateOptions);
        }

        public virtual Dispute Close(string disputeId, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.Disputes}/{disputeId}/close", requestOptions);
        }

        public virtual StripeList<Dispute> List(DisputeListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList(Urls.Disputes, requestOptions, listOptions);
        }

        public virtual Task<Dispute> GetAsync(string disputeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.Disputes}/{disputeId}", requestOptions, cancellationToken);
        }

        public virtual Task<Dispute> UpdateAsync(string disputeId, DisputeUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.Disputes}/{disputeId}", requestOptions, cancellationToken, updateOptions);
        }

        public virtual Task<Dispute> CloseAsync(string disputeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.Disputes}/{disputeId}/close", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<Dispute>> ListAsync(DisputeListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync(Urls.Disputes, requestOptions, cancellationToken, listOptions);
        }
    }
}
