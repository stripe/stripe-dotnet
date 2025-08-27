// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class MeteredItemService : Service
    {
        internal MeteredItemService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal MeteredItemService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create a Metered Item object.
        /// </summary>
        public virtual MeteredItem Create(MeteredItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<MeteredItem>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/metered_items", options, requestOptions);
        }

        /// <summary>
        /// Create a Metered Item object.
        /// </summary>
        public virtual Task<MeteredItem> CreateAsync(MeteredItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<MeteredItem>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/metered_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a Metered Item object.
        /// </summary>
        public virtual MeteredItem Get(string id, MeteredItemGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<MeteredItem>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/metered_items/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Metered Item object.
        /// </summary>
        public virtual Task<MeteredItem> GetAsync(string id, MeteredItemGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<MeteredItem>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/metered_items/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Metered Item objects in reverse chronological order of creation.
        /// </summary>
        public virtual V2.StripeList<MeteredItem> List(MeteredItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<MeteredItem>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/metered_items", options, requestOptions);
        }

        /// <summary>
        /// List all Metered Item objects in reverse chronological order of creation.
        /// </summary>
        public virtual Task<V2.StripeList<MeteredItem>> ListAsync(MeteredItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<MeteredItem>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/metered_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Metered Item objects in reverse chronological order of creation.
        /// </summary>
        public virtual IEnumerable<MeteredItem> ListAutoPaging(MeteredItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<MeteredItem>($"/v2/billing/metered_items", options, requestOptions);
        }

        /// <summary>
        /// List all Metered Item objects in reverse chronological order of creation.
        /// </summary>
        public virtual IAsyncEnumerable<MeteredItem> ListAutoPagingAsync(MeteredItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<MeteredItem>($"/v2/billing/metered_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a Metered Item object. At least one of the fields is required.
        /// </summary>
        public virtual MeteredItem Update(string id, MeteredItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<MeteredItem>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/metered_items/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a Metered Item object. At least one of the fields is required.
        /// </summary>
        public virtual Task<MeteredItem> UpdateAsync(string id, MeteredItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<MeteredItem>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/metered_items/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
