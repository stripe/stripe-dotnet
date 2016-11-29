using System;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_canceling_a_subscription
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
            _stripeSubscription = _stripeSubscriptionService.Cancel(_stripeCustomer.Id, _stripeSubscriptionService.List(_stripeCustomer.Id).ToList()[0].Id);

        It should_be_a_canceled_subscription = () =>
            _stripeSubscription.Status.ShouldEqual("canceled");
    }
}