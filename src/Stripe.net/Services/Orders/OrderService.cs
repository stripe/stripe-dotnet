// File generated from our OpenAPI spec
namespace Stripe
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
            : base(null)
        {
        }

        public OrderService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/orders";

        public virtual Order Cancel(string id, OrderCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Post, $"/v1/orders/{id}/cancel", options, requestOptions);
        }

        public virtual Task<Order> CancelAsync(string id, OrderCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Post, $"/v1/orders/{id}/cancel", options, requestOptions, cancellationToken);
        }

        public virtual Order Create(OrderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Post, $"/v1/orders", options, requestOptions);
        }

        public virtual Task<Order> CreateAsync(OrderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Post, $"/v1/orders", options, requestOptions, cancellationToken);
        }

        public virtual Order Get(string id, OrderGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Get, $"/v1/orders/{id}", options, requestOptions);
        }

        public virtual Task<Order> GetAsync(string id, OrderGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Get, $"/v1/orders/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Order> List(OrderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Order>>(HttpMethod.Get, $"/v1/orders", options, requestOptions);
        }

        public virtual Task<StripeList<Order>> ListAsync(OrderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Order>>(HttpMethod.Get, $"/v1/orders", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Order> ListAutoPaging(OrderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Order>($"/v1/orders", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Order> ListAutoPagingAsync(OrderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Order>($"/v1/orders", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<LineItem> ListLineItems(string id, OrderListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"/v1/orders/{id}/line_items", options, requestOptions);
        }

        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, OrderListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"/v1/orders/{id}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, OrderListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/orders/{id}/line_items", options, requestOptions);
        }

        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, OrderListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/orders/{id}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual Order Reopen(string id, OrderReopenOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Post, $"/v1/orders/{id}/reopen", options, requestOptions);
        }

        public virtual Task<Order> ReopenAsync(string id, OrderReopenOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Post, $"/v1/orders/{id}/reopen", options, requestOptions, cancellationToken);
        }

        public virtual Order Submit(string id, OrderSubmitOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Post, $"/v1/orders/{id}/submit", options, requestOptions);
        }

        public virtual Task<Order> SubmitAsync(string id, OrderSubmitOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Post, $"/v1/orders/{id}/submit", options, requestOptions, cancellationToken);
        }

        public virtual Order Update(string id, OrderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(HttpMethod.Post, $"/v1/orders/{id}", options, requestOptions);
        }

        public virtual Task<Order> UpdateAsync(string id, OrderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(HttpMethod.Post, $"/v1/orders/{id}", options, requestOptions, cancellationToken);
        }
    }
}
