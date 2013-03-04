using Machine.Specifications;

namespace Stripe.Tests
{
	[Ignore("this test should work, but it requires an oauth connection, not sure how best to handle this yet in testing")]
	public class when_creating_a_token_with_a_customer
	{
		protected static StripeCustomerCreateOptions StripeCustomerCreateOptions;
		protected static StripeCustomer StripeCustomer;

		protected static StripeTokenCreateOptions StripeTokenCreateOptions;
		protected static StripeToken StripeToken;

		private static StripeTokenService _stripeTokenService;

		Establish context = () =>
		{
			var _stripeCustomerService = new StripeCustomerService();
			StripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard();
			
			StripeCustomer = _stripeCustomerService.Create(StripeCustomerCreateOptions);

			_stripeTokenService = new StripeTokenService();
		};

		Because of = () =>
			StripeToken = _stripeTokenService.Create(new StripeTokenCreateOptions() { CustomerId = StripeCustomer.Id });

		Behaves_like<token_behaviors> behaviors;
	}
}
