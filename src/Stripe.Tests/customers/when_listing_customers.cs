using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_customers
    {
        private static List<StripeCustomer> _stripeCustomerList;
        private static StripeCustomerService _stripeCustomerService;

        Establish context = () =>
        {
            _stripeCustomerService = new StripeCustomerService();

            _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());
            _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());
            _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());
            _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());
        };

        Because of = () =>
            _stripeCustomerList = _stripeCustomerService.List().ToList();

        It should_have_atleast_4_entries = () =>
            _stripeCustomerList.Count.ShouldBeGreaterThanOrEqualTo(4);
    }
}