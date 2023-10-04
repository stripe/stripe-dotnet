// File generated from our OpenAPI spec
namespace Stripe
{
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

        public override string BasePath => "/v1/quotes/{PARENT_ID}/preview_invoices";

        public virtual StripeList<QuotePreviewInvoice> List(string parentId, QuotePreviewInvoiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntities(parentId, options, requestOptions);
        }

        public virtual Task<StripeList<QuotePreviewInvoice>> ListAsync(string parentId, QuotePreviewInvoiceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<QuotePreviewInvoice> ListAutoPaging(string parentId, QuotePreviewInvoiceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListNestedEntitiesAutoPaging(parentId, options, requestOptions);
        }

        public virtual IAsyncEnumerable<QuotePreviewInvoice> ListAutoPagingAsync(string parentId, QuotePreviewInvoiceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListNestedEntitiesAutoPagingAsync(parentId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<InvoiceLineItem> ListLines(string id, string preview_invoice, QuotePreviewInvoiceListLinesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/lines", options, requestOptions);
        }

        public virtual Task<StripeList<InvoiceLineItem>> ListLinesAsync(string id, string preview_invoice, QuotePreviewInvoiceListLinesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoiceLineItem> ListLinesAutoPaging(string id, string preview_invoice, QuotePreviewInvoiceListLinesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"{this.InstanceUrl(id)}/lines", options, requestOptions);
        }

        public virtual IAsyncEnumerable<InvoiceLineItem> ListLinesAutoPagingAsync(string id, string preview_invoice, QuotePreviewInvoiceListLinesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceLineItem>($"{this.InstanceUrl(id)}/lines", options, requestOptions, cancellationToken);
        }
    }
}
