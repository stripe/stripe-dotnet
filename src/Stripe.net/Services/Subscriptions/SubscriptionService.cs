namespace Stripe
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public partial class SubscriptionService : Service<Subscription>,
        ICreatable<Subscription, SubscriptionCreateOptions>,
        IListable<Subscription, SubscriptionListOptions>,
        IRetrievable<Subscription>,
        IUpdatable<Subscription, SubscriptionUpdateOptions>
    {
        public SubscriptionService()
            : base(null)
        {
        }

        public SubscriptionService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandCustomer { get; set; }

        public virtual Subscription Cancel(string subscriptionId, SubscriptionCancelOptions options, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/subscriptions/{subscriptionId}", requestOptions, options);
        }

        public virtual Subscription Create(SubscriptionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/subscriptions", requestOptions, options);
        }

        public virtual Subscription Get(string subscriptionId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/subscriptions/{subscriptionId}", requestOptions);
        }

        public virtual StripeList<Subscription> List(SubscriptionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/subscriptions", requestOptions, options);
        }

        public virtual Subscription Update(string subscriptionId, SubscriptionUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/subscriptions/{subscriptionId}", requestOptions, options);
        }

        public virtual Task<Subscription> CancelAsync(string subscriptionId, SubscriptionCancelOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/subscriptions/{subscriptionId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<Subscription> CreateAsync(SubscriptionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/subscriptions", requestOptions, cancellationToken, options);
        }

        public virtual Task<Subscription> GetAsync(string subscriptionId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/subscriptions/{subscriptionId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<Subscription>> ListAsync(SubscriptionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/subscriptions", requestOptions, cancellationToken, options);
        }

        public virtual Task<Subscription> UpdateAsync(string subscriptionId, SubscriptionUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/subscriptions/{subscriptionId}", requestOptions, cancellationToken, options);
        }
    }
}
