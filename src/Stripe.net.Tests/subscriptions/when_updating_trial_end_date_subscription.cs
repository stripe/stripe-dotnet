using System;
using System.Linq;
using Machine.Specifications;
using Stripe.Infrastructure;

namespace Stripe.Tests
{
    public class when_updating_trial_end_date_subscription
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
            _stripeCustomer = _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard(_stripePlan.Id, _stripeCoupon.Id, DateTime.UtcNow.AddDays(1)));

            _stripeSubscriptionService = new StripeSubscriptionService();

            _stripeSubscriptionUpdateOptions = new StripeSubscriptionUpdateOptions();
            _stripeSubscriptionUpdateOptions.TrialEnd = DateTime.UtcNow.AddDays(10);
        };

        Because of = () =>
            _stripeSubscription = _stripeSubscriptionService.Update(_stripeCustomer.Id, _stripeSubscriptionService.List(_stripeCustomer.Id).ToList()[0].Id, _stripeSubscriptionUpdateOptions);

        It should_return_text_version_of_date_for_internal_trialend = () =>
            _stripeSubscriptionUpdateOptions.TrialEndInternal.ShouldEqual(EpochTime.ConvertDateTimeToEpoch(_stripeSubscriptionUpdateOptions.TrialEnd.Value).ToString());

        It should_have_trial_end_date = () => 
            _stripeSubscription.TrialEnd.ShouldNotBeNull();

        It should_have_trial_end_date_in_future = () =>
            _stripeSubscription.TrialEnd.Value.ShouldBeGreaterThan(DateTime.UtcNow.AddDays(2));
    }
}
