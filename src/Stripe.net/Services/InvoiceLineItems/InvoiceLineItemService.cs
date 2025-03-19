// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InvoiceLineItemService : Service,
        INestedListable<InvoiceLineItem, InvoiceLineItemListOptions>,
        INestedUpdatable<InvoiceLineItem, InvoiceLineItemUpdateOptions>
    {
        public InvoiceLineItemService()
        {
        }

        internal InvoiceLineItemService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public InvoiceLineItemService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>When retrieving an invoice, you’ll get a <strong>lines</strong> property containing
        /// the total count of line items and the first handful of those items. There is also a URL
        /// where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual StripeList<InvoiceLineItem> List(string parentId, InvoiceLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/{WebUtility.UrlEncode(parentId)}/lines", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an invoice, you’ll get a <strong>lines</strong> property containing
        /// the total count of line items and the first handful of those items. There is also a URL
        /// where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual Task<StripeList<InvoiceLineItem>> ListAsync(string parentId, InvoiceLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/{WebUtility.UrlEncode(parentId)}/lines", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an invoice, you’ll get a <strong>lines</strong> property containing
        /// the total count of line items and the first handful of those items. There is also a URL
        /// where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IEnumerable<InvoiceLineItem> ListAutoPaging(string parentId, InvoiceLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"/v1/invoices/{WebUtility.UrlEncode(parentId)}/lines", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an invoice, you’ll get a <strong>lines</strong> property containing
        /// the total count of line items and the first handful of those items. There is also a URL
        /// where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<InvoiceLineItem> ListAutoPagingAsync(string parentId, InvoiceLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceLineItem>($"/v1/invoices/{WebUtility.UrlEncode(parentId)}/lines", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates an invoice’s line item. Some fields, such as <c>tax_amounts</c>, only live on
        /// the invoice line item, so they can only be updated through this endpoint. Other fields,
        /// such as <c>amount</c>, live on both the invoice item and the invoice line item, so
        /// updates on this endpoint will propagate to the invoice item as well. Updating an
        /// invoice’s line item is only possible before the invoice is finalized.</p>.
        /// </summary>
        public virtual InvoiceLineItem Update(string parentId, string id, InvoiceLineItemUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<InvoiceLineItem>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(parentId)}/lines/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates an invoice’s line item. Some fields, such as <c>tax_amounts</c>, only live on
        /// the invoice line item, so they can only be updated through this endpoint. Other fields,
        /// such as <c>amount</c>, live on both the invoice item and the invoice line item, so
        /// updates on this endpoint will propagate to the invoice item as well. Updating an
        /// invoice’s line item is only possible before the invoice is finalized.</p>.
        /// </summary>
        public virtual Task<InvoiceLineItem> UpdateAsync(string parentId, string id, InvoiceLineItemUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InvoiceLineItem>(BaseAddress.Api, HttpMethod.Post, $"/v1/invoices/{WebUtility.UrlEncode(parentId)}/lines/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
