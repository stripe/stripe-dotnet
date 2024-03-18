// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System;
    using System.Collections.Generic;
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
        public override string BasePath => "/v1/climate/orders";

        /// <summary>
        /// <p>Cancels a Climate order. You can cancel an order within 30 days of creation. Stripe
        /// refunds the reservation <c>amount_subtotal</c>, but not the <c>amount_fees</c> for
        /// user-triggered cancellations. Frontier might cancel reservations if suppliers fail to
        /// deliver. If Frontier cancels the reservation, Stripe provides 90 days advance notice and
        /// refunds the <c>amount_total</c>.</p>.
        /// </summary>
        public virtual Order Cancel(string id, OrderCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Post, $"/v1/climate/orders/{id}/cancel", options, requestOptions);
        }

        /// <summary>
        /// <p>Cancels a Climate order. You can cancel an order within 30 days of creation. Stripe
        /// refunds the reservation <c>amount_subtotal</c>, but not the <c>amount_fees</c> for
        /// user-triggered cancellations. Frontier might cancel reservations if suppliers fail to
        /// deliver. If Frontier cancels the reservation, Stripe provides 90 days advance notice and
        /// refunds the <c>amount_total</c>.</p>.
        /// </summary>
        public virtual Task<Order> CancelAsync(string id, OrderCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Post, $"/v1/climate/orders/{id}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a Climate order object for a given Climate product. The order will be
        /// processed immediately after creation and payment will be deducted your Stripe
        /// balance.</p>.
        /// </summary>
        public virtual Order Create(OrderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Post, $"/v1/climate/orders", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a Climate order object for a given Climate product. The order will be
        /// processed immediately after creation and payment will be deducted your Stripe
        /// balance.</p>.
        /// </summary>
        public virtual Task<Order> CreateAsync(OrderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Post, $"/v1/climate/orders", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of a Climate order object with the given ID.</p>.
        /// </summary>
        public virtual Order Get(string id, OrderGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Get, $"/v1/climate/orders/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of a Climate order object with the given ID.</p>.
        /// </summary>
        public virtual Task<Order> GetAsync(string id, OrderGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Get, $"/v1/climate/orders/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all Climate order objects. The orders are returned sorted by creation date,
        /// with the most recently created orders appearing first.</p>.
        /// </summary>
        public virtual StripeList<Order> List(OrderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Order>>(HttpMethod.Get, $"/v1/climate/orders", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all Climate order objects. The orders are returned sorted by creation date,
        /// with the most recently created orders appearing first.</p>.
        /// </summary>
        public virtual Task<StripeList<Order>> ListAsync(OrderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Order>>(HttpMethod.Get, $"/v1/climate/orders", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Lists all Climate order objects. The orders are returned sorted by creation date,
        /// with the most recently created orders appearing first.</p>.
        /// </summary>
        public virtual IEnumerable<Order> ListAutoPaging(OrderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Order>($"/v1/climate/orders", options, requestOptions);
        }

        /// <summary>
        /// <p>Lists all Climate order objects. The orders are returned sorted by creation date,
        /// with the most recently created orders appearing first.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Order> ListAutoPagingAsync(OrderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Order>($"/v1/climate/orders", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates the specified order by setting the values of the parameters passed.</p>.
        /// </summary>
        public virtual Order Update(string id, OrderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Post, $"/v1/climate/orders/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates the specified order by setting the values of the parameters passed.</p>.
        /// </summary>
        public virtual Task<Order> UpdateAsync(string id, OrderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Post, $"/v1/climate/orders/{id}", options, requestOptions, cancellationToken);
        }
    }
}
