using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_listing_customers
	{
		private static IEnumerable<StripeCustomer> _stripeCustomerList;
		private static StripeCustomerService _stripeCustomerService;

		Establish context = () =>
		{
			_stripeCustomerService = new StripeCustomerService();

            _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard()).Await();
            _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard()).Await();
            _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard()).Await();
            _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard()).Await();
		};

		Because of = () =>
			_stripeCustomerList = _stripeCustomerService.List().Result;

		It should_have_atleast_4_entries = () =>
			_stripeCustomerList.Count().ShouldBeGreaterThanOrEqualTo(4);
	}
}