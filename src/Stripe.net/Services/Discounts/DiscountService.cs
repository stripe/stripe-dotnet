namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class DiscountService : BasicService<Discount>
    {
        public DiscountService()
            : base(null)
        {
        }

        public DiscountService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Discount DeleteCustomerDiscount(string customerId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/customers/{customerId}/discount", requestOptions);
        }

        public virtual Discount DeleteSubscriptionDiscount(string subscriptionId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/subscriptions/{subscriptionId}/discount", requestOptions);
        }

        public virtual Task<Discount> DeleteCustomerDiscountAsync(string customerId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/customers/{customerId}/discount", requestOptions, cancellationToken);
        }

        public virtual Task<Discount> DeleteSubscriptionDiscountAsync(string subscriptionId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/subscriptions/{subscriptionId}/discount", requestOptions, cancellationToken);
        }
    }
}
