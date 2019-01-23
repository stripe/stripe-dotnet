namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class SubscriptionItemService : Service<SubscriptionItem>,
        ICreatable<SubscriptionItem, SubscriptionItemCreateOptions>,
        IDeletable<SubscriptionItem>,
        IListable<SubscriptionItem, SubscriptionItemListOptions>,
        IRetrievable<SubscriptionItem>,
        IUpdatable<SubscriptionItem, SubscriptionItemUpdateOptions>
    {
        public SubscriptionItemService()
            : base(null)
        {
        }

        public SubscriptionItemService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/subscription_items";

        public virtual SubscriptionItem Create(SubscriptionItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<SubscriptionItem> CreateAsync(SubscriptionItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual SubscriptionItem Delete(string subscriptionItemId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(subscriptionItemId, null, requestOptions);
        }

        public virtual Task<SubscriptionItem> DeleteAsync(string subscriptionItemId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync(subscriptionItemId, null, requestOptions, cancellationToken);
        }

        public virtual SubscriptionItem Get(string subscriptionItemId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(subscriptionItemId, null, requestOptions);
        }

        public virtual Task<SubscriptionItem> GetAsync(string subscriptionItemId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(subscriptionItemId, null, requestOptions, cancellationToken);
        }

        public virtual StripeList<SubscriptionItem> List(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<SubscriptionItem>> ListAsync(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<SubscriptionItem> ListAutoPaging(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual SubscriptionItem Update(string subscriptionItemId, SubscriptionItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(subscriptionItemId, options, requestOptions);
        }

        public virtual Task<SubscriptionItem> UpdateAsync(string subscriptionItemId, SubscriptionItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(subscriptionItemId, options, requestOptions, cancellationToken);
        }
    }
}
