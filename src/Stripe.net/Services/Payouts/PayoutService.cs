namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class PayoutService : BasicService<Payout>,
        ICreatable<Payout, PayoutCreateOptions>,
        IListable<Payout, PayoutListOptions>,
        IRetrievable<Payout>,
        IUpdatable<Payout, PayoutUpdateOptions>
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

        public virtual Payout Create(PayoutCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/payouts", requestOptions, options);
        }

        public virtual Payout Get(string payoutId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions);
        }

        public virtual Payout Update(string payoutId, PayoutUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions, options);
        }

        public virtual StripeList<Payout> List(PayoutListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/payouts", requestOptions, listOptions);
        }

        public virtual Payout Cancel(string payoutId, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/payouts/{payoutId}/cancel", requestOptions);
        }

        public virtual Task<Payout> CreateAsync(PayoutCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/payouts", requestOptions, cancellationToken, options);
        }

        public virtual Task<Payout> GetAsync(string payoutId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions, cancellationToken);
        }

        public virtual Task<Payout> UpdateAsync(string payoutId, PayoutUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/payouts/{payoutId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<Payout>> ListAsync(PayoutListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/payouts", requestOptions, cancellationToken, listOptions);
        }

        public virtual Task<Payout> CancelAsync(string payoutId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/payouts/{payoutId}/cancel", requestOptions, cancellationToken);
        }
    }
}
