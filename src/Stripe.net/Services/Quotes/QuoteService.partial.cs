namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class QuoteService
    {
        /// <summary>
        /// <p>When retrieving a quote, there is an includable <a
        /// href="https://stripe.com/docs/api/quotes/object#quote_object-computed-upfront-line_items"><strong>computed.upfront.line_items</strong></a>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of upfront line items.</p>.
        /// </summary>
        [Obsolete("Use QuoteComputedUpfrontLineItemService.List instead.")]
        public virtual StripeList<LineItem> ListComputedUpfrontLineItems(string id, QuoteComputedUpfrontLineItemsListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/quotes/{id}/computed_upfront_line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <a
        /// href="https://stripe.com/docs/api/quotes/object#quote_object-computed-upfront-line_items"><strong>computed.upfront.line_items</strong></a>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of upfront line items.</p>.
        /// </summary>
        [Obsolete("Use QuoteComputedUpfrontLineItemService.ListAsync instead.")]
        public virtual Task<StripeList<LineItem>> ListComputedUpfrontLineItemsAsync(string id, QuoteComputedUpfrontLineItemsListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/quotes/{id}/computed_upfront_line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <a
        /// href="https://stripe.com/docs/api/quotes/object#quote_object-computed-upfront-line_items"><strong>computed.upfront.line_items</strong></a>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of upfront line items.</p>.
        /// </summary>
        [Obsolete("Use QuoteComputedUpfrontLineItemService.ListAutoPaging instead.")]
        public virtual IEnumerable<LineItem> ListComputedUpfrontLineItemsAutoPaging(string id, QuoteComputedUpfrontLineItemsListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/quotes/{id}/computed_upfront_line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <a
        /// href="https://stripe.com/docs/api/quotes/object#quote_object-computed-upfront-line_items"><strong>computed.upfront.line_items</strong></a>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of upfront line items.</p>.
        /// </summary>
        [Obsolete("Use QuoteComputedUpfrontLineItemService.ListAutoPagingAsync instead.")]
        public virtual IAsyncEnumerable<LineItem> ListComputedUpfrontLineItemsAutoPagingAsync(string id, QuoteComputedUpfrontLineItemsListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/quotes/{id}/computed_upfront_line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <strong>line_items</strong> property
        /// containing the first handful of those items. There is also a URL where you can retrieve
        /// the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use QuoteLineItem.List instead.")]
        public virtual StripeList<LineItem> ListLineItems(string id, QuoteLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/quotes/{id}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <strong>line_items</strong> property
        /// containing the first handful of those items. There is also a URL where you can retrieve
        /// the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use QuoteLineItem.ListAsync instead.")]
        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, QuoteLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/quotes/{id}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <strong>line_items</strong> property
        /// containing the first handful of those items. There is also a URL where you can retrieve
        /// the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use QuoteLineItem.ListAutoPaging instead.")]
        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, QuoteLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/quotes/{id}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a quote, there is an includable <strong>line_items</strong> property
        /// containing the first handful of those items. There is also a URL where you can retrieve
        /// the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use QuoteLineItem.ListAutoPagingAsync instead.")]
        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, QuoteLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/quotes/{id}/line_items", options, requestOptions, cancellationToken);
        }
    }
}
