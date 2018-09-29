namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class DisputeService : Service<Dispute>,
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

        public virtual Dispute Close(string disputeId, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/disputes/{disputeId}/close", requestOptions);
        }

        public virtual Task<Dispute> CloseAsync(string disputeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/disputes/{disputeId}/close", requestOptions, cancellationToken);
        }

        public virtual Dispute Get(string disputeId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/disputes/{disputeId}", requestOptions);
        }

        public virtual Task<Dispute> GetAsync(string disputeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/disputes/{disputeId}", requestOptions, cancellationToken);
        }

        public virtual StripeList<Dispute> List(DisputeListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/disputes", requestOptions, listOptions);
        }

        public virtual Task<StripeList<Dispute>> ListAsync(DisputeListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/disputes", requestOptions, cancellationToken, listOptions);
        }

        public virtual Dispute Update(string disputeId, DisputeUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/disputes/{disputeId}", requestOptions, updateOptions);
        }

        public virtual Task<Dispute> UpdateAsync(string disputeId, DisputeUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/disputes/{disputeId}", requestOptions, cancellationToken, updateOptions);
        }
    }
}
