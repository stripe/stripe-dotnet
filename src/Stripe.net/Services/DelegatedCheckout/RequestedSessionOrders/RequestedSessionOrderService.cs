// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class RequestedSessionOrderService : Service,
        INestedListable<Order, RequestedSessionOrderListOptions>
    {
        public RequestedSessionOrderService()
        {
        }

        internal RequestedSessionOrderService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public RequestedSessionOrderService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Lists orders for a delegated checkout requested session.</p>.
        /// </summary>
        public virtual StripeList<Order> List(string parentId, RequestedSessionOrderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Order>>(BaseAddress.Api, HttpMethod.Get, $"/v1/delegated_checkout/requested_sessions/{WebUtility.UrlEncode(parentId)}/orders", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists orders for a delegated checkout requested session.</p>.
        /// </summary>
        public virtual Task<StripeList<Order>> ListAsync(string parentId, RequestedSessionOrderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Order>>(BaseAddress.Api, HttpMethod.Get, $"/v1/delegated_checkout/requested_sessions/{WebUtility.UrlEncode(parentId)}/orders", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists orders for a delegated checkout requested session.</p>.
        /// </summary>
        public virtual IEnumerable<Order> ListAutoPaging(string parentId, RequestedSessionOrderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Order>($"/v1/delegated_checkout/requested_sessions/{WebUtility.UrlEncode(parentId)}/orders", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists orders for a delegated checkout requested session.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Order> ListAutoPagingAsync(string parentId, RequestedSessionOrderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Order>($"/v1/delegated_checkout/requested_sessions/{WebUtility.UrlEncode(parentId)}/orders", options, requestOptions, cancellationToken);
        }
    }
}
