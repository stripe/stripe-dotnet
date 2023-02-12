// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class QuoteService : Service<Quote>,
        ICreatable<Quote, QuoteCreateOptions>,
        IListable<Quote, QuoteListOptions>,
        IRetrievable<Quote, QuoteGetOptions>,
        IUpdatable<Quote, QuoteUpdateOptions>
    {
        public QuoteService()
            : base(null)
        {
        }

        public QuoteService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/quotes";

        public virtual Quote Accept(string id, QuoteAcceptOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/accept", options, requestOptions);
        }

        public virtual Task<Quote> AcceptAsync(string id, QuoteAcceptOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/accept", options, requestOptions, cancellationToken);
        }

        public virtual Quote Cancel(string id, QuoteCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions);
        }

        public virtual Task<Quote> CancelAsync(string id, QuoteCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual Quote Create(QuoteCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Quote> CreateAsync(QuoteCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Quote DraftQuote(string id, QuoteDraftQuoteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/mark_draft", options, requestOptions);
        }

        public virtual Task<Quote> DraftQuoteAsync(string id, QuoteDraftQuoteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/mark_draft", options, requestOptions, cancellationToken);
        }

        public virtual Quote FinalizeQuote(string id, QuoteFinalizeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/finalize", options, requestOptions);
        }

        public virtual Task<Quote> FinalizeQuoteAsync(string id, QuoteFinalizeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/finalize", options, requestOptions, cancellationToken);
        }

        public virtual Quote Get(string id, QuoteGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Quote> GetAsync(string id, QuoteGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Quote> List(QuoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Quote>> ListAsync(QuoteListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Quote> ListAutoPaging(QuoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<Quote> ListAutoPagingAsync(QuoteListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual StripeList<LineItem> ListComputedUpfrontLineItems(string id, QuoteListComputedUpfrontLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/computed_upfront_line_items", options, requestOptions);
        }

        public virtual Task<StripeList<LineItem>> ListComputedUpfrontLineItemsAsync(string id, QuoteListComputedUpfrontLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/computed_upfront_line_items", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<LineItem> ListComputedUpfrontLineItemsAutoPaging(string id, QuoteListComputedUpfrontLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"{this.InstanceUrl(id)}/computed_upfront_line_items", options, requestOptions);
        }

        public virtual IAsyncEnumerable<LineItem> ListComputedUpfrontLineItemsAutoPagingAsync(string id, QuoteListComputedUpfrontLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"{this.InstanceUrl(id)}/computed_upfront_line_items", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<LineItem> ListLineItems(string id, QuoteListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/line_items", options, requestOptions);
        }

        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, QuoteListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, QuoteListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"{this.InstanceUrl(id)}/line_items", options, requestOptions);
        }

        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, QuoteListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"{this.InstanceUrl(id)}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<QuoteLine> ListLines(string id, QuoteListLinesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<QuoteLine>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/lines", options, requestOptions);
        }

        public virtual Task<StripeList<QuoteLine>> ListLinesAsync(string id, QuoteListLinesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<QuoteLine>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<QuoteLine> ListLinesAutoPaging(string id, QuoteListLinesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<QuoteLine>($"{this.InstanceUrl(id)}/lines", options, requestOptions);
        }

        public virtual IAsyncEnumerable<QuoteLine> ListLinesAutoPagingAsync(string id, QuoteListLinesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<QuoteLine>($"{this.InstanceUrl(id)}/lines", options, requestOptions, cancellationToken);
        }

        public virtual Quote MarkStaleQuote(string id, QuoteMarkStaleQuoteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/mark_stale", options, requestOptions);
        }

        public virtual Task<Quote> MarkStaleQuoteAsync(string id, QuoteMarkStaleQuoteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/mark_stale", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<InvoiceLineItem> PreviewInvoiceLines(string id, QuotePreviewInvoiceLinesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/preview_invoice_lines", options, requestOptions);
        }

        public virtual Task<StripeList<InvoiceLineItem>> PreviewInvoiceLinesAsync(string id, QuotePreviewInvoiceLinesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/preview_invoice_lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoiceLineItem> PreviewInvoiceLinesAutoPaging(string id, QuotePreviewInvoiceLinesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"{this.InstanceUrl(id)}/preview_invoice_lines", options, requestOptions);
        }

        public virtual IAsyncEnumerable<InvoiceLineItem> PreviewInvoiceLinesAutoPagingAsync(string id, QuotePreviewInvoiceLinesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceLineItem>($"{this.InstanceUrl(id)}/preview_invoice_lines", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Invoice> PreviewInvoices(string id, QuotePreviewInvoicesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Invoice>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/preview_invoices", options, requestOptions);
        }

        public virtual Task<StripeList<Invoice>> PreviewInvoicesAsync(string id, QuotePreviewInvoicesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Invoice>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/preview_invoices", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Invoice> PreviewInvoicesAutoPaging(string id, QuotePreviewInvoicesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Invoice>($"{this.InstanceUrl(id)}/preview_invoices", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Invoice> PreviewInvoicesAutoPagingAsync(string id, QuotePreviewInvoicesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Invoice>($"{this.InstanceUrl(id)}/preview_invoices", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<SubscriptionSchedule> PreviewSubscriptionSchedules(string id, QuotePreviewSubscriptionSchedulesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<SubscriptionSchedule>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/preview_subscription_schedules", options, requestOptions);
        }

        public virtual Task<StripeList<SubscriptionSchedule>> PreviewSubscriptionSchedulesAsync(string id, QuotePreviewSubscriptionSchedulesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<SubscriptionSchedule>>(HttpMethod.Get, $"{this.InstanceUrl(id)}/preview_subscription_schedules", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<SubscriptionSchedule> PreviewSubscriptionSchedulesAutoPaging(string id, QuotePreviewSubscriptionSchedulesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<SubscriptionSchedule>($"{this.InstanceUrl(id)}/preview_subscription_schedules", options, requestOptions);
        }

        public virtual IAsyncEnumerable<SubscriptionSchedule> PreviewSubscriptionSchedulesAutoPagingAsync(string id, QuotePreviewSubscriptionSchedulesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<SubscriptionSchedule>($"{this.InstanceUrl(id)}/preview_subscription_schedules", options, requestOptions, cancellationToken);
        }

        public virtual Quote Reestimate(string id, QuoteReestimateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/reestimate", options, requestOptions);
        }

        public virtual Task<Quote> ReestimateAsync(string id, QuoteReestimateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/reestimate", options, requestOptions, cancellationToken);
        }

        public virtual Quote Update(string id, QuoteUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Quote> UpdateAsync(string id, QuoteUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual Stream Pdf(string id, QuotePdfOptions options = null, RequestOptions requestOptions = null)
        {
            requestOptions = this.SetupRequestOptionsForPdfRequest(requestOptions);
            return this.RequestStreaming(HttpMethod.Get, $"{this.InstanceUrl(id)}/pdf", options, requestOptions);
        }

        public virtual Task<Stream> PdfAsync(string id, QuotePdfOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            requestOptions = this.SetupRequestOptionsForPdfRequest(requestOptions);
            return this.RequestStreamingAsync(HttpMethod.Get, $"{this.InstanceUrl(id)}/pdf", options, requestOptions, cancellationToken);
        }

        private RequestOptions SetupRequestOptionsForPdfRequest(RequestOptions requestOptions)
        {
            if (requestOptions == null)
            {
                requestOptions = new RequestOptions();
            }

            if (requestOptions.BaseUrl == null)
            {
                requestOptions.BaseUrl = this.Client.FilesBase;
            }

            return requestOptions;
        }
    }
}
