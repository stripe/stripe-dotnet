// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OrderService : Service, IRetrievable<Order, OrderGetOptions>
    {
        public OrderService()
        {
        }

        internal OrderService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public OrderService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a delegated checkout order.</p>.
        /// </summary>
        public virtual Order Get(string id, OrderGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Order>(BaseAddress.Api, HttpMethod.Get, $"/v1/delegated_checkout/orders/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a delegated checkout order.</p>.
        /// </summary>
        public virtual Task<Order> GetAsync(string id, OrderGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Order>(BaseAddress.Api, HttpMethod.Get, $"/v1/delegated_checkout/orders/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
