using System.Collections.Generic;
using System.Linq;

namespace Stripe
{
    public class StripeCustomerService
    {
        public StripeCustomer Create(StripeCustomerCreateOptions createOptions)
        {
            var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Customers);
            
            var response = Requestor.PostString(url);

            return PopulateStripeCustomer(response);
        }

        public StripeCustomer Get(string customerId)
        {
            var url = string.Format("{0}/{1}", Urls.Customers, customerId);

            var response = Requestor.GetString(url);

            return PopulateStripeCustomer(response);
        }

        public StripeCustomer Update(string customerId, StripeCustomerUpdateOptions updateOptions)
        {
            var url = string.Format("{0}/{1}", Urls.Customers, customerId);
            url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

            var response = Requestor.PostString(url);

            return PopulateStripeCustomer(response);
        }

        public void Delete(string customerId)
        {
            var url = string.Format("{0}/{1}", Urls.Customers, customerId);

            Requestor.Delete(url);
        }

        public IEnumerable<StripeCustomer> List(int count = 10, int offset = 0)
        {
            var url = Urls.Coupons;
            url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
            url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

            var response = Requestor.GetString(url);

            var json = Mapper<StripeCustomer>.MapCollectionToObjectList(response);

            return json.Select(PopulateStripeCustomer);
        }

        public StripeSubscription UpdateSubscription(string customerId, StripeCustomerUpdateSubscriptionOptions updateOptions)
        {
            var url = string.Format("{0}/{1}/subscription", Urls.Customers, customerId);
            url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

            var response = Requestor.PostString(url);

            var subscription = Mapper<StripeSubscription>.MapFromJson(response);
            subscription.StripePlan = Mapper<StripePlan>.MapFromJson(response, "plan.");

            return subscription;
        }

        public StripeSubscription CancelSubscription(string customerId, bool cancelAtPeriodEnd = false)
        {
            var url = string.Format("{0}/{1}/subscription", Urls.Customers, customerId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "at_period_end", cancelAtPeriodEnd.ToString());

            var response = Requestor.Delete(url);

            var subscription = Mapper<StripeSubscription>.MapFromJson(response);
            subscription.StripePlan = Mapper<StripePlan>.MapFromJson(response, "plan.");

            return subscription;
        }

        private StripeCustomer PopulateStripeCustomer(string json)
        {
            var stripeCustomer = Mapper<StripeCustomer>.MapFromJson(json);
            stripeCustomer.StripeNextRecurringCharge = Mapper<StripeNextRecurringCharge>.MapFromJson(json, "next_recurring_charge.");
            stripeCustomer.StripeDiscount = Mapper<StripeDiscount>.MapFromJson(json, "discount.");

            if (stripeCustomer.StripeDiscount != null)
                stripeCustomer.StripeDiscount.StripeCoupon = Mapper<StripeCoupon>.MapFromJson(json, "discount.coupon.");

            stripeCustomer.StripeSubscription = Mapper<StripeSubscription>.MapFromJson(json, "subscription.");

            if (stripeCustomer.StripeSubscription != null)
                stripeCustomer.StripeSubscription.StripePlan = Mapper<StripePlan>.MapFromJson(json, "subscription.plan.");

            stripeCustomer.StripeCard = Mapper<StripeCard>.MapFromJson(json, "active_card.");

            return stripeCustomer;
        }
    }
}