namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class StripeSubscriptionItemService : StripeBasicService<StripeSubscriptionItem>
    {
        public StripeSubscriptionItemService()
            : base(null)
        {
        }

        public StripeSubscriptionItemService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeSubscriptionItem Create(StripeSubscriptionItemCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/subscription_items", requestOptions, options);
        }

        public virtual StripeSubscriptionItem Get(string subscriptionItemId, StripeRequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions);
        }

        public virtual StripeSubscriptionItem Update(string subscriptionItemId, StripeSubscriptionItemUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, options);
        }

        public virtual StripeSubscriptionItem Delete(string subscriptionItemId, StripeRequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions);
        }

        public virtual StripeList<StripeSubscriptionItem> List(StripeSubscriptionItemListOptions options = null, StripeRequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/subscription_items", requestOptions, options);
        }

        public virtual Task<StripeSubscriptionItem> CreateAsync(StripeSubscriptionItemCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/subscription_items", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeSubscriptionItem> GetAsync(string subscriptionItemId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeSubscriptionItem> UpdateAsync(string subscriptionItemId, StripeSubscriptionItemUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeSubscriptionItem> DeleteAsync(string subscriptionItemId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<StripeSubscriptionItem>> ListAsync(StripeSubscriptionItemListOptions options = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/subscription_items", requestOptions, cancellationToken, options);
        }
    }
}
