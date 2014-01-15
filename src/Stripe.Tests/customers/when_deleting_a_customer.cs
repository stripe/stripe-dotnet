using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_deleting_a_customer
	{
		private static StripeCustomerService _stripeCustomerService;
		private static string _createdStripeCustomerId;

		Establish context = () =>
		{
			_stripeCustomerService = new StripeCustomerService();

            StripeCustomer stripeCustomer = _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard()).Await();
			_createdStripeCustomerId = stripeCustomer.Id;
		};

		Because of = () =>
            _stripeCustomerService.Delete(_createdStripeCustomerId).Await();

		It should_show_as_deleted = () =>
            ((StripeCustomer)_stripeCustomerService.Get(_createdStripeCustomerId).Await()).Deleted.ShouldEqual(true);
	}
}