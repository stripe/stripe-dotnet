namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class OrderService : BasicService<Order>,
        ICreatable<Order, OrderCreateOptions>,
        IListable<Order, OrderListOptions>,
        IRetrievable<Order>,
        IUpdatable<Order, OrderUpdateOptions>
    {
        public OrderService()
            : base(null)
        {
        }

        public OrderService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandCharge { get; set; }

        public bool ExpandCustomer { get; set; }

        public virtual Order Create(OrderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/orders", requestOptions, options);
        }

        public virtual Order Get(string orderId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/orders/{orderId}", requestOptions);
        }

        public virtual Order Update(string orderId, OrderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/orders/{orderId}", requestOptions, options);
        }

        public virtual Order Pay(string orderId, OrderPayOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/orders/{orderId}/pay", requestOptions, options);
        }

        public virtual StripeList<Order> List(OrderListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/orders", requestOptions, listOptions);
        }

        public virtual Task<Order> CreateAsync(OrderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/orders", requestOptions, cancellationToken, options);
        }

        public virtual Task<Order> GetAsync(string orderId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/orders/{orderId}", requestOptions, cancellationToken);
        }

        public virtual Task<Order> UpdateAsync(string orderId, OrderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/orders/{orderId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<Order> PayAsync(string orderId, OrderPayOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/orders/{orderId}/pay", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<Order>> ListAsync(OrderListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/orders", requestOptions, cancellationToken, listOptions);
        }
    }
}
