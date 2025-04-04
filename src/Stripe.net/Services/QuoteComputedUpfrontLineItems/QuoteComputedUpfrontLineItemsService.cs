// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class QuoteComputedUpfrontLineItemsService : Service,
        INestedListable<LineItem, QuoteComputedUpfrontLineItemsListOptions>
    {
        public QuoteComputedUpfrontLineItemsService()
        {
        }

        internal QuoteComputedUpfrontLineItemsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public QuoteComputedUpfrontLineItemsService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <a
        /// href="https://stripe.com/docs/api/quotes/object#quote_object-computed-upfront-line_items"><strong>computed.upfront.line_items</strong></a>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of upfront line items.</p>.
        /// </summary>
        public virtual StripeList<LineItem> List(string parentId, QuoteComputedUpfrontLineItemsListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/quotes/{WebUtility.UrlEncode(parentId)}/computed_upfront_line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <a
        /// href="https://stripe.com/docs/api/quotes/object#quote_object-computed-upfront-line_items"><strong>computed.upfront.line_items</strong></a>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of upfront line items.</p>.
        /// </summary>
        public virtual Task<StripeList<LineItem>> ListAsync(string parentId, QuoteComputedUpfrontLineItemsListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/quotes/{WebUtility.UrlEncode(parentId)}/computed_upfront_line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <a
        /// href="https://stripe.com/docs/api/quotes/object#quote_object-computed-upfront-line_items"><strong>computed.upfront.line_items</strong></a>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of upfront line items.</p>.
        /// </summary>
        public virtual IEnumerable<LineItem> ListAutoPaging(string parentId, QuoteComputedUpfrontLineItemsListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/quotes/{WebUtility.UrlEncode(parentId)}/computed_upfront_line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <a
        /// href="https://stripe.com/docs/api/quotes/object#quote_object-computed-upfront-line_items"><strong>computed.upfront.line_items</strong></a>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of upfront line items.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<LineItem> ListAutoPagingAsync(string parentId, QuoteComputedUpfrontLineItemsListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/quotes/{WebUtility.UrlEncode(parentId)}/computed_upfront_line_items", options, requestOptions, cancellationToken);
        }
    }
}
