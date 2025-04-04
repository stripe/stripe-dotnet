// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentLinkLineItemService : Service,
        INestedListable<LineItem, PaymentLinkLineItemListOptions>
    {
        public PaymentLinkLineItemService()
        {
        }

        internal PaymentLinkLineItemService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public PaymentLinkLineItemService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>When retrieving a payment link, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual StripeList<LineItem> List(string parentId, PaymentLinkLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_links/{WebUtility.UrlEncode(parentId)}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a payment link, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual Task<StripeList<LineItem>> ListAsync(string parentId, PaymentLinkLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(BaseAddress.Api, HttpMethod.Get, $"/v1/payment_links/{WebUtility.UrlEncode(parentId)}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving a payment link, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IEnumerable<LineItem> ListAutoPaging(string parentId, PaymentLinkLineItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/payment_links/{WebUtility.UrlEncode(parentId)}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving a payment link, there is an includable <strong>line_items</strong>
        /// property containing the first handful of those items. There is also a URL where you can
        /// retrieve the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<LineItem> ListAutoPagingAsync(string parentId, PaymentLinkLineItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/payment_links/{WebUtility.UrlEncode(parentId)}/line_items", options, requestOptions, cancellationToken);
        }
    }
}
