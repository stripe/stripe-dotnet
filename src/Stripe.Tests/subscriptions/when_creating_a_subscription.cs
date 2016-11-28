using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_subscription
    {
        private static StripeCustomer _stripeCustomer;
        private static StripePlan _stripePlan;
        private static StripeSubscription _stripeSubscription;
        private static StripeSubscriptionService _stripeSubscriptionService;
        private static StripeSubscriptionCreateOptions _stripeSubscriptionCreateOptions;

        Establish context = () =>
        {
            var _stripeCustomerService = new StripeCustomerService();
            _stripeCustomer = _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());
        
            var _stripePlanService = new StripePlanService();
            _stripePlan = _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

            _stripeSubscriptionService = new StripeSubscriptionService();

            _stripeSubscriptionCreateOptions = new StripeSubscriptionCreateOptions();
            _stripeSubscriptionCreateOptions.Quantity = 2;
        };

        Because of = () =>
            _stripeSubscription = _stripeSubscriptionService.Create(_stripeCustomer.Id, _stripePlan.Id, _stripeSubscriptionCreateOptions);

        It should_get_the_same_subscription = () =>
            _stripeSubscription.StripePlan.Id.ShouldEqual(_stripePlan.Id);

        It should_have_the_same_quantity = () =>
            _stripeSubscription.Quantity.ShouldEqual(2);

        It should_have_a_recent_created_date = () =>
            _stripeSubscription.Created.Value.ShouldBeGreaterThan(DateTime.Now.AddSeconds(-5));
    }
}