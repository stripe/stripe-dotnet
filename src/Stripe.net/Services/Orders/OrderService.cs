namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class OrderService : Service<Order>,
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

        public override string BasePath => "/v1/orders";

        public bool ExpandCharge { get; set; }

        public bool ExpandCustomer { get; set; }

        public virtual Order Create(OrderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Order> CreateAsync(OrderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Order Get(string orderId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(orderId, null, requestOptions);
        }

        public virtual Task<Order> GetAsync(string orderId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(orderId, null, requestOptions, cancellationToken);
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
            return this.PostRequest<Order>($"{this.InstanceUrl(orderId)}/pay", options, requestOptions);
        }

        public virtual Task<Order> PayAsync(string orderId, OrderPayOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostRequestAsync<Order>($"{this.InstanceUrl(orderId)}/pay", options, requestOptions, cancellationToken);
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
