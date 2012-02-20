using System.Collections.Generic;
using System.Linq;

namespace Stripe
{
    public interface IStripeCustomerService 
    {
        StripeCustomer Create(StripeCustomerCreateOptions createOptions);
        StripeCustomer Get(string customerId);
        StripeCustomer Update(string customerId, StripeCustomerUpdateOptions updateOptions);
        void Delete(string customerId);
        IEnumerable<StripeCustomer> List(int count = 10, int offset = 0);
        StripeSubscription UpdateSubscription(string customerId, StripeCustomerUpdateSubscriptionOptions updateOptions);
        StripeSubscription CancelSubscription(string customerId, bool cancelAtPeriodEnd = false);
    }

    public class StripeCustomerService : IStripeCustomerService 
    {
        public StripeCustomer Create(StripeCustomerCreateOptions createOptions)
        {
            var url = ParameterBuilder.ApplyAllParameters(createOptions, Urls.Customers);

            var response = Requestor.PostString(url);

            return Mapper<StripeCustomer>.MapFromJson(response);
        }

        public StripeCustomer Get(string customerId)
        {
            var url = string.Format("{0}/{1}", Urls.Customers, customerId);

            var response = Requestor.GetString(url);

            return Mapper<StripeCustomer>.MapFromJson(response);
        }

        public StripeCustomer Update(string customerId, StripeCustomerUpdateOptions updateOptions)
        {
            var url = string.Format("{0}/{1}", Urls.Customers, customerId);
            url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

            var response = Requestor.PostString(url);

            return Mapper<StripeCustomer>.MapFromJson(response);
        }

        public void Delete(string customerId)
        {
            var url = string.Format("{0}/{1}", Urls.Customers, customerId);

            Requestor.Delete(url);
        }

        public IEnumerable<StripeCustomer> List(int count = 10, int offset = 0)
        {
            var url = Urls.Customers;
            url = ParameterBuilder.ApplyParameterToUrl(url, "count", count.ToString());
            url = ParameterBuilder.ApplyParameterToUrl(url, "offset", offset.ToString());

            var response = Requestor.GetString(url);

            return Mapper<StripeCustomer>.MapCollectionFromJson(response);
        }

        public StripeSubscription UpdateSubscription(string customerId, StripeCustomerUpdateSubscriptionOptions updateOptions)
        {
            var url = string.Format("{0}/{1}/subscription", Urls.Customers, customerId);
            url = ParameterBuilder.ApplyAllParameters(updateOptions, url);

            var response = Requestor.PostString(url);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }

        public StripeSubscription CancelSubscription(string customerId, bool cancelAtPeriodEnd = false)
        {
            var url = string.Format("{0}/{1}/subscription", Urls.Customers, customerId);
            url = ParameterBuilder.ApplyParameterToUrl(url, "at_period_end", cancelAtPeriodEnd.ToString());

            var response = Requestor.Delete(url);

            return Mapper<StripeSubscription>.MapFromJson(response);
        }
    }
}