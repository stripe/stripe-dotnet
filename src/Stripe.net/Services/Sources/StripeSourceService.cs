using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSourceService : StripeBasicService<StripeSource>
    {
        public StripeSourceService(string apiKey = null) : base(apiKey) { }



        // Sync
        public virtual StripeSource Create(StripeSourceCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/sources", requestOptions, options);
        }

        //public virtual StripeSubscriptionItem Get(string subscriptionItemId, StripeRequestOptions requestOptions = null)
        //{
        //    return GetEntity($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions);
        //}

        //public virtual StripeSubscriptionItem Update(string subscriptionItemId, StripeSubscriptionItemUpdateOptions options, StripeRequestOptions requestOptions = null)
        //{
        //    return Post($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, options);
        //}

        //public virtual StripeDeleted Delete(string subscriptionItemId, StripeRequestOptions requestOptions = null)
        //{
        //    return DeleteEntity($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions);
        //}

        //public virtual IEnumerable<StripeSubscriptionItem> List(StripeSubscriptionItemListOptions options = null, StripeRequestOptions requestOptions = null)
        //{
        //    return GetEntityList($"{Urls.BaseUrl}/subscription_items", requestOptions, options);
        //}



        // Async
        public virtual Task<StripeSource> CreateAsync(StripeSourceCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/sources", requestOptions, cancellationToken, options);
        }

        //public virtual Task<StripeSubscriptionItem> GetAsync(string subscriptionItemId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return GetEntityAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken);
        //}

        //public virtual Task<StripeSubscriptionItem> UpdateAsync(string subscriptionItemId, StripeSubscriptionItemUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return PostAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken, options);
        //}

        //public virtual Task<StripeDeleted> DeleteAsync(string subscriptionItemId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return DeleteEntityAsync($"{Urls.BaseUrl}/subscription_items/{subscriptionItemId}", requestOptions, cancellationToken);
        //}

        //public virtual Task<IEnumerable<StripeSubscriptionItem>> ListAsync(StripeSubscriptionItemListOptions options = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    return GetEntityListAsync($"{Urls.BaseUrl}/subscription_items", requestOptions, cancellationToken, options);
        //}
    }
}
