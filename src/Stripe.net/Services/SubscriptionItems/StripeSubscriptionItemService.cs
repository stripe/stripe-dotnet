using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSubscriptionItemService : StripeBasicService<StripeSubscriptionItem>
    {
        public StripeSubscriptionItemService() : base(null) { }
        public StripeSubscriptionItemService(string apiKey) : base(apiKey) { }



        // Sync
        public virtual StripeSubscriptionItem Create(StripeSubscriptionItemCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/subscription_items", requestOptions, options);
        }

        public virtual StripeSubscriptionItem Get(string subscriptionItemId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions);
        }

        public virtual StripeSubscriptionItem Update(string subscriptionItemId, StripeSubscriptionItemUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, options);
        }

        public virtual StripeDeleted Delete(string subscriptionItemId, StripeRequestOptions requestOptions = null)
        {
            return DeleteEntity($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions);
        }

        public virtual StripeList<StripeSubscriptionItem> List(StripeSubscriptionItemListOptions options = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.BaseUrl}/subscription_items", requestOptions, options);
        }



        // Async
        public virtual Task<StripeSubscriptionItem> CreateAsync(StripeSubscriptionItemCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/subscription_items", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeSubscriptionItem> GetAsync(string subscriptionItemId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeSubscriptionItem> UpdateAsync(string subscriptionItemId, StripeSubscriptionItemUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeDeleted> DeleteAsync(string subscriptionItemId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteEntityAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<StripeSubscriptionItem>> ListAsync(StripeSubscriptionItemListOptions options = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/subscription_items", requestOptions, cancellationToken, options);
        }
    }
}
