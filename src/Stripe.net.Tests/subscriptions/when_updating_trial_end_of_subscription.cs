using System;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_updating_trial_end_of_subscription
    {
        private static StripeCustomer _stripeCustomer;
        private static StripeSubscriptionUpdateOptions _stripeSubscriptionUpdateOptions;
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

            _stripeSubscriptionUpdateOptions = new StripeSubscriptionUpdateOptions();
            _stripeSubscriptionUpdateOptions.EndTrialNow = true;
        };

        Because of = () =>
            _stripeSubscription = _stripeSubscriptionService.Update(_stripeCustomer.Id, _stripeSubscriptionService.List(_stripeCustomer.Id).ToList()[0].Id, _stripeSubscriptionUpdateOptions);

        It should_return_now_for_internal_trialend = () =>
            _stripeSubscriptionUpdateOptions.TrialEndInternal.ShouldEqual("now");

        It should_have_expired_trial_start = () =>
            _stripeSubscription.TrialStart.ShouldBeNull();

        It should_have_expired_trial_end = () =>
            _stripeSubscription.TrialEnd.ShouldBeNull();
    }
}
