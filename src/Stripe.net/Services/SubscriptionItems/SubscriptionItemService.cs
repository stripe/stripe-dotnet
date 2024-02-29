// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

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

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/subscription_items";

        public virtual SubscriptionItem Create(SubscriptionItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionItem>(HttpMethod.Post, $"/v1/subscription_items", options, requestOptions);
        }

        public virtual Task<SubscriptionItem> CreateAsync(SubscriptionItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionItem>(HttpMethod.Post, $"/v1/subscription_items", options, requestOptions, cancellationToken);
        }

        public virtual SubscriptionItem Delete(string id, SubscriptionItemDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionItem>(HttpMethod.Delete, $"/v1/subscription_items/{id}", options, requestOptions);
        }

        public virtual Task<SubscriptionItem> DeleteAsync(string id, SubscriptionItemDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionItem>(HttpMethod.Delete, $"/v1/subscription_items/{id}", options, requestOptions, cancellationToken);
        }

        public virtual SubscriptionItem Get(string id, SubscriptionItemGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionItem>(HttpMethod.Get, $"/v1/subscription_items/{id}", options, requestOptions);
        }

        public virtual Task<SubscriptionItem> GetAsync(string id, SubscriptionItemGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionItem>(HttpMethod.Get, $"/v1/subscription_items/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<SubscriptionItem> List(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<SubscriptionItem>>(HttpMethod.Get, $"/v1/subscription_items", options, requestOptions);
        }

        public virtual Task<StripeList<SubscriptionItem>> ListAsync(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<SubscriptionItem>>(HttpMethod.Get, $"/v1/subscription_items", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<SubscriptionItem> ListAutoPaging(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<SubscriptionItem>($"/v1/subscription_items", options, requestOptions);
        }

        public virtual IAsyncEnumerable<SubscriptionItem> ListAutoPagingAsync(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<SubscriptionItem>($"/v1/subscription_items", options, requestOptions, cancellationToken);
        }

        public virtual SubscriptionItem Update(string id, SubscriptionItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionItem>(HttpMethod.Post, $"/v1/subscription_items/{id}", options, requestOptions);
        }

        public virtual Task<SubscriptionItem> UpdateAsync(string id, SubscriptionItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionItem>(HttpMethod.Post, $"/v1/subscription_items/{id}", options, requestOptions, cancellationToken);
        }
    }
}
