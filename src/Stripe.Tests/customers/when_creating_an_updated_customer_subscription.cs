using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_an_updated_customer_subscription
    {
        private static StripePlan _stripePlan;
        private static StripeCoupon _stripeCoupon;
        private static StripeCustomer _stripeCustomer;
        private static StripeSubscription _stripeSubscription;
        private static StripeCustomerService _stripeCustomerService;

        Establish context = () =>
        {
			var _stripePlanService = new StripePlanService(false);
            _stripePlan = _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

			var _stripeCouponService = new StripeCouponService(false);
            _stripeCoupon = _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());

			_stripeCustomerService = new StripeCustomerService(false);
            _stripeCustomer = _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());
        };

        Because of = () =>
        {
            _stripeSubscription = _stripeCustomerService.UpdateSubscription(_stripeCustomer.Id, test_data.stripe_customer_update_subscription_options.ValidCard(_stripePlan.Id, _stripeCoupon.Id));
            
            // have to load this again to make sure the coupon took
            _stripeCustomer = _stripeCustomerService.Get(_stripeCustomer.Id);
        };

        It should_have_the_new_plan = () =>
            _stripeSubscription.StripePlan.Id.ShouldEqual(_stripePlan.Id);

        It should_have_the_new_coupon = () =>
            _stripeCustomer.StripeDiscount.StripeCoupon.Id.ShouldEqual(_stripeCoupon.Id);
    }
}