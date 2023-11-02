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
            return this.Request<Quote>(HttpMethod.Post, $"/v1/quotes/{id}/accept", options, requestOptions);
        }

        public virtual Task<Quote> AcceptAsync(string id, QuoteAcceptOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(HttpMethod.Post, $"/v1/quotes/{id}/accept", options, requestOptions, cancellationToken);
        }

        public virtual Quote Cancel(string id, QuoteCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(HttpMethod.Post, $"/v1/quotes/{id}/cancel", options, requestOptions);
        }

        public virtual Task<Quote> CancelAsync(string id, QuoteCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(HttpMethod.Post, $"/v1/quotes/{id}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual Quote Create(QuoteCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(HttpMethod.Post, $"/v1/quotes", options, requestOptions);
        }

        public virtual Task<Quote> CreateAsync(QuoteCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(HttpMethod.Post, $"/v1/quotes", options, requestOptions, cancellationToken);
        }

        public virtual Quote FinalizeQuote(string id, QuoteFinalizeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(HttpMethod.Post, $"/v1/quotes/{id}/finalize", options, requestOptions);
        }

        public virtual Task<Quote> FinalizeQuoteAsync(string id, QuoteFinalizeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(HttpMethod.Post, $"/v1/quotes/{id}/finalize", options, requestOptions, cancellationToken);
        }

        public virtual Quote Get(string id, QuoteGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(HttpMethod.Get, $"/v1/quotes/{id}", options, requestOptions);
        }

        public virtual Task<Quote> GetAsync(string id, QuoteGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(HttpMethod.Get, $"/v1/quotes/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Quote> List(QuoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Quote>>(HttpMethod.Get, $"/v1/quotes", options, requestOptions);
        }

        public virtual Task<StripeList<Quote>> ListAsync(QuoteListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Quote>>(HttpMethod.Get, $"/v1/quotes", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Quote> ListAutoPaging(QuoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Quote>($"/v1/quotes", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Quote> ListAutoPagingAsync(QuoteListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Quote>($"/v1/quotes", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<LineItem> ListComputedUpfrontLineItems(string id, QuoteListComputedUpfrontLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"/v1/quotes/{id}/computed_upfront_line_items", options, requestOptions);
        }

        public virtual Task<StripeList<LineItem>> ListComputedUpfrontLineItemsAsync(string id, QuoteListComputedUpfrontLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"/v1/quotes/{id}/computed_upfront_line_items", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<LineItem> ListComputedUpfrontLineItemsAutoPaging(string id, QuoteListComputedUpfrontLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/quotes/{id}/computed_upfront_line_items", options, requestOptions);
        }

        public virtual IAsyncEnumerable<LineItem> ListComputedUpfrontLineItemsAutoPagingAsync(string id, QuoteListComputedUpfrontLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/quotes/{id}/computed_upfront_line_items", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<LineItem> ListLineItems(string id, QuoteListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"/v1/quotes/{id}/line_items", options, requestOptions);
        }

        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, QuoteListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"/v1/quotes/{id}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, QuoteListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/quotes/{id}/line_items", options, requestOptions);
        }

        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, QuoteListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/quotes/{id}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual Stream Pdf(string id, QuotePdfOptions options = null, RequestOptions requestOptions = null)
        {
            requestOptions ??= new RequestOptions();
            requestOptions.BaseUrl ??= this.Client.FilesBase;
            return this.RequestStreaming(HttpMethod.Get, $"/v1/quotes/{id}/pdf", options, requestOptions);
        }

        public virtual Task<Stream> PdfAsync(string id, QuotePdfOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            requestOptions ??= new RequestOptions();
            requestOptions.BaseUrl ??= this.Client.FilesBase;
            return this.RequestStreamingAsync(HttpMethod.Get, $"/v1/quotes/{id}/pdf", options, requestOptions, cancellationToken);
        }

        public virtual Quote Update(string id, QuoteUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(HttpMethod.Post, $"/v1/quotes/{id}", options, requestOptions);
        }

        public virtual Task<Quote> UpdateAsync(string id, QuoteUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(HttpMethod.Post, $"/v1/quotes/{id}", options, requestOptions, cancellationToken);
        }
    }
}
