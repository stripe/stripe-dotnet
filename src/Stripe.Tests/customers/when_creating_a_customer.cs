using System;
using Machine.Specifications;
using System.Linq;

namespace Stripe.Tests
{
    public class when_creating_a_customer
    {
        protected static StripeCustomerCreateOptions StripeCustomerCreateOptions;
        protected static StripeCustomer StripeCustomer;
        protected static StripePlan StripePlan;
        protected static StripeCoupon StripeCoupon;
        protected static StripeCard StripeCard;
        protected static StripeInvoice[] StripeInvoices;

        private static StripeCustomerService _stripeCustomerService;
        private static StripeInvoiceService _stripeInvoiceService;

        Establish context = () =>
        {
            var _stripePlanService = new StripePlanService();
            StripePlan = _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

            var _stripeCouponService = new StripeCouponService();
            StripeCoupon = _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());

            _stripeCustomerService = new StripeCustomerService();
            StripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(StripePlan.Id, StripeCoupon.Id, DateTime.UtcNow.AddDays(5));

            _stripeInvoiceService = new StripeInvoiceService();
        };

        Because of = () =>
        {
            StripeCustomer = _stripeCustomerService.Create(StripeCustomerCreateOptions);

            StripeCard = StripeCustomer.SourceList.Data.First();

            StripeInvoices = _stripeInvoiceService.List(new StripeInvoiceListOptions() { CustomerId = StripeCustomer.Id }).ToArray();
        };

        Behaves_like<customer_behaviors> behaviors;

        It should_have_metadata = () =>
            StripeCustomer.Metadata.Count.ShouldBeGreaterThan(0);

        It should_have_the_correct_metadata = () =>
            StripeCustomer.Metadata.ShouldContainOnly(StripeCustomerCreateOptions.Metadata);

        It should_have_a_paid_invoice = () =>
            StripeInvoices.First().Paid.ShouldBeTrue();
    }
}