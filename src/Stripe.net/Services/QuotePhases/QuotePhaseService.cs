// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class QuotePhaseService : Service<QuotePhase>,
        IRetrievable<QuotePhase, QuotePhaseGetOptions>
    {
        public QuotePhaseService()
        {
        }

        public QuotePhaseService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/quote_phases";

        /// <summary>
        /// <p>Retrieves the quote phase with the given ID.</p>.
        /// </summary>
        public virtual QuotePhase Get(string id, QuotePhaseGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<QuotePhase>(HttpMethod.Get, $"/v1/quote_phases/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the quote phase with the given ID.</p>.
        /// </summary>
        public virtual Task<QuotePhase> GetAsync(string id, QuotePhaseGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<QuotePhase>(HttpMethod.Get, $"/v1/quote_phases/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a quote phase, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual StripeList<LineItem> ListLineItems(string id, QuotePhaseListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"/v1/quote_phases/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a quote phase, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, QuotePhaseListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"/v1/quote_phases/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a quote phase, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, QuotePhaseListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/quote_phases/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a quote phase, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, QuotePhaseListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/quote_phases/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions, cancellationToken);
        }
    }
}
