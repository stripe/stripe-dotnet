using System;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_subscription
    {
        private static StripeCustomer _stripeCustomer;
        private static StripeSubscription _stripeSubscription;
        private static StripeSubscriptionService _stripeSubscriptionService;

        Establish context = () =>
        {
            var _stripePlanService = new StripePlanService();
            var _stripePlan = _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

            var _stripeCouponService = new StripeCouponService();
            var _stripeCoupon = _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());

            var _stripeCustomerService = new StripeCustomerService();
            _stripeCustomer = _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard(_stripePlan.Id, _stripeCoupon.Id, DateTime.UtcNow.AddDays(10)));
        
            _stripeSubscriptionService = new StripeSubscriptionService();
        };

        Because of = () =>
            _stripeSubscription = _stripeSubscriptionService.Get(_stripeSubscriptionService.List(new StripeSubscriptionListOptions { CustomerId = _stripeCustomer.Id }).ToList()[0].Id);

        It should_get_the_same_subscription = () =>
            _stripeSubscription.ShouldNotBeNull();
    }
}