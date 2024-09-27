namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class InvoiceService
    {
        /// <summary>
        /// <p>When retrieving an invoice, you’ll get a <strong>lines</strong> property containing
        /// the total count of line items and the first handful of those items. There is also a URL
        /// where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use InvoiceLineItemService.List instead.")]
        public virtual StripeList<InvoiceLineItem> ListLineItems(string id, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/{id}/lines", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an invoice, you’ll get a <strong>lines</strong> property containing
        /// the total count of line items and the first handful of those items. There is also a URL
        /// where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use InvoiceLineItemService.ListAsync instead.")]
        public virtual Task<StripeList<InvoiceLineItem>> ListLineItemsAsync(string id, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/{id}/lines", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an invoice, you’ll get a <strong>lines</strong> property containing
        /// the total count of line items and the first handful of those items. There is also a URL
        /// where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use InvoiceLineItemService.ListAutoPaging instead.")]
        public virtual IEnumerable<InvoiceLineItem> ListLineItemsAutoPaging(string id, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"/v1/invoices/{id}/lines", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an invoice, you’ll get a <strong>lines</strong> property containing
        /// the total count of line items and the first handful of those items. There is also a URL
        /// where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use InvoiceLineItemService.ListAutoPagingAsync instead.")]
        public virtual IAsyncEnumerable<InvoiceLineItem> ListLineItemsAutoPagingAsync(string id, InvoiceListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceLineItem>($"/v1/invoices/{id}/lines", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an upcoming invoice, you’ll get a <strong>lines</strong> property
        /// containing the total count of line items and the first handful of those items. There is
        /// also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use InvoiceLineItemService.ListUpcomingLineItems instead.")]
        public virtual StripeList<InvoiceLineItem> ListUpcomingLineItems(InvoiceUpcomingLinesListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/upcoming/lines", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an upcoming invoice, you’ll get a <strong>lines</strong> property
        /// containing the total count of line items and the first handful of those items. There is
        /// also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use InvoiceLineItemService.ListUpcomingLineItemsAsync instead.")]
        public virtual Task<StripeList<InvoiceLineItem>> ListUpcomingLineItemsAsync(InvoiceUpcomingLinesListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/upcoming/lines", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an upcoming invoice, you’ll get a <strong>lines</strong> property
        /// containing the total count of line items and the first handful of those items. There is
        /// also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use InvoiceLineItemService.ListUpcomingLineItemsAutoPaging instead.")]
        public virtual IEnumerable<InvoiceLineItem> ListUpcomingLineItemsAutoPaging(InvoiceUpcomingLinesListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"/v1/invoices/upcoming/lines", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an upcoming invoice, you’ll get a <strong>lines</strong> property
        /// containing the total count of line items and the first handful of those items. There is
        /// also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use InvoiceLineItemService.ListUpcomingLineItemsAutoPagingAsync instead.")]
        public virtual IAsyncEnumerable<InvoiceLineItem> ListUpcomingLineItemsAutoPagingAsync(InvoiceUpcomingLinesListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceLineItem>($"/v1/invoices/upcoming/lines", options, requestOptions, cancellationToken);
        }
    }
}
