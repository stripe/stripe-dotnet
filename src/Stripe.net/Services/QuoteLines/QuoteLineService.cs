// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class QuoteLineService : Service,
        INestedListable<QuoteLine, QuoteLineListOptions>
    {
        public QuoteLineService()
        {
        }

        internal QuoteLineService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public QuoteLineService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a paginated list of lines for a quote. These lines describe changes that
        /// will be used to create new subscription schedules or update existing subscription
        /// schedules when the quote is accepted.</p>.
        /// </summary>
        public virtual StripeList<QuoteLine> List(string parentId, QuoteLineListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<QuoteLine>>(BaseAddress.Api, HttpMethod.Get, $"/v1/quotes/{WebUtility.UrlEncode(parentId)}/lines", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a paginated list of lines for a quote. These lines describe changes that
        /// will be used to create new subscription schedules or update existing subscription
        /// schedules when the quote is accepted.</p>.
        /// </summary>
        public virtual Task<StripeList<QuoteLine>> ListAsync(string parentId, QuoteLineListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<QuoteLine>>(BaseAddress.Api, HttpMethod.Get, $"/v1/quotes/{WebUtility.UrlEncode(parentId)}/lines", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a paginated list of lines for a quote. These lines describe changes that
        /// will be used to create new subscription schedules or update existing subscription
        /// schedules when the quote is accepted.</p>.
        /// </summary>
        public virtual IEnumerable<QuoteLine> ListAutoPaging(string parentId, QuoteLineListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<QuoteLine>($"/v1/quotes/{WebUtility.UrlEncode(parentId)}/lines", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a paginated list of lines for a quote. These lines describe changes that
        /// will be used to create new subscription schedules or update existing subscription
        /// schedules when the quote is accepted.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<QuoteLine> ListAutoPagingAsync(string parentId, QuoteLineListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<QuoteLine>($"/v1/quotes/{WebUtility.UrlEncode(parentId)}/lines", options, requestOptions, cancellationToken);
        }
    }
}
