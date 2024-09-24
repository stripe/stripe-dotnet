namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class PaymentLinkService
    {
        /// <summary>
        /// <p>When retrieving a payment link, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use PaymentLinkLineItemService.List instead.")]
        public virtual StripeList<LineItem> ListLineItems(string id, PaymentLinkListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_links/{id}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a payment link, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use PaymentLinkLineItemService.ListAsync instead.")]
        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, PaymentLinkListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_links/{id}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a payment link, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use PaymentLinkLineItemService.ListAutoPaging instead.")]
        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, PaymentLinkListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/payment_links/{id}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a payment link, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        [Obsolete("Use PaymentLinkLineItemService.ListAutoPagingAsync instead.")]
        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, PaymentLinkListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/payment_links/{id}/line_items", options, requestOptions, cancellationToken);
        }
    }
}
