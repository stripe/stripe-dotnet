using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stripe.Services.Discounts {
    public class StripeDiscountService :StripeService 
    {
        private StripeCustomerService _stripeCustomerService => new StripeCustomerService(ApiKey);
        private StripeSubscriptionService _stripeSubscriptionService => new StripeSubscriptionService(ApiKey);
        public StripeDiscountService(string apiKey) : base(apiKey) {}


        public virtual StripeDiscountDelete DeleteCustomerDiscount(string customerId, StripeRequestOptions requestOptions = null) 
        {
            return _stripeCustomerService.DeleteDiscount(customerId, requestOptions);
        }

        public virtual StripeDiscountDelete DeleteSubscriptionDiscount(string subscriptionId, StripeRequestOptions requestOptions = null) 
        {
            return _stripeSubscriptionService.DeleteDiscount(subscriptionId, requestOptions);
        }

#if !PORTABLE
        public virtual Task<StripeDiscountDelete> DeleteCustomerDiscountAsync(string customerId, StripeRequestOptions requestOptions = null) 
        {
            return _stripeCustomerService.DeleteDiscountAsync(customerId, requestOptions);
        }

        public virtual Task<StripeDiscountDelete> DeleteSubscriptionDiscountAsync(string subscriptionId, StripeRequestOptions requestOptions = null) 
        {
            return _stripeSubscriptionService.DeleteDiscountAsync(subscriptionId, requestOptions);
        }
#endif


    }
}
