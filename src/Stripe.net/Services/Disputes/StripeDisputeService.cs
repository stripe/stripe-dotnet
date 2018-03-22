using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeDisputeService : StripeBasicService<StripeDispute>
    {
        public StripeDisputeService() : base(null) { }
        public StripeDisputeService(string apiKey) : base(apiKey) { }

        public bool ExpandCharge { get; set; }



        // Sync
        public virtual StripeDispute Get(string disputeId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.Disputes}/{disputeId}", requestOptions);
        }

        public virtual StripeDispute Update(string disputeId, StripeDisputeUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.Disputes}/{disputeId}", requestOptions, updateOptions);
        }

        public virtual StripeDispute Close(string disputeId, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.Disputes}/{disputeId}/close", requestOptions);
        }

        public virtual StripeList<StripeDispute> List(StripeDisputeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList(Urls.Disputes, requestOptions, listOptions);
        }



        // Async
        public virtual Task<StripeDispute> GetAsync(string disputeId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.Disputes}/{disputeId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeDispute> UpdateAsync(string disputeId, StripeDisputeUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.Disputes}/{disputeId}", requestOptions, cancellationToken, updateOptions);
        }

        public virtual Task<StripeDispute> CloseAsync(string disputeId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.Disputes}/{disputeId}/close", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<StripeDispute>> ListAsync(StripeDisputeListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync(Urls.Disputes, requestOptions, cancellationToken, listOptions);
        }
    }
}
