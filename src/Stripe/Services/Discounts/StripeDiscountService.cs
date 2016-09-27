using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeDiscountService :StripeService 
    {
        public StripeDiscountService(string apiKey = null) : base(apiKey) {}


        public virtual StripeDiscountDelete DeleteCustomerDiscount(string customerId, StripeRequestOptions requestOptions = null) 
        {
            var customerUrl = string.Format(Urls.CustomerDiscount, customerId);
            return Mapper<StripeDiscountDelete>.MapFromJson(Requestor.Delete(customerUrl, SetupRequestOptions(requestOptions)));
        }

        public virtual StripeDiscountDelete DeleteSubscriptionDiscount(string subscriptionId, StripeRequestOptions requestOptions = null) 
        {
            var url = String.Format(Urls.SubscriptionDiscount, subscriptionId);
            return Mapper<StripeDiscountDelete>.MapFromJson(Requestor.Delete(url, SetupRequestOptions(requestOptions)));
        }
        
        public virtual async Task<StripeDiscountDelete> DeleteCustomerDiscountAsync(string customerId, StripeRequestOptions requestOptions = null) 
        {
            var customerUrl = string.Format(Urls.CustomerDiscount, customerId);
            return Mapper<StripeDiscountDelete>.MapFromJson(await Requestor.DeleteAsync(customerUrl, SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeDiscountDelete> DeleteSubscriptionDiscountAsync(string subscriptionId, StripeRequestOptions requestOptions = null) 
        {
            var url = String.Format(Urls.SubscriptionDiscount, subscriptionId);
            return Mapper<StripeDiscountDelete>.MapFromJson(await Requestor.DeleteAsync(url, SetupRequestOptions(requestOptions)));
        }


    }
}
