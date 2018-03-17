using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeOrderService : StripeBasicService<StripeOrder>
    {
        public StripeOrderService() : base(null) { }
        public StripeOrderService(string apiKey) : base(apiKey) { }

        public bool ExpandCharge { get; set; }
        public bool ExpandCustomer { get; set; }



        // Sync
        public virtual StripeOrder Create(StripeOrderCreateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/orders", requestOptions, options);
        }

        public virtual StripeOrder Get(string orderId, StripeRequestOptions requestOptions = null)
        {
            return GetEntity($"{Urls.BaseUrl}/orders/{orderId}", requestOptions);
        }

        public virtual StripeOrder Update(string orderId, StripeOrderUpdateOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/orders/{orderId}", requestOptions, options);
        }

        public virtual StripeOrder Pay(string orderId, StripeOrderPayOptions options, StripeRequestOptions requestOptions = null)
        {
            return Post($"{Urls.BaseUrl}/orders/{orderId}/pay", requestOptions, options);
        }

        public virtual StripeList<StripeOrder> List(StripeOrderListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return GetEntityList($"{Urls.BaseUrl}/orders", requestOptions, listOptions);
        }



        // Async
        public virtual Task<StripeOrder> CreateAsync(StripeOrderCreateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/orders", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeOrder> GetAsync(string orderId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityAsync($"{Urls.BaseUrl}/orders/{orderId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeOrder> UpdateAsync(string orderId, StripeOrderUpdateOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/orders/{orderId}", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeOrder> PayAsync(string orderId, StripeOrderPayOptions options, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PostAsync($"{Urls.BaseUrl}/orders/{orderId}/pay", requestOptions, cancellationToken, options);
        }

        public virtual Task<StripeList<StripeOrder>> ListAsync(StripeOrderListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetEntityListAsync($"{Urls.BaseUrl}/orders", requestOptions, cancellationToken, listOptions);
        }
    }
}
