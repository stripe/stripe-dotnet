// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class LicensedItemService : Service
    {
        internal LicensedItemService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal LicensedItemService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create a Licensed Item object.
        /// </summary>
        public virtual LicensedItem Create(LicensedItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<LicensedItem>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/licensed_items", options, requestOptions);
        }

        /// <summary>
        /// Create a Licensed Item object.
        /// </summary>
        public virtual Task<LicensedItem> CreateAsync(LicensedItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<LicensedItem>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/licensed_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a Licensed Item object.
        /// </summary>
        public virtual LicensedItem Get(string id, LicensedItemGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<LicensedItem>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/licensed_items/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a Licensed Item object.
        /// </summary>
        public virtual Task<LicensedItem> GetAsync(string id, LicensedItemGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<LicensedItem>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/licensed_items/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Licensed Item objects in reverse chronological order of creation.
        /// </summary>
        public virtual V2.StripeList<LicensedItem> List(LicensedItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<LicensedItem>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/licensed_items", options, requestOptions);
        }

        /// <summary>
        /// List all Licensed Item objects in reverse chronological order of creation.
        /// </summary>
        public virtual Task<V2.StripeList<LicensedItem>> ListAsync(LicensedItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<LicensedItem>>(BaseAddress.Api, HttpMethod.Get, $"/v2/billing/licensed_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List all Licensed Item objects in reverse chronological order of creation.
        /// </summary>
        public virtual IEnumerable<LicensedItem> ListAutoPaging(LicensedItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LicensedItem>($"/v2/billing/licensed_items", options, requestOptions);
        }

        /// <summary>
        /// List all Licensed Item objects in reverse chronological order of creation.
        /// </summary>
        public virtual IAsyncEnumerable<LicensedItem> ListAutoPagingAsync(LicensedItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LicensedItem>($"/v2/billing/licensed_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Update a Licensed Item object. At least one of the fields is required.
        /// </summary>
        public virtual LicensedItem Update(string id, LicensedItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<LicensedItem>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/licensed_items/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Update a Licensed Item object. At least one of the fields is required.
        /// </summary>
        public virtual Task<LicensedItem> UpdateAsync(string id, LicensedItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<LicensedItem>(BaseAddress.Api, HttpMethod.Post, $"/v2/billing/licensed_items/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
