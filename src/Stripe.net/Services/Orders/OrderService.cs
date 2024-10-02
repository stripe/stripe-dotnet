// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OrderService : Service<Order>,
        ICreatable<Order, OrderCreateOptions>,
        IListable<Order, OrderListOptions>,
        IRetrievable<Order, OrderGetOptions>,
        IUpdatable<Order, OrderUpdateOptions>
    {
        public OrderService()
        {
        }

        public OrderService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/orders";

        /// <summary>
        /// <p>Cancels the order as well as the payment intent if one is attached.</p>.
        /// </summary>
        public virtual Order Cancel(string id, OrderCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Post, $"/v1/orders/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>Cancels the order as well as the payment intent if one is attached.</p>.
        /// </summary>
        public virtual Task<Order> CancelAsync(string id, OrderCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Post, $"/v1/orders/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a new <c>open</c> order object.</p>.
        /// </summary>
        public virtual Order Create(OrderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Post, $"/v1/orders", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new <c>open</c> order object.</p>.
        /// </summary>
        public virtual Task<Order> CreateAsync(OrderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Post, $"/v1/orders", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing order. Supply the unique order ID from either an
        /// order creation request or the order list, and Stripe will return the corresponding order
        /// information.</p>.
        /// </summary>
        public virtual Order Get(string id, OrderGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Get, $"/v1/orders/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing order. Supply the unique order ID from either an
        /// order creation request or the order list, and Stripe will return the corresponding order
        /// information.</p>.
        /// </summary>
        public virtual Task<Order> GetAsync(string id, OrderGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Get, $"/v1/orders/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your orders. The orders are returned sorted by creation date, with
        /// the most recently created orders appearing first.</p>.
        /// </summary>
        public virtual StripeList<Order> List(OrderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Order>>(HttpMethod.Get, $"/v1/orders", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your orders. The orders are returned sorted by creation date, with
        /// the most recently created orders appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Order>> ListAsync(OrderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Order>>(HttpMethod.Get, $"/v1/orders", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of your orders. The orders are returned sorted by creation date, with
        /// the most recently created orders appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<Order> ListAutoPaging(OrderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Order>($"/v1/orders", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of your orders. The orders are returned sorted by creation date, with
        /// the most recently created orders appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Order> ListAutoPagingAsync(OrderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Order>($"/v1/orders", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an order, there is an includable <strong>line_items</strong> property
        /// containing the first handful of those items. There is also a URL where you can retrieve
        /// the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual StripeList<LineItem> ListLineItems(string id, OrderListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"/v1/orders/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an order, there is an includable <strong>line_items</strong> property
        /// containing the first handful of those items. There is also a URL where you can retrieve
        /// the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, OrderListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"/v1/orders/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>When retrieving an order, there is an includable <strong>line_items</strong> property
        /// containing the first handful of those items. There is also a URL where you can retrieve
        /// the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, OrderListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/orders/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions);
        }

        /// <summary>
        /// <p>When retrieving an order, there is an includable <strong>line_items</strong> property
        /// containing the first handful of those items. There is also a URL where you can retrieve
        /// the full (paginated) list of line items.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, OrderListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/orders/{WebUtility.UrlEncode(id)}/line_items", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Reopens a <c>submitted</c> order.</p>.
        /// </summary>
        public virtual Order Reopen(string id, OrderReopenOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Post, $"/v1/orders/{WebUtility.UrlEncode(id)}/reopen", options, requestOptions);
        }

        /// <summary>
        /// <p>Reopens a <c>submitted</c> order.</p>.
        /// </summary>
        public virtual Task<Order> ReopenAsync(string id, OrderReopenOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Post, $"/v1/orders/{WebUtility.UrlEncode(id)}/reopen", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Submitting an Order transitions the status to <c>processing</c> and creates a
        /// PaymentIntent object so the order can be paid. If the Order has an <c>amount_total</c>
        /// of 0, no PaymentIntent object will be created. Once the order is submitted, its contents
        /// cannot be changed, unless the <a
        /// href="https://stripe.com/docs/api#reopen_order">reopen</a> method is called.</p>.
        /// </summary>
        public virtual Order Submit(string id, OrderSubmitOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Post, $"/v1/orders/{WebUtility.UrlEncode(id)}/submit", options, requestOptions);
        }

        /// <summary>
        /// <p>Submitting an Order transitions the status to <c>processing</c> and creates a
        /// PaymentIntent object so the order can be paid. If the Order has an <c>amount_total</c>
        /// of 0, no PaymentIntent object will be created. Once the order is submitted, its contents
        /// cannot be changed, unless the <a
        /// href="https://stripe.com/docs/api#reopen_order">reopen</a> method is called.</p>.
        /// </summary>
        public virtual Task<Order> SubmitAsync(string id, OrderSubmitOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Post, $"/v1/orders/{WebUtility.UrlEncode(id)}/submit", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specific order by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged.</p>.
        /// </summary>
        public virtual Order Update(string id, OrderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Post, $"/v1/orders/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specific order by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged.</p>.
        /// </summary>
        public virtual Task<Order> UpdateAsync(string id, OrderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Post, $"/v1/orders/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
