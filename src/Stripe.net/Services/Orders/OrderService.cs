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

        public override string BasePath => "/v1/orders";

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandCharge { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandCustomer { get; set; }

        public virtual Order Create(OrderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Order> CreateAsync(OrderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Order Get(string orderId, OrderGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(orderId, options, requestOptions);
        }

        public virtual Task<Order> GetAsync(string orderId, OrderGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(orderId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Order> List(OrderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Order>> ListAsync(OrderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Order> ListAutoPaging(OrderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Order Pay(string orderId, OrderPayOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(orderId)}/pay", options, requestOptions);
        }

        public virtual Task<Order> PayAsync(string orderId, OrderPayOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(orderId)}/pay", options, requestOptions, cancellationToken);
        }

        public virtual Order Update(string orderId, OrderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(orderId, options, requestOptions);
        }

        public virtual Task<Order> UpdateAsync(string orderId, OrderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(orderId, options, requestOptions, cancellationToken);
        }
    }
}
