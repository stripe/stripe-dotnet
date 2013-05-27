using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_updating_a_customer
	{
		private static StripeCustomer _stripeCustomer;
		private static StripeCustomerService _stripeCustomerService;
		private static string _createdStripeCustomerId;
		private static StripeCustomerUpdateOptions _stripeCustomerUpdateOptions;

		Establish context = () =>
		{
			_stripeCustomerService = new StripeCustomerService();

			var stripeCustomer = _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());
			_createdStripeCustomerId = stripeCustomer.Id;
			
			_stripeCustomerUpdateOptions = test_data.stripe_customer_update_options.Valid();
		};

		Because of = () =>
			_stripeCustomer = _stripeCustomerService.Update(_createdStripeCustomerId, _stripeCustomerUpdateOptions);

		It should_have_the_correct_description = () =>
			_stripeCustomer.Description.ShouldEqual(_stripeCustomerUpdateOptions.Description);

		It should_have_the_correct_account_balance = () =>
			_stripeCustomer.AccountBalance.ShouldEqual(1000);
	}
}