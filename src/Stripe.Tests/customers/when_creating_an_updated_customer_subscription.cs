using Machine.Specifications;
using System;

namespace Stripe.Tests
{
	public class when_creating_an_updated_customer_subscription
	{
		private static StripePlan _stripePlan;
		private static StripeCoupon _stripeCoupon;
		private static StripeCustomer _stripeCustomer;
		private static StripeSubscription _stripeSubscription;
		private static StripeCustomerService _stripeCustomerService;
		private static StripeCustomerUpdateSubscriptionOptions _stripeCustomerUpdateSubscriptionOptions;

		Establish context = () =>
		{
			var _stripePlanService = new StripePlanService();
            _stripePlan = _stripePlanService.Create(test_data.stripe_plan_create_options.Valid()).Await();

			var _stripeCouponService = new StripeCouponService();
            _stripeCoupon = _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid()).Await();

			_stripeCustomerUpdateSubscriptionOptions = test_data.stripe_customer_update_subscription_options.ValidCard(_stripePlan.Id, _stripeCoupon.Id, DateTime.UtcNow.AddDays(5), 3);

			_stripeCustomerService = new StripeCustomerService();
            _stripeCustomer = _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard()).Await();
		};

		Because of = async () =>
		{
            _stripeSubscription = _stripeCustomerService.UpdateSubscription(_stripeCustomer.Id, _stripeCustomerUpdateSubscriptionOptions).Await();
			
			// have to load this again to make sure the coupon took
            _stripeCustomer = _stripeCustomerService.Get(_stripeCustomer.Id).Await();
		};

		It should_have_the_new_plan = () =>
			_stripeSubscription.StripePlan.Id.ShouldEqual(_stripePlan.Id);

		It should_have_the_new_coupon = () =>
			_stripeCustomer.StripeDiscount.StripeCoupon.Id.ShouldEqual(_stripeCoupon.Id);

		It should_have_the_new_trial_end = () =>
			_stripeCustomer.StripeSubscription.TrialEnd.Value.Date.ShouldEqual(_stripeCustomerUpdateSubscriptionOptions.TrialEnd.Value.Date);

		It should_have_the_new_quantity = () =>
			_stripeCustomer.StripeSubscription.Quantity.ShouldEqual(_stripeCustomerUpdateSubscriptionOptions.Quantity.Value);
	}
}