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
        {
        }

        public InvoiceItemService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/invoiceitems";

        /// <summary>
        /// <p>Creates an item to be added to a draft invoice (up to 250 items per invoice). If no
        /// invoice is specified, the item will be on the next invoice created for the customer
        /// specified.</p>.
        /// </summary>
        public virtual InvoiceItem Create(InvoiceItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<InvoiceItem>(HttpMethod.Post, $"/v1/invoiceitems", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates an item to be added to a draft invoice (up to 250 items per invoice). If no
        /// invoice is specified, the item will be on the next invoice created for the customer
        /// specified.</p>.
        /// </summary>
        public virtual Task<InvoiceItem> CreateAsync(InvoiceItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoiceItem>(HttpMethod.Post, $"/v1/invoiceitems", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deletes an invoice item, removing it from an invoice. Deleting invoice items is only
        /// possible when they’re not attached to invoices, or if it’s attached to a draft
        /// invoice.</p>.
        /// </summary>
        public virtual InvoiceItem Delete(string id, InvoiceItemDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InvoiceItem>(HttpMethod.Delete, $"/v1/invoiceitems/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Deletes an invoice item, removing it from an invoice. Deleting invoice items is only
        /// possible when they’re not attached to invoices, or if it’s attached to a draft
        /// invoice.</p>.
        /// </summary>
        public virtual Task<InvoiceItem> DeleteAsync(string id, InvoiceItemDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoiceItem>(HttpMethod.Delete, $"/v1/invoiceitems/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the invoice item with the given ID.</p>.
        /// </summary>
        public virtual InvoiceItem Get(string id, InvoiceItemGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InvoiceItem>(HttpMethod.Get, $"/v1/invoiceitems/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the invoice item with the given ID.</p>.
        /// </summary>
        public virtual Task<InvoiceItem> GetAsync(string id, InvoiceItemGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoiceItem>(HttpMethod.Get, $"/v1/invoiceitems/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your invoice items. Invoice items are returned sorted by creation
        /// date, with the most recently created invoice items appearing first.</p>.
        /// </summary>
        public virtual StripeList<InvoiceItem> List(InvoiceItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceItem>>(HttpMethod.Get, $"/v1/invoiceitems", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your invoice items. Invoice items are returned sorted by creation
        /// date, with the most recently created invoice items appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<InvoiceItem>> ListAsync(InvoiceItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceItem>>(HttpMethod.Get, $"/v1/invoiceitems", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your invoice items. Invoice items are returned sorted by creation
        /// date, with the most recently created invoice items appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<InvoiceItem> ListAutoPaging(InvoiceItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceItem>($"/v1/invoiceitems", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your invoice items. Invoice items are returned sorted by creation
        /// date, with the most recently created invoice items appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<InvoiceItem> ListAutoPagingAsync(InvoiceItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceItem>($"/v1/invoiceitems", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the amount or description of an invoice item on an upcoming invoice. Updating
        /// an invoice item is only possible before the invoice it’s attached to is closed.</p>.
        /// </summary>
        public virtual InvoiceItem Update(string id, InvoiceItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<InvoiceItem>(HttpMethod.Post, $"/v1/invoiceitems/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the amount or description of an invoice item on an upcoming invoice. Updating
        /// an invoice item is only possible before the invoice it’s attached to is closed.</p>.
        /// </summary>
        public virtual Task<InvoiceItem> UpdateAsync(string id, InvoiceItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoiceItem>(HttpMethod.Post, $"/v1/invoiceitems/{id}", options, requestOptions, cancellationToken);
        }
    }
}
