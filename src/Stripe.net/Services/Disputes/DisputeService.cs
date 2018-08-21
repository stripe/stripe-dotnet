namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class DisputeService : BasicService<StripeDispute>
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

        public virtual StripeDispute Get(string disputeId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.Disputes}/{disputeId}", requestOptions);
        }

        public virtual StripeDispute Update(string disputeId, DisputeUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.Disputes}/{disputeId}", requestOptions, updateOptions);
        }

        public virtual StripeDispute Close(string disputeId, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.Disputes}/{disputeId}/close", requestOptions);
        }

        public virtual StripeList<StripeDispute> List(DisputeListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList(Urls.Disputes, requestOptions, listOptions);
        }

        public virtual Task<StripeDispute> GetAsync(string disputeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.Disputes}/{disputeId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeDispute> UpdateAsync(string disputeId, DisputeUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.Disputes}/{disputeId}", requestOptions, cancellationToken, updateOptions);
        }

        public virtual Task<StripeDispute> CloseAsync(string disputeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.Disputes}/{disputeId}/close", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<StripeDispute>> ListAsync(DisputeListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync(Urls.Disputes, requestOptions, cancellationToken, listOptions);
        }
    }
}
