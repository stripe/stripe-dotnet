namespace Stripe
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class DiscountService : Service<Discount>
    {
        public DiscountService()
            : base()
        {
        }

        internal DiscountService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public DiscountService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Discount DeleteCustomerDiscount(string customerId, RequestOptions requestOptions = null)
        {
            return this.Request<Discount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{WebUtility.UrlEncode(customerId)}/discount", null, requestOptions);
        }

        public virtual Task<Discount> DeleteCustomerDiscountAsync(string customerId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Discount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/customers/{WebUtility.UrlEncode(customerId)}/discount", null, requestOptions, cancellationToken);
        }

        public virtual Discount DeleteSubscriptionDiscount(string subscriptionId, RequestOptions requestOptions = null)
        {
            return this.Request<Discount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/subscriptions/{WebUtility.UrlEncode(subscriptionId)}/discount", null, requestOptions);
        }

        public virtual Task<Discount> DeleteSubscriptionDiscountAsync(string subscriptionId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Discount>(BaseAddress.Api, HttpMethod.Delete, $"/v1/subscriptions/{WebUtility.UrlEncode(subscriptionId)}/discount", null, requestOptions, cancellationToken);
        }
    }
}
