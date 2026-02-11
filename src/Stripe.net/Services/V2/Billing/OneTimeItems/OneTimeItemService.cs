// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OneTimeItemService : Service
    {
        internal OneTimeItemService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal OneTimeItemService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create a One-Time Item object.
        /// </summary>
        public virtual OneTimeItem Create(OneTimeItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<OneTimeItem>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/one_time_items", options, requestOptions);
        }

        /// <summary>
        /// Create a One-Time Item object.
        /// </summary>
        public virtual Task<OneTimeItem> CreateAsync(OneTimeItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OneTimeItem>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/one_time_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a One-Time Item object.
        /// </summary>
        public virtual OneTimeItem Get(string id, OneTimeItemGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OneTimeItem>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/one_time_items/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a One-Time Item object.
        /// </summary>
        public virtual Task<OneTimeItem> GetAsync(string id, OneTimeItemGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OneTimeItem>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/one_time_items/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all One-Time Item objects in reverse chronological order of creation.
        /// </summary>
        public virtual V2.StripeList<OneTimeItem> List(OneTimeItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<OneTimeItem>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/one_time_items", options, requestOptions);
        }

        /// <summary>
        /// List all One-Time Item objects in reverse chronological order of creation.
        /// </summary>
        public virtual Task<V2.StripeList<OneTimeItem>> ListAsync(OneTimeItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<OneTimeItem>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/one_time_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all One-Time Item objects in reverse chronological order of creation.
        /// </summary>
        public virtual IEnumerable<OneTimeItem> ListAutoPaging(OneTimeItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<OneTimeItem>($"/v2/billing/one_time_items", options, requestOptions);
        }

        /// <summary>
        /// List all One-Time Item objects in reverse chronological order of creation.
        /// </summary>
        public virtual IAsyncEnumerable<OneTimeItem> ListAutoPagingAsync(OneTimeItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<OneTimeItem>($"/v2/billing/one_time_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a One-Time Item object.
        /// </summary>
        public virtual OneTimeItem Update(string id, OneTimeItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<OneTimeItem>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/one_time_items/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a One-Time Item object.
        /// </summary>
        public virtual Task<OneTimeItem> UpdateAsync(string id, OneTimeItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OneTimeItem>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/one_time_items/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
