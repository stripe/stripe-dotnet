// File generated from our OpenAPI spec
namespace Stripe.Radar
{
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
            : base(null)
        {
        }

        public ValueListItemService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/radar/value_list_items";

        public virtual ValueListItem Create(ValueListItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ValueListItem>(HttpMethod.Post, $"/v1/radar/value_list_items", options, requestOptions);
        }

        public virtual Task<ValueListItem> CreateAsync(ValueListItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ValueListItem>(HttpMethod.Post, $"/v1/radar/value_list_items", options, requestOptions, cancellationToken);
        }

        public virtual ValueListItem Delete(string id, ValueListItemDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ValueListItem>(HttpMethod.Delete, $"/v1/radar/value_list_items/{id}", options, requestOptions);
        }

        public virtual Task<ValueListItem> DeleteAsync(string id, ValueListItemDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ValueListItem>(HttpMethod.Delete, $"/v1/radar/value_list_items/{id}", options, requestOptions, cancellationToken);
        }

        public virtual ValueListItem Get(string id, ValueListItemGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ValueListItem>(HttpMethod.Get, $"/v1/radar/value_list_items/{id}", options, requestOptions);
        }

        public virtual Task<ValueListItem> GetAsync(string id, ValueListItemGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ValueListItem>(HttpMethod.Get, $"/v1/radar/value_list_items/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ValueListItem> List(ValueListItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ValueListItem>>(HttpMethod.Get, $"/v1/radar/value_list_items", options, requestOptions);
        }

        public virtual Task<StripeList<ValueListItem>> ListAsync(ValueListItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ValueListItem>>(HttpMethod.Get, $"/v1/radar/value_list_items", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ValueListItem> ListAutoPaging(ValueListItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ValueListItem>($"/v1/radar/value_list_items", options, requestOptions);
        }

        public virtual IAsyncEnumerable<ValueListItem> ListAutoPagingAsync(ValueListItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ValueListItem>($"/v1/radar/value_list_items", options, requestOptions, cancellationToken);
        }
    }
}
