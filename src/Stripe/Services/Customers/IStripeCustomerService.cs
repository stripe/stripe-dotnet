using System.Collections.Generic;

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
}
