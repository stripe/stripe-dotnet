// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
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
        {
        }

        public QuoteService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/quotes";

        /// <summary>
        /// <p>Accepts the specified quote.</p>.
        /// </summary>
        public virtual Quote Accept(string id, QuoteAcceptOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(HttpMethod.Post, $"/v1/quotes/{id}/accept", options, requestOptions);
        }

        /// <summary>
        /// <p>Accepts the specified quote.</p>.
        /// </summary>
        public virtual Task<Quote> AcceptAsync(string id, QuoteAcceptOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(HttpMethod.Post, $"/v1/quotes/{id}/accept", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Cancels the quote.</p>.
        /// </summary>
        public virtual Quote Cancel(string id, QuoteCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(HttpMethod.Post, $"/v1/quotes/{id}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>Cancels the quote.</p>.
        /// </summary>
        public virtual Task<Quote> CancelAsync(string id, QuoteCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(HttpMethod.Post, $"/v1/quotes/{id}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>A quote models prices and services for a customer. Default options for <c>header</c>,
        /// <c>description</c>, <c>footer</c>, and <c>expires_at</c> can be set in the dashboard via
        /// the <a href="https://dashboard.stripe.com/settings/billing/quote">quote
        /// template</a>.</p>.
        /// </summary>
        public virtual Quote Create(QuoteCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(HttpMethod.Post, $"/v1/quotes", options, requestOptions);
        }

        /// <summary>
        /// <p>A quote models prices and services for a customer. Default options for <c>header</c>,
        /// <c>description</c>, <c>footer</c>, and <c>expires_at</c> can be set in the dashboard via
        /// the <a href="https://dashboard.stripe.com/settings/billing/quote">quote
        /// template</a>.</p>.
        /// </summary>
        public virtual Task<Quote> CreateAsync(QuoteCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(HttpMethod.Post, $"/v1/quotes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Finalizes the quote.</p>.
        /// </summary>
        public virtual Quote FinalizeQuote(string id, QuoteFinalizeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(HttpMethod.Post, $"/v1/quotes/{id}/finalize", options, requestOptions);
        }

        /// <summary>
        /// <p>Finalizes the quote.</p>.
        /// </summary>
        public virtual Task<Quote> FinalizeQuoteAsync(string id, QuoteFinalizeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(HttpMethod.Post, $"/v1/quotes/{id}/finalize", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the quote with the given ID.</p>.
        /// </summary>
        public virtual Quote Get(string id, QuoteGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(HttpMethod.Get, $"/v1/quotes/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the quote with the given ID.</p>.
        /// </summary>
        public virtual Task<Quote> GetAsync(string id, QuoteGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(HttpMethod.Get, $"/v1/quotes/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your quotes.</p>.
        /// </summary>
        public virtual StripeList<Quote> List(QuoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Quote>>(HttpMethod.Get, $"/v1/quotes", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your quotes.</p>.
        /// </summary>
        public virtual Task<StripeList<Quote>> ListAsync(QuoteListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Quote>>(HttpMethod.Get, $"/v1/quotes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your quotes.</p>.
        /// </summary>
        public virtual IEnumerable<Quote> ListAutoPaging(QuoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Quote>($"/v1/quotes", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your quotes.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Quote> ListAutoPagingAsync(QuoteListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Quote>($"/v1/quotes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <a
        /// href="https://stripe.com/docs/api/quotes/object#quote_object-computed-upfront-line_items"><strong>computed.upfront.line_items</strong></a>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of upfront line items.</p>.
        /// </summary>
        public virtual StripeList<LineItem> ListComputedUpfrontLineItems(string id, QuoteListComputedUpfrontLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"/v1/quotes/{id}/computed_upfront_line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <a
        /// href="https://stripe.com/docs/api/quotes/object#quote_object-computed-upfront-line_items"><strong>computed.upfront.line_items</strong></a>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of upfront line items.</p>.
        /// </summary>
        public virtual Task<StripeList<LineItem>> ListComputedUpfrontLineItemsAsync(string id, QuoteListComputedUpfrontLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"/v1/quotes/{id}/computed_upfront_line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <a
        /// href="https://stripe.com/docs/api/quotes/object#quote_object-computed-upfront-line_items"><strong>computed.upfront.line_items</strong></a>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of upfront line items.</p>.
        /// </summary>
        public virtual IEnumerable<LineItem> ListComputedUpfrontLineItemsAutoPaging(string id, QuoteListComputedUpfrontLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/quotes/{id}/computed_upfront_line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <a
        /// href="https://stripe.com/docs/api/quotes/object#quote_object-computed-upfront-line_items"><strong>computed.upfront.line_items</strong></a>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of upfront line items.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<LineItem> ListComputedUpfrontLineItemsAutoPagingAsync(string id, QuoteListComputedUpfrontLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/quotes/{id}/computed_upfront_line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <strong>line_items</strong> property
        /// containing the first handful of those items. There is also a URL where you can retrieve
        /// the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual StripeList<LineItem> ListLineItems(string id, QuoteListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"/v1/quotes/{id}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <strong>line_items</strong> property
        /// containing the first handful of those items. There is also a URL where you can retrieve
        /// the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, QuoteListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"/v1/quotes/{id}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <strong>line_items</strong> property
        /// containing the first handful of those items. There is also a URL where you can retrieve
        /// the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, QuoteListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/quotes/{id}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <strong>line_items</strong> property
        /// containing the first handful of those items. There is also a URL where you can retrieve
        /// the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, QuoteListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/quotes/{id}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Download the PDF for a finalized quote. Explanation for special handling can be found
        /// <a href="https://docs.corp.stripe.com/quotes/overview#quote_pdf">here</a></p>.
        /// </summary>
        public virtual Stream Pdf(string id, QuotePdfOptions options = null, RequestOptions requestOptions = null)
        {
            requestOptions ??= new RequestOptions();
            if (requestOptions.BaseUrl == null)
            {
                requestOptions = requestOptions.Clone();
                requestOptions.BaseUrl = this.Client.FilesBase;
            }

            return this.RequestStreaming(HttpMethod.Get, $"/v1/quotes/{id}/pdf", options, requestOptions);
        }

        /// <summary>
        /// <p>Download the PDF for a finalized quote. Explanation for special handling can be found
        /// <a href="https://docs.corp.stripe.com/quotes/overview#quote_pdf">here</a></p>.
        /// </summary>
        public virtual Task<Stream> PdfAsync(string id, QuotePdfOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            requestOptions ??= new RequestOptions();
            if (requestOptions.BaseUrl == null)
            {
                requestOptions = requestOptions.Clone();
                requestOptions.BaseUrl = this.Client.FilesBase;
            }

            return this.RequestStreamingAsync(HttpMethod.Get, $"/v1/quotes/{id}/pdf", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>A quote models prices and services for a customer.</p>.
        /// </summary>
        public virtual Quote Update(string id, QuoteUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(HttpMethod.Post, $"/v1/quotes/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>A quote models prices and services for a customer.</p>.
        /// </summary>
        public virtual Task<Quote> UpdateAsync(string id, QuoteUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(HttpMethod.Post, $"/v1/quotes/{id}", options, requestOptions, cancellationToken);
        }
    }
}
