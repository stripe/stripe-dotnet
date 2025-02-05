// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InvoiceUpcomingLinesService : Service
    {
        public InvoiceUpcomingLinesService()
        {
        }

        internal InvoiceUpcomingLinesService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public InvoiceUpcomingLinesService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>When retrieving an upcoming invoice, you’ll get a <strong>lines</strong> property
        /// containing the total count of line items and the first handful of those items. There is
        /// also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual StripeList<InvoiceLineItem> List(InvoiceUpcomingLinesListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/upcoming/lines", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an upcoming invoice, you’ll get a <strong>lines</strong> property
        /// containing the total count of line items and the first handful of those items. There is
        /// also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual Task<StripeList<InvoiceLineItem>> ListAsync(InvoiceUpcomingLinesListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/invoices/upcoming/lines", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an upcoming invoice, you’ll get a <strong>lines</strong> property
        /// containing the total count of line items and the first handful of those items. There is
        /// also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IEnumerable<InvoiceLineItem> ListAutoPaging(InvoiceUpcomingLinesListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"/v1/invoices/upcoming/lines", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an upcoming invoice, you’ll get a <strong>lines</strong> property
        /// containing the total count of line items and the first handful of those items. There is
        /// also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<InvoiceLineItem> ListAutoPagingAsync(InvoiceUpcomingLinesListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceLineItem>($"/v1/invoices/upcoming/lines", options, requestOptions, cancellationToken);
        }
    }
}
