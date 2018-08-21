namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class SubscriptionItemService : BasicService<StripeSubscriptionItem>
    {
        public SubscriptionItemService()
            : base(null)
        {
        }

        public SubscriptionItemService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeSubscriptionItem Create(SubscriptionItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/subscription_items", requestOptions, options);
        }

        public virtual StripeSubscriptionItem Get(string subscriptionItemId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions);
        }

        public virtual StripeSubscriptionItem Update(string subscriptionItemId, SubscriptionItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, options);
        }

        public virtual StripeSubscriptionItem Delete(string subscriptionItemId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions);
        }

        public virtual StripeList<StripeSubscriptionItem> List(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/subscription_items", requestOptions, options);
        }

        public virtual Task<StripeSubscriptionItem> CreateAsync(SubscriptionItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/subscription_items", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeSubscriptionItem> GetAsync(string subscriptionItemId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeSubscriptionItem> UpdateAsync(string subscriptionItemId, SubscriptionItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeSubscriptionItem> DeleteAsync(string subscriptionItemId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<StripeSubscriptionItem>> ListAsync(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/subscription_items", requestOptions, cancellationToken, options);
        }
    }
}
