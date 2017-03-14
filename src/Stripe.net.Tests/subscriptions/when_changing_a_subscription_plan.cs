using System;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_changing_a_subscription_plan
    {
        private static StripeCustomer _stripeCustomer;
        private static StripeSubscriptionUpdateOptions _stripeSubscriptionUpdateOptions;
        private static StripeSubscription _stripeSubscription;
        private static StripeSubscriptionService _stripeSubscriptionService;
        private static StripePlan _stripePlan2;

        Establish context = () =>
        {
            var _stripePlanService = new StripePlanService();
            var _stripePlan1 = _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());
            _stripePlan2 = _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

            var _stripeCouponService = new StripeCouponService();
            var _stripeCoupon = _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());

            var _stripeCustomerService = new StripeCustomerService();
            _stripeCustomer = _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard(_stripePlan1.Id, _stripeCoupon.Id, DateTime.UtcNow.AddDays(10)));
        
            _stripeSubscriptionService = new StripeSubscriptionService();

            _stripeSubscriptionUpdateOptions = new StripeSubscriptionUpdateOptions();
            _stripeSubscriptionUpdateOptions.PlanId = _stripePlan2.Id;
        };

        Because of = () =>
            _stripeSubscription = _stripeSubscriptionService.Update(_stripeSubscriptionService.List(new StripeSubscriptionListOptions { CustomerId = _stripeCustomer.Id }).ToList()[0].Id, _stripeSubscriptionUpdateOptions);

        It should_have_the_same_id_as_the_new_plan = () =>
            _stripeSubscription.StripePlan.Id.ShouldEqual(_stripePlan2.Id);
    }
}