namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class PayoutService : BasicService<StripePayout>
    {
        public PayoutService()
            : base(null)
        {
        }

        public PayoutService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandDestination { get; set; }

        public bool ExpandFailureBalanceTransaction { get; set; }

        public virtual StripePayout Create(PayoutCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/payouts", requestOptions, options);
        }

        public virtual StripePayout Get(string payoutId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions);
        }

        public virtual StripePayout Update(string payoutId, PayoutUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions, options);
        }

        public virtual StripeList<StripePayout> List(PayoutListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/payouts", requestOptions, listOptions);
        }

        public virtual StripePayout Cancel(string payoutId, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/payouts/{payoutId}/cancel", requestOptions);
        }

        public virtual Task<StripePayout> CreateAsync(PayoutCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/payouts", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripePayout> GetAsync(string payoutId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripePayout> UpdateAsync(string payoutId, PayoutUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<StripePayout>> ListAsync(PayoutListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/payouts", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<StripePayout> CancelAsync(string payoutId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/payouts/{payoutId}/cancel", requestOptions, cancellationToken);
        }
    }
}
