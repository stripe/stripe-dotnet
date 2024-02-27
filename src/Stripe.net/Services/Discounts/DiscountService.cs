namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class DiscountService : Service<Discount>
    {
        public DiscountService()
            : base(null)
        {
        }

        public DiscountService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => null;

        public virtual Discount DeleteCustomerDiscount(string customerId, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Delete, $"/v1/customers/{customerId}/discount", null, requestOptions);
        }

        public virtual Task<Discount> DeleteCustomerDiscountAsync(string customerId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Delete, $"/v1/customers/{customerId}/discount", null, requestOptions, cancellationToken);
        }

        public virtual Discount DeleteSubscriptionDiscount(string subscriptionId, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Delete, $"/v1/subscriptions/{subscriptionId}/discount", null, requestOptions);
        }

        public virtual Task<Discount> DeleteSubscriptionDiscountAsync(string subscriptionId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Delete, $"/v1/subscriptions/{subscriptionId}/discount", null, requestOptions, cancellationToken);
        }
    }
}
