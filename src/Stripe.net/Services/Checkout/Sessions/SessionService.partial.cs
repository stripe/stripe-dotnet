namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class SessionService
    {
        /// <summary>
        /// <p>When retrieving a Checkout Session, there is an includable
        /// <strong>line_items</strong> property containing the first handful of those items. There
        /// is also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use SessionLineItemService.List instead.")]
        public virtual StripeList<LineItem> ListLineItems(string id, SessionListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/checkout/sessions/{id}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a Checkout Session, there is an includable
        /// <strong>line_items</strong> property containing the first handful of those items. There
        /// is also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use SessionLineItemService.ListAsync instead.")]
        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, SessionListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/checkout/sessions/{id}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a Checkout Session, there is an includable
        /// <strong>line_items</strong> property containing the first handful of those items. There
        /// is also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use SessionLineItemService.ListAutoPaging instead.")]
        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, SessionListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/checkout/sessions/{id}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a Checkout Session, there is an includable
        /// <strong>line_items</strong> property containing the first handful of those items. There
        /// is also a URL where you can retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use SessionLineItemService.ListAutoPagingAsync instead.")]
        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, SessionListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/checkout/sessions/{id}/line_items", options, requestOptions, cancellationToken);
        }
    }
}
