namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class SubscriptionItemService : Service<SubscriptionItem>,
        ICreatable<SubscriptionItem, SubscriptionItemCreateOptions>,
        IDeletable<SubscriptionItem, SubscriptionItemDeleteOptions>,
        IListable<SubscriptionItem, SubscriptionItemListOptions>,
        IRetrievable<SubscriptionItem, SubscriptionItemGetOptions>,
        IUpdatable<SubscriptionItem, SubscriptionItemUpdateOptions>
    {
        public SubscriptionItemService()
            : base(null)
        {
        }

        public SubscriptionItemService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/subscription_items";

        public virtual SubscriptionItem Create(SubscriptionItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<SubscriptionItem> CreateAsync(SubscriptionItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual SubscriptionItem Delete(string id, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, null, requestOptions);
        }

        public virtual Task<SubscriptionItem> DeleteAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(id, null, requestOptions, cancellationToken);
        }

        public virtual SubscriptionItem Get(string id, SubscriptionItemGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<SubscriptionItem> GetAsync(string id, SubscriptionItemGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<SubscriptionItem> List(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<SubscriptionItem>> ListAsync(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<SubscriptionItem> ListAutoPaging(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual SubscriptionItem Update(string id, SubscriptionItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<SubscriptionItem> UpdateAsync(string id, SubscriptionItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual unknown UsageRecordSummaries(string id, SubscriptionItemUsageRecordSummariesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<unknown>(HttpMethod.Get, $"{this.InstanceUrl(id)}/usage_record_summaries", options, requestOptions);
        }

        public virtual Task<unknown> UsageRecordSummariesAsync(string id, SubscriptionItemUsageRecordSummariesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<unknown>(HttpMethod.Get, $"{this.InstanceUrl(id)}/usage_record_summaries", options, requestOptions, cancellationToken);
        }
    }
}
