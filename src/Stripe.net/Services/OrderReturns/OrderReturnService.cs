namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class OrderReturnService : Service<OrderReturn>,
        IListable<OrderReturn, OrderReturnListOptions>,
        IRetrievable<OrderReturn, OrderReturnGetOptions>
    {
        public OrderReturnService()
            : base(null)
        {
        }

        public OrderReturnService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/order_returns";

        public virtual OrderReturn Get(string id, OrderReturnGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<OrderReturn> GetAsync(string id, OrderReturnGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<OrderReturn> List(OrderReturnListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<OrderReturn>> ListAsync(OrderReturnListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<OrderReturn> ListAutoPaging(OrderReturnListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}
