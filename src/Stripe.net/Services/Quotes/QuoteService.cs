// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class QuoteService : Service<Quote>,
        ICreatable<Quote, QuoteCreateOptions>,
        IListable<Quote, QuoteListOptions>,
        IRetrievable<Quote, QuoteGetOptions>,
        IUpdatable<Quote, QuoteUpdateOptions>
    {
        private QuoteLineItemService lineItems;
        private QuoteComputedUpfrontLineItemsService computedUpfrontLineItems;

        public QuoteService()
        {
        }

        internal QuoteService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public QuoteService(IStripeClient client)
            : base(client)
        {
        }

        public virtual QuoteLineItemService LineItems => this.lineItems ??= new QuoteLineItemService(
            this.Requestor);

        public virtual QuoteComputedUpfrontLineItemsService ComputedUpfrontLineItems => this.computedUpfrontLineItems ??= new QuoteComputedUpfrontLineItemsService(
            this.Requestor);

        /// <summary>
        /// <p>Accepts the specified quote.</p>.
        /// </summary>
        public virtual Quote Accept(string id, QuoteAcceptOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(BaseAddress.Api, HttpMethod.Post, $"/v1/quotes/{WebUtility.UrlEncode(id)}/accept", options, requestOptions);
        }

        /// <summary>
        /// <p>Accepts the specified quote.</p>.
        /// </summary>
        public virtual Task<Quote> AcceptAsync(string id, QuoteAcceptOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(BaseAddress.Api, HttpMethod.Post, $"/v1/quotes/{WebUtility.UrlEncode(id)}/accept", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Cancels the quote.</p>.
        /// </summary>
        public virtual Quote Cancel(string id, QuoteCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(BaseAddress.Api, HttpMethod.Post, $"/v1/quotes/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>Cancels the quote.</p>.
        /// </summary>
        public virtual Task<Quote> CancelAsync(string id, QuoteCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(BaseAddress.Api, HttpMethod.Post, $"/v1/quotes/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>A quote models prices and services for a customer. Default options for <c>header</c>,
        /// <c>description</c>, <c>footer</c>, and <c>expires_at</c> can be set in the dashboard via
        /// the <a href="https://dashboard.stripe.com/settings/billing/quote">quote
        /// template</a>.</p>.
        /// </summary>
        public virtual Quote Create(QuoteCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(BaseAddress.Api, HttpMethod.Post, $"/v1/quotes", options, requestOptions);
        }

        /// <summary>
        /// <p>A quote models prices and services for a customer. Default options for <c>header</c>,
        /// <c>description</c>, <c>footer</c>, and <c>expires_at</c> can be set in the dashboard via
        /// the <a href="https://dashboard.stripe.com/settings/billing/quote">quote
        /// template</a>.</p>.
        /// </summary>
        public virtual Task<Quote> CreateAsync(QuoteCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(BaseAddress.Api, HttpMethod.Post, $"/v1/quotes", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Finalizes the quote.</p>.
        /// </summary>
        public virtual Quote FinalizeQuote(string id, QuoteFinalizeOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(BaseAddress.Api, HttpMethod.Post, $"/v1/quotes/{WebUtility.UrlEncode(id)}/finalize", options, requestOptions);
        }

        /// <summary>
        /// <p>Finalizes the quote.</p>.
        /// </summary>
        public virtual Task<Quote> FinalizeQuoteAsync(string id, QuoteFinalizeOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(BaseAddress.Api, HttpMethod.Post, $"/v1/quotes/{WebUtility.UrlEncode(id)}/finalize", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the quote with the given ID.</p>.
        /// </summary>
        public virtual Quote Get(string id, QuoteGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(BaseAddress.Api, HttpMethod.Get, $"/v1/quotes/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the quote with the given ID.</p>.
        /// </summary>
        public virtual Task<Quote> GetAsync(string id, QuoteGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(BaseAddress.Api, HttpMethod.Get, $"/v1/quotes/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your quotes.</p>.
        /// </summary>
        public virtual StripeList<Quote> List(QuoteListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Quote>>(BaseAddress.Api, HttpMethod.Get, $"/v1/quotes", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your quotes.</p>.
        /// </summary>
        public virtual Task<StripeList<Quote>> ListAsync(QuoteListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Quote>>(BaseAddress.Api, HttpMethod.Get, $"/v1/quotes", options, requestOptions, cancellationToken);
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
        /// <p>Download the PDF for a finalized quote. Explanation for special handling can be found
        /// <a href="https://docs.stripe.com/quotes/overview#quote_pdf">here</a></p>.
        /// </summary>
        public virtual Stream Pdf(string id, QuotePdfOptions options = null, RequestOptions requestOptions = null)
        {
            return this.RequestStreaming(BaseAddress.Files, HttpMethod.Get, $"/v1/quotes/{WebUtility.UrlEncode(id)}/pdf", options, requestOptions);
        }

        /// <summary>
        /// <p>Download the PDF for a finalized quote. Explanation for special handling can be found
        /// <a href="https://docs.stripe.com/quotes/overview#quote_pdf">here</a></p>.
        /// </summary>
        public virtual Task<Stream> PdfAsync(string id, QuotePdfOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestStreamingAsync(BaseAddress.Files, HttpMethod.Get, $"/v1/quotes/{WebUtility.UrlEncode(id)}/pdf", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Recompute the upcoming invoice estimate for the quote.</p>.
        /// </summary>
        public virtual Quote Reestimate(string id, QuoteReestimateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(HttpMethod.Post, $"/v1/quotes/{WebUtility.UrlEncode(id)}/reestimate", options, requestOptions);
        }

        /// <summary>
        /// <p>Recompute the upcoming invoice estimate for the quote.</p>.
        /// </summary>
        public virtual Task<Quote> ReestimateAsync(string id, QuoteReestimateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(HttpMethod.Post, $"/v1/quotes/{WebUtility.UrlEncode(id)}/reestimate", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>A quote models prices and services for a customer.</p>.
        /// </summary>
        public virtual Quote Update(string id, QuoteUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Quote>(BaseAddress.Api, HttpMethod.Post, $"/v1/quotes/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>A quote models prices and services for a customer.</p>.
        /// </summary>
        public virtual Task<Quote> UpdateAsync(string id, QuoteUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Quote>(BaseAddress.Api, HttpMethod.Post, $"/v1/quotes/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
