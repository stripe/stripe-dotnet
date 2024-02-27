// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class QuotePreviewInvoiceService : ServiceNested<QuotePreviewInvoice>,
        INestedListable<QuotePreviewInvoice, QuotePreviewInvoiceListOptions>
    {
        public QuotePreviewInvoiceService()
            : base(null)
        {
        }

        public QuotePreviewInvoiceService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/quotes/{PARENT_ID}/preview_invoices";

        public virtual StripeList<QuotePreviewInvoice> List(string parentId, QuotePreviewInvoiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<QuotePreviewInvoice>>(HttpMethod.Get, $"/v1/quotes/{parentId}/preview_invoices", options, requestOptions);
        }

        public virtual Task<StripeList<QuotePreviewInvoice>> ListAsync(string parentId, QuotePreviewInvoiceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<QuotePreviewInvoice>>(HttpMethod.Get, $"/v1/quotes/{parentId}/preview_invoices", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<QuotePreviewInvoice> ListAutoPaging(string parentId, QuotePreviewInvoiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<QuotePreviewInvoice>($"/v1/quotes/{parentId}/preview_invoices", options, requestOptions);
        }

        public virtual IAsyncEnumerable<QuotePreviewInvoice> ListAutoPagingAsync(string parentId, QuotePreviewInvoiceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<QuotePreviewInvoice>($"/v1/quotes/{parentId}/preview_invoices", options, requestOptions, cancellationToken);
        }
    }
}
