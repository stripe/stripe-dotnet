using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_customer_with_trial_end_now
    {
        protected static StripeCustomerCreateOptions StripeCustomerCreateOptions;
        protected static StripeCustomer StripeCustomer;
        protected static StripePlan StripePlan;
        protected static StripeCoupon StripeCoupon;
        protected static StripeCard StripeCard;

        private static StripeSubscription _stripeSubscription;
        private static StripeCustomerService _stripeCustomerService;

        Establish context = () =>
        {
            var _stripePlanService = new StripePlanService();
            StripePlan = _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

            var _stripeCouponService = new StripeCouponService();
            StripeCoupon = _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());

            _stripeCustomerService = new StripeCustomerService();
            StripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(StripePlan.Id, StripeCoupon.Id, null, true);
        };

        Because of = () =>
        {
            StripeCustomer = _stripeCustomerService.Create(StripeCustomerCreateOptions);

            StripeCard = StripeCustomer.Sources.Data.First().Card;

            _stripeSubscription = StripeCustomer.Subscriptions.Data.First();
        };

#pragma warning disable 169, 414
        Behaves_like<customer_behaviors> behaviors;
#pragma warning restore 169, 414

        It should_return_now_for_internal_trialend = () =>
            StripeCustomerCreateOptions.TrialEndInternal.ShouldEqual("now");

        It should_have_expired_trial_start = () =>
            _stripeSubscription.TrialStart.ShouldBeNull();

        It should_have_expired_trial_end = () =>
            _stripeSubscription.TrialEnd.ShouldBeNull();
    }
}