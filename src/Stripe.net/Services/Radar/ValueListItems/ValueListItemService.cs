// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ValueListItemService : Service<ValueListItem>,
        ICreatable<ValueListItem, ValueListItemCreateOptions>,
        IDeletable<ValueListItem, ValueListItemDeleteOptions>,
        IListable<ValueListItem, ValueListItemListOptions>,
        IRetrievable<ValueListItem, ValueListItemGetOptions>
    {
        public ValueListItemService()
        {
        }

        public ValueListItemService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/radar/value_list_items";

        /// <summary>
        /// <p>Creates a new <c>ValueListItem</c> object, which is added to the specified parent
        /// value list.</p>.
        /// </summary>
        public virtual ValueListItem Create(ValueListItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ValueListItem>(HttpMethod.Post, $"/v1/radar/value_list_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new <c>ValueListItem</c> object, which is added to the specified parent
        /// value list.</p>.
        /// </summary>
        public virtual Task<ValueListItem> CreateAsync(ValueListItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ValueListItem>(HttpMethod.Post, $"/v1/radar/value_list_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deletes a <c>ValueListItem</c> object, removing it from its parent value list.</p>.
        /// </summary>
        public virtual ValueListItem Delete(string id, ValueListItemDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ValueListItem>(HttpMethod.Delete, $"/v1/radar/value_list_items/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Deletes a <c>ValueListItem</c> object, removing it from its parent value list.</p>.
        /// </summary>
        public virtual Task<ValueListItem> DeleteAsync(string id, ValueListItemDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ValueListItem>(HttpMethod.Delete, $"/v1/radar/value_list_items/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a <c>ValueListItem</c> object.</p>.
        /// </summary>
        public virtual ValueListItem Get(string id, ValueListItemGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ValueListItem>(HttpMethod.Get, $"/v1/radar/value_list_items/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a <c>ValueListItem</c> object.</p>.
        /// </summary>
        public virtual Task<ValueListItem> GetAsync(string id, ValueListItemGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ValueListItem>(HttpMethod.Get, $"/v1/radar/value_list_items/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of <c>ValueListItem</c> objects. The objects are sorted in descending
        /// order by creation date, with the most recently created object appearing first.</p>.
        /// </summary>
        public virtual StripeList<ValueListItem> List(ValueListItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ValueListItem>>(HttpMethod.Get, $"/v1/radar/value_list_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of <c>ValueListItem</c> objects. The objects are sorted in descending
        /// order by creation date, with the most recently created object appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<ValueListItem>> ListAsync(ValueListItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ValueListItem>>(HttpMethod.Get, $"/v1/radar/value_list_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of <c>ValueListItem</c> objects. The objects are sorted in descending
        /// order by creation date, with the most recently created object appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<ValueListItem> ListAutoPaging(ValueListItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ValueListItem>($"/v1/radar/value_list_items", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of <c>ValueListItem</c> objects. The objects are sorted in descending
        /// order by creation date, with the most recently created object appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<ValueListItem> ListAutoPagingAsync(ValueListItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ValueListItem>($"/v1/radar/value_list_items", options, requestOptions, cancellationToken);
        }
    }
}
