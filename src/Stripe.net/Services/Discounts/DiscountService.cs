namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class DiscountService : Service<Discount>
    {
        public DiscountService()
            : base(null)
        {
        }

        public DiscountService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => null;

        public virtual Discount DeleteCustomerDiscount(string customerId, RequestOptions requestOptions = null)
        {
            return this.DeleteRequest<Discount>($"{Urls.BaseUrl}/customers/{customerId}/discount", null, requestOptions);
        }

        public virtual Task<Discount> DeleteCustomerDiscountAsync(string customerId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteRequestAsync<Discount>($"{Urls.BaseUrl}/customers/{customerId}/discount", null, requestOptions, cancellationToken);
        }

        public virtual Discount DeleteSubscriptionDiscount(string subscriptionId, RequestOptions requestOptions = null)
        {
            return this.DeleteRequest<Discount>($"{Urls.BaseUrl}/subscriptions/{subscriptionId}/discount", null, requestOptions);
        }

        public virtual Task<Discount> DeleteSubscriptionDiscountAsync(string subscriptionId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteRequestAsync<Discount>($"{Urls.BaseUrl}/subscriptions/{subscriptionId}/discount", null, requestOptions, cancellationToken);
        }
    }
}
