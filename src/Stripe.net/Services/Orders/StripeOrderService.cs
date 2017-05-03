using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeOrderService : StripeBasicService<StripeOrder>
    {
        public StripeOrderService(string apiKey = null) : base(apiKey) { }



        // Sync
        public virtual StripeOrder Create(StripeOrderCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/orders", requestOptions, options);
        }

        //public virtual StripeOrder Get(string payoutId, StripeRequestOptions requestOptions = null)
        //{
        //    return GetEntity($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions);
        //}

        //public virtual StripeOrder Update(string payoutId, StripePayoutUpdateOptions options, StripeRequestOptions requestOptions = null)
        //{
        //    return Post($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions, options);
        //}

        //public virtual IEnumerable<StripeOrder> List(StripePayoutListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        //{
        //    return GetEntityList($"{Urls.BaseUrl}/payouts", requestOptions, listOptions);
        //}



        // Async
        public virtual Task<StripeOrder> CreateAsync(StripeOrderCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/orders", requestOptions, cancellationToken, options);
        }

        //public virtual Task<StripeOrder> GetAsync(string payoutId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return GetEntityAsync($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions, cancellationToken);
        //}

        //public virtual Task<StripeOrder> UpdateAsync(string payoutId, StripePayoutUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return PostAsync($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions, cancellationToken, options);
        //}

        //public virtual Task<IEnumerable<StripeOrder>> ListAsync(StripePayoutListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return GetEntityListAsync($"{Urls.BaseUrl}/payouts", requestOptions, cancellationToken, listOptions);
        //}
    }
}
