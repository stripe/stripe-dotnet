using System;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_customer
    {
        protected static StripeCustomerCreateOptions StripeCustomerCreateOptions;
        protected static StripeCustomer StripeCustomer;
        protected static StripePlan StripePlan;
        protected static StripeCoupon StripeCoupon;
        protected static StripeCard StripeCard;

        private static StripeCustomerService _stripeCustomerService;
        private static string _createdStripeCustomerId;

        Establish context = () =>
        {
            var _stripePlanService = new StripePlanService();
            StripePlan = _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

            var _stripeCouponService = new StripeCouponService();
            StripeCoupon = _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());

            _stripeCustomerService = new StripeCustomerService();
            StripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(StripePlan.Id, StripeCoupon.Id, DateTime.UtcNow.AddMonths(1));

            var stripeCustomer = _stripeCustomerService.Create(StripeCustomerCreateOptions);
            _createdStripeCustomerId = stripeCustomer.Id;
        };

        Because of = () =>
        {
            StripeCustomer = _stripeCustomerService.Get(_createdStripeCustomerId);

            StripeCard = StripeCustomer.Sources.Data.First().Card;
        };

#pragma warning disable 169, 414
        Behaves_like<customer_behaviors> behaviors;
#pragma warning restore 169, 414

    }
}