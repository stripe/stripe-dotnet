namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class DisputeService : Service<Dispute>,
        ICreatable<Dispute, DisputeCreateOptions>,
        IListable<Dispute, DisputeListOptions>,
        IRetrievable<Dispute>,
        IUpdatable<Dispute, DisputeUpdateOptions>
    {
        private static string classUrl = Urls.BaseUrl + "/issuing/disputes";

        public DisputeService()
            : base(null)
        {
        }

        public DisputeService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Dispute Create(DisputeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}", requestOptions, options);
        }

        public virtual Dispute Get(string disputeId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{classUrl}/{disputeId}", requestOptions);
        }

        public virtual StripeList<Dispute> List(DisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{classUrl}", requestOptions, options);
        }

        public virtual Dispute Update(string disputeId, DisputeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}/{disputeId}", requestOptions, options);
        }

        public virtual Task<Dispute> CreateAsync(DisputeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual Task<Dispute> GetAsync(string disputeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{classUrl}/{disputeId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<Dispute>> ListAsync(DisputeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual Task<Dispute> UpdateAsync(string disputeId, DisputeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}/{disputeId}", requestOptions, cancellationToken, options);
        }
    }
}
