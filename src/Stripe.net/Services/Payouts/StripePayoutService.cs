using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripePayoutService : StripeBasicService<StripePayout>
    {
        public StripePayoutService() : base(null) { }
        public StripePayoutService(string apiKey) : base(apiKey) { }

        public bool ExpandBalanceTransaction { get; set; }
        public bool ExpandDestination { get; set; }
        public bool ExpandFailureBalanceTransaction { get; set; }



        // Sync
        public virtual StripePayout Create(StripePayoutCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/payouts", requestOptions, options);
        }

        public virtual StripePayout Get(string payoutId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions);
        }

        public virtual StripePayout Update(string payoutId, StripePayoutUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions, options);
        }

        public virtual StripeList<StripePayout> List(StripePayoutListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.BaseUrl}/payouts", requestOptions, listOptions);
        }

        public virtual StripePayout Cancel(string payoutId, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/payouts/{payoutId}/cancel", requestOptions);
        }



        // Async
        public virtual Task<StripePayout> CreateAsync(StripePayoutCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/payouts", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripePayout> GetAsync(string payoutId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripePayout> UpdateAsync(string payoutId, StripePayoutUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<StripePayout>> ListAsync(StripePayoutListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/payouts", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<StripePayout> CancelAsync(string payoutId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/payouts/{payoutId}/cancel", requestOptions, cancellationToken);
        }
    }
}
