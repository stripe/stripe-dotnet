using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_an_upcoming_invoice_with_options
    {
        private static StripePlan _stripePlan;
        private static StripeCustomer _stripeCustomer;
        private static StripeInvoiceService _stripeInvoiceService;
        private static StripeInvoice _stripeInvoice;
        private static StripeUpcomingInvoiceOptions _stripeUpcomingInvoiceOptions;

        Establish context = () =>
        {
            var stripePlanService = new StripePlanService();
            var stripePlanCreateOptions = test_data.stripe_plan_create_options.Valid();
            _stripePlan = stripePlanService.Create(stripePlanCreateOptions);

            var stripeCustomerService = new StripeCustomerService();
            var stripeCustomerCreateOptions = test_data.stripe_customer_create_options.ValidCard(_stripePlan.Id);
            _stripeCustomer = stripeCustomerService.Create(stripeCustomerCreateOptions);

            _stripeInvoiceService = new StripeInvoiceService();

            _stripeUpcomingInvoiceOptions = new StripeUpcomingInvoiceOptions
            {
                SubscriptionId = _stripeCustomer.Subscriptions.Data.First().Id,
                SubscriptionPlanId = _stripePlan.Id,
            };
        };

        Because of = () =>
            _stripeInvoice = _stripeInvoiceService.Upcoming(_stripeCustomer.Id, _stripeUpcomingInvoiceOptions);

        It should_have_the_correct_subscription_id = () =>
            _stripeInvoice.SubscriptionId.ShouldEqual(_stripeUpcomingInvoiceOptions.SubscriptionId);

        It should_have_the_correct_plan = () =>
            _stripeInvoice.StripeInvoiceLineItems.Data.First().Plan.Id.ShouldEqual(_stripePlan.Id);

        It should_have_the_correct_plan_amount = () =>
            _stripeInvoice.StripeInvoiceLineItems.Data.First().Amount.ShouldEqual(_stripePlan.Amount);
    }
}