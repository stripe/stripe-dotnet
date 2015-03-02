using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_customer_with_a_source_token_id
    {
        protected static StripeCustomerCreateOptions StripeCustomerCreateOptions;
        protected static StripeCustomer StripeCustomer;
        protected static StripePlan StripePlan;
        protected static StripeCoupon StripeCoupon;
        protected static StripeCard StripeCard;

        private static StripeToken _stripeToken;
        private static StripeCustomerService _stripeCustomerService;

        Establish context = () =>
        {
            var _stripePlanService = new StripePlanService();
            StripePlan = _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

            var _stripeCouponService = new StripeCouponService();
            StripeCoupon = _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());

            var stripeTokenService = new StripeTokenService();
            _stripeToken = stripeTokenService.Create(test_data.stripe_token_create_options.Valid());

            _stripeCustomerService = new StripeCustomerService();
            StripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidSourceTokenId(_stripeToken.Id);
        };

        Because of = () =>
        {
            StripeCustomer = _stripeCustomerService.Create(StripeCustomerCreateOptions);

            StripeCard = _stripeToken.StripeCard;
        };

        Behaves_like<customer_behaviors> behaviors;

        It should_have_the_source_token_id = () =>
            StripeCustomerCreateOptions.SourceTokenId.ShouldNotBeNull();
    }
}