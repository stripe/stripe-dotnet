using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    [Ignore("This tests needs to be fixed - the functionality works")]
    public class when_updating_a_subscription_with_proration
    {
        private static StripeSubscriptionService _subscriptionService;
        private static StripeSubscription _subscription;
        private static string _customerId;
        private static string _planId;
        private static StripeInvoice _upcomingInvoice;

        Establish context = () =>
        {
            var planService = new StripePlanService();
            var plan = planService.Create(test_data.stripe_plan_create_options.ThirtyDayIntervalWithFiveDollars());

            var customerService = new StripeCustomerService();
            var customer = customerService.Create(test_data.stripe_customer_create_options.ValidCard());

            _subscriptionService = new StripeSubscriptionService();
            _subscription = _subscriptionService.Create(customer.Id, plan.Id);

            _customerId = customer.Id;
            _planId = plan.Id;
        };

        Because of = () =>
        {
            var updateOptions = new StripeSubscriptionUpdateOptions()
            {
                ProrationDate = DateTime.Now.AddDays(15),
                Quantity = 2,
            };

            _subscription = _subscriptionService.Update(_subscription.Id, updateOptions);

            _upcomingInvoice = new StripeInvoiceService().Upcoming(_customerId, new StripeUpcomingInvoiceOptions() { SubscriptionId = _subscription.Id });
        };

        It should_be_the_right_amount = () =>
        {
            // the first one was $5 for the month. The second month is $10 because the quantity went to two
            // however, we are prorating the first one 15 days, so it should only be about half the price, give or take
            _upcomingInvoice.AmountDue.ShouldBeGreaterThan(1250);
            _upcomingInvoice.AmountDue.ShouldBeLessThan(1300);
        };
    }
}