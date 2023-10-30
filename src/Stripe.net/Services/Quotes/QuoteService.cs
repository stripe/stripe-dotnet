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

        public virtual StripeList<InvoiceLineItem> ListPreviewInvoiceLines(string parentId, string id, QuoteListPreviewInvoiceLinesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(parentId)}/preview_invoices/{id}/lines", options, requestOptions);
        }

        public virtual Task<StripeList<InvoiceLineItem>> ListPreviewInvoiceLinesAsync(string parentId, string id, QuoteListPreviewInvoiceLinesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<InvoiceLineItem>>(HttpMethod.Get, $"{this.InstanceUrl(parentId)}/preview_invoices/{id}/lines", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<InvoiceLineItem> ListPreviewInvoiceLinesAutoPaging(string parentId, string id, QuoteListPreviewInvoiceLinesOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InvoiceLineItem>($"{this.InstanceUrl(parentId)}/preview_invoices/{id}/lines", options, requestOptions);
        }

        public virtual IAsyncEnumerable<InvoiceLineItem> ListPreviewInvoiceLinesAutoPagingAsync(string parentId, string id, QuoteListPreviewInvoiceLinesOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InvoiceLineItem>($"{this.InstanceUrl(parentId)}/preview_invoices/{id}/lines", options, requestOptions, cancellationToken);
        }

        public virtual Quote MarkDraft(string id, QuoteMarkDraftOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/mark_draft", options, requestOptions);
        }

        public virtual Task<Quote> MarkDraftAsync(string id, QuoteMarkDraftOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/mark_draft", options, requestOptions, cancellationToken);
        }

        public virtual Quote MarkStale(string id, QuoteMarkStaleOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/mark_stale", options, requestOptions);
        }

        public virtual Task<Quote> MarkStaleAsync(string id, QuoteMarkStaleOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/mark_stale", options, requestOptions, cancellationToken);
        }

        public virtual Stream Pdf(string id, QuotePdfOptions options = null, RequestOptions requestOptions = null)
        {
            requestOptions ??= new RequestOptions();
            requestOptions.BaseUrl ??= this.Client.FilesBase;
            return this.RequestStreaming(HttpMethod.Get, $"{this.InstanceUrl(id)}/pdf", options, requestOptions);
        }

        public virtual Task<Stream> PdfAsync(string id, QuotePdfOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            requestOptions ??= new RequestOptions();
            requestOptions.BaseUrl ??= this.Client.FilesBase;
            return this.RequestStreamingAsync(HttpMethod.Get, $"{this.InstanceUrl(id)}/pdf", options, requestOptions, cancellationToken);
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
    }
}
