using Machine.Specifications;

namespace Stripe.Tests
{
	public class when_canceling_a_customer_subscription
	{
		private static StripePlan _stripePlan;
		private static StripeCustomer _stripeCustomer;
		private static StripeSubscription _stripeSubscription;
		private static StripeCustomerService _stripeCustomerService;

		Establish context = () =>
		{
			var _stripePlanService = new StripePlanService();
			_stripePlan = _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

			_stripeCustomerService = new StripeCustomerService();
			_stripeCustomer = _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard(_stripePlan.Id));
		};

		Because of = () =>
		{
			_stripeSubscription = _stripeCustomerService.CancelSubscription(_stripeCustomer.Id);

			// have to load this again to make sure the coupon took
			_stripeCustomer = _stripeCustomerService.Get(_stripeCustomer.Id);
		};

		It should_have_the_new_plan = () =>
			_stripeSubscription.StripePlan.Id.ShouldEqual(_stripePlan.Id);
	}
}