using System;
using Machine.Specifications;
using System.Linq;

namespace Stripe.Tests
{
	public class when_creating_a_customer_with_a_defaultcard_expanded
	{
		protected static StripeCustomerCreateOptions StripeCustomerCreateOptions;
		protected static StripeCustomer StripeCustomer;
		protected static StripePlan StripePlan;
		protected static StripeCoupon StripeCoupon;
		protected static StripeCard StripeCard;

		private static StripeCustomerService _stripeCustomerService;

		Establish context = () =>
		{
			var _stripePlanService = new StripePlanService();
			StripePlan = _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

			var _stripeCouponService = new StripeCouponService();
			StripeCoupon = _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());

			_stripeCustomerService = new StripeCustomerService();
			_stripeCustomerService.ExpandDefaultCard = true;
			StripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(StripePlan.Id, StripeCoupon.Id, DateTime.UtcNow.AddDays(5));
		};

		Because of = () =>
		{
			StripeCustomer = _stripeCustomerService.Create(StripeCustomerCreateOptions);

			StripeCard = StripeCustomer.StripeCardList.StripeCards.First();
		};

		Behaves_like<customer_behaviors> behaviors;

		It should_have_the_defaultcard = () =>
			StripeCustomer.StripeDefaultCard.ShouldNotBeNull();

		It should_have_the_defaultcardid = () =>
			StripeCustomer.StripeDefaultCardId.ShouldNotBeNull();
	}
}