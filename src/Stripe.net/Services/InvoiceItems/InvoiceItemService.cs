// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InvoiceItemService : Service<InvoiceItem>,
        ICreatable<InvoiceItem, InvoiceItemCreateOptions>,
        IDeletable<InvoiceItem, InvoiceItemDeleteOptions>,
        IListable<InvoiceItem, InvoiceItemListOptions>,
        IRetrievable<InvoiceItem, InvoiceItemGetOptions>,
        IUpdatable<InvoiceItem, InvoiceItemUpdateOptions>
    {
        public InvoiceItemService()
            : base(null)
        {
        }

        public InvoiceItemService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/invoiceitems";

        public virtual InvoiceItem Create(InvoiceItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<InvoiceItem>(HttpMethod.Post, $"/v1/invoiceitems", options, requestOptions);
        }

        public virtual Task<InvoiceItem> CreateAsync(InvoiceItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoiceItem>(HttpMethod.Post, $"/v1/invoiceitems", options, requestOptions, cancellationToken);
        }

        public virtual InvoiceItem Delete(string id, InvoiceItemDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InvoiceItem>(HttpMethod.Delete, $"/v1/invoiceitems/{id}", options, requestOptions);
        }

        public virtual Task<InvoiceItem> DeleteAsync(string id, InvoiceItemDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoiceItem>(HttpMethod.Delete, $"/v1/invoiceitems/{id}", options, requestOptions, cancellationToken);
        }

        public virtual InvoiceItem Get(string id, InvoiceItemGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InvoiceItem>(HttpMethod.Get, $"/v1/invoiceitems/{id}", options, requestOptions);
        }

        public virtual Task<InvoiceItem> GetAsync(string id, InvoiceItemGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoiceItem>(HttpMethod.Get, $"/v1/invoiceitems/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<InvoiceItem> List(InvoiceItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceItem>>(HttpMethod.Get, $"/v1/invoiceitems", options, requestOptions);
        }

        public virtual Task<StripeList<InvoiceItem>> ListAsync(InvoiceItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceItem>>(HttpMethod.Get, $"/v1/invoiceitems", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoiceItem> ListAutoPaging(InvoiceItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceItem>($"/v1/invoiceitems", options, requestOptions);
        }

        public virtual IAsyncEnumerable<InvoiceItem> ListAutoPagingAsync(InvoiceItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceItem>($"/v1/invoiceitems", options, requestOptions, cancellationToken);
        }

        public virtual InvoiceItem Update(string id, InvoiceItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<InvoiceItem>(HttpMethod.Post, $"/v1/invoiceitems/{id}", options, requestOptions);
        }

        public virtual Task<InvoiceItem> UpdateAsync(string id, InvoiceItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoiceItem>(HttpMethod.Post, $"/v1/invoiceitems/{id}", options, requestOptions, cancellationToken);
        }
    }
}
