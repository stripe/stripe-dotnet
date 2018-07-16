namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class StripeDiscountService : StripeBasicService<StripeDiscount>
    {
        public StripeDiscountService()
            : base(null)
        {
        }

        public StripeDiscountService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeDeleted DeleteCustomerDiscount(string customerId, StripeRequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/customers/{customerId}/discount", requestOptions);
        }

        public virtual StripeDeleted DeleteSubscriptionDiscount(string subscriptionId, StripeRequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/subscriptions/{subscriptionId}/discount", requestOptions);
        }

        public virtual Task<StripeDeleted> DeleteCustomerDiscountAsync(string customerId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/customers/{customerId}/discount", requestOptions, cancellationToken);
        }

        public virtual Task<StripeDeleted> DeleteSubscriptionDiscountAsync(string subscriptionId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/subscriptions/{subscriptionId}/discount", requestOptions, cancellationToken);
        }
    }
}
