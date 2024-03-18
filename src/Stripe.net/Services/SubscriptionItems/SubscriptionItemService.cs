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
        {
        }

        public SubscriptionItemService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/subscription_items";

        /// <summary>
        /// <p>Adds a new item to an existing subscription. No existing items will be changed or
        /// replaced.</p>.
        /// </summary>
        public virtual SubscriptionItem Create(SubscriptionItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionItem>(HttpMethod.Post, $"/v1/subscription_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Adds a new item to an existing subscription. No existing items will be changed or
        /// replaced.</p>.
        /// </summary>
        public virtual Task<SubscriptionItem> CreateAsync(SubscriptionItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionItem>(HttpMethod.Post, $"/v1/subscription_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deletes an item from the subscription. Removing a subscription item from a
        /// subscription will not cancel the subscription.</p>.
        /// </summary>
        public virtual SubscriptionItem Delete(string id, SubscriptionItemDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionItem>(HttpMethod.Delete, $"/v1/subscription_items/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Deletes an item from the subscription. Removing a subscription item from a
        /// subscription will not cancel the subscription.</p>.
        /// </summary>
        public virtual Task<SubscriptionItem> DeleteAsync(string id, SubscriptionItemDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionItem>(HttpMethod.Delete, $"/v1/subscription_items/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the subscription item with the given ID.</p>.
        /// </summary>
        public virtual SubscriptionItem Get(string id, SubscriptionItemGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionItem>(HttpMethod.Get, $"/v1/subscription_items/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the subscription item with the given ID.</p>.
        /// </summary>
        public virtual Task<SubscriptionItem> GetAsync(string id, SubscriptionItemGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionItem>(HttpMethod.Get, $"/v1/subscription_items/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your subscription items for a given subscription.</p>.
        /// </summary>
        public virtual StripeList<SubscriptionItem> List(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<SubscriptionItem>>(HttpMethod.Get, $"/v1/subscription_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your subscription items for a given subscription.</p>.
        /// </summary>
        public virtual Task<StripeList<SubscriptionItem>> ListAsync(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<SubscriptionItem>>(HttpMethod.Get, $"/v1/subscription_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your subscription items for a given subscription.</p>.
        /// </summary>
        public virtual IEnumerable<SubscriptionItem> ListAutoPaging(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<SubscriptionItem>($"/v1/subscription_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your subscription items for a given subscription.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<SubscriptionItem> ListAutoPagingAsync(SubscriptionItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<SubscriptionItem>($"/v1/subscription_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the plan or quantity of an item on a current subscription.</p>.
        /// </summary>
        public virtual SubscriptionItem Update(string id, SubscriptionItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<SubscriptionItem>(HttpMethod.Post, $"/v1/subscription_items/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the plan or quantity of an item on a current subscription.</p>.
        /// </summary>
        public virtual Task<SubscriptionItem> UpdateAsync(string id, SubscriptionItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SubscriptionItem>(HttpMethod.Post, $"/v1/subscription_items/{id}", options, requestOptions, cancellationToken);
        }
    }
}
