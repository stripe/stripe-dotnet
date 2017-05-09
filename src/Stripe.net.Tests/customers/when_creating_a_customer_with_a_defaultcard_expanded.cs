using System;
using System.Linq;
using Machine.Specifications;

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
            _stripeCustomerService.ExpandDefaultSource = true;
            StripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(StripePlan.Id, StripeCoupon.Id, DateTime.UtcNow.AddDays(5));
        };

        Because of = () =>
        {
            StripeCustomer = _stripeCustomerService.Create(StripeCustomerCreateOptions);

            StripeCard = StripeCustomer.Sources.Data.First().Card;
        };

#pragma warning disable 169, 414
        Behaves_like<customer_behaviors> behaviors;
#pragma warning restore 169, 414

        It should_have_the_defaultcard = () =>
            StripeCustomer.DefaultSource.ShouldNotBeNull();

        It should_have_the_defaultcardid = () =>
            StripeCustomer.DefaultSourceId.ShouldNotBeNull();
    }
}