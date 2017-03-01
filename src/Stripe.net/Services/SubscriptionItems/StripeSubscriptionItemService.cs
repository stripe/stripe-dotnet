using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSubscriptionItemService : StripeBasicService<StripeSubscriptionItem>
    {
        public StripeSubscriptionItemService(string apiKey = null) : base(apiKey) { }



        // Sync
        public virtual StripeSubscriptionItem Create(StripeSubscriptionCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/subscription_items", requestOptions, options);
        }

        public virtual StripeSubscriptionItem Get(string subscriptionId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/subscription_items/{subscriptionId}", requestOptions);
        }

        public virtual StripeSubscriptionItem Update(string subscriptionId, StripeSubscriptionItemUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/subscription_items/{subscriptionId}", requestOptions, options);
        }

        public virtual StripeDeleted Delete(string subscriptionId, StripeRequestOptions requestOptions = null)
        {
            return DeleteEntity($"{Urls.BaseUrl}/subscription_items/{subscriptionId}", requestOptions);
        }

        public virtual IEnumerable<StripeSubscriptionItem> List(StripeInvoiceItemListOptions options = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.BaseUrl}/subscription_items", requestOptions, options);
        }



        // Async
        public virtual Task<StripeSubscriptionItem> CreateAsync(StripeSubscriptionCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/subscription_items", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeSubscriptionItem> GetAsync(string subscriptionId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeSubscriptionItem> UpdateAsync(string subscriptionId, StripeSubscriptionItemUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeDeleted> DeleteAsync(string subscriptionId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteEntityAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionId}", requestOptions, cancellationToken);
        }

        public virtual Task<IEnumerable<StripeSubscriptionItem>> ListAsync(StripeInvoiceItemListOptions options = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/subscription_items", requestOptions, cancellationToken, options);
        }
    }
}
