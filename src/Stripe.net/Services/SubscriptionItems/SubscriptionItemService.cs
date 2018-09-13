namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class SubscriptionItemService : BasicService<SubscriptionItem>
    {
        public SubscriptionItemService()
            : base(null)
        {
        }

        public SubscriptionItemService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual SubscriptionItem Create(SubscriptionItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/subscription_items", requestOptions, options);
        }

        public virtual SubscriptionItem Get(string subscriptionItemId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions);
        }

        public virtual SubscriptionItem Update(string subscriptionItemId, SubscriptionItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, options);
        }

        public virtual SubscriptionItem Delete(string subscriptionItemId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions);
        }

        public virtual StripeList<SubscriptionItem> List(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/subscription_items", requestOptions, options);
        }

        public virtual Task<SubscriptionItem> CreateAsync(SubscriptionItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/subscription_items", requestOptions, cancellationToken, options);
        }

        public virtual Task<SubscriptionItem> GetAsync(string subscriptionItemId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken);
        }

        public virtual Task<SubscriptionItem> UpdateAsync(string subscriptionItemId, SubscriptionItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<SubscriptionItem> DeleteAsync(string subscriptionItemId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<SubscriptionItem>> ListAsync(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/subscription_items", requestOptions, cancellationToken, options);
        }
    }
}
