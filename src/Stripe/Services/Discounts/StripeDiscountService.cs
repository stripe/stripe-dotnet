using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeDiscountService : StripeBasicService<StripeDiscount>
    {
        public StripeDiscountService(string apiKey = null) : base(apiKey) { }

        // Sync
        public virtual StripeDeleted DeleteCustomerDiscount(string customerId, StripeRequestOptions requestOptions = null)
        {
            return Delete($"{Urls.BaseUrl}/customers/{customerId}/discount", requestOptions);
        }

        public virtual StripeDeleted DeleteSubscriptionDiscount(string subscriptionId, StripeRequestOptions requestOptions = null)
        {
            return Delete($"{Urls.BaseUrl}/subscriptions/{subscriptionId}/discount", requestOptions);
        }



        // Async
        public virtual Task<StripeDeleted> DeleteCustomerDiscountAsync(string customerId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteAsync($"{Urls.BaseUrl}/customers/{customerId}/discount", requestOptions, cancellationToken);
        }

        public virtual Task<StripeDeleted> DeleteSubscriptionDiscountAsync(string subscriptionId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteAsync($"{Urls.BaseUrl}/subscriptions/{subscriptionId}/discount", requestOptions, cancellationToken);
        }
    }
}
