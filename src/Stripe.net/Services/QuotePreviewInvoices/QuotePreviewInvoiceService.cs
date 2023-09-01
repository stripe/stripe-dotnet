// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
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
    }
}
