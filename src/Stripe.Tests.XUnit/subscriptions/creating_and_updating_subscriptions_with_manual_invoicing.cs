using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_subscriptions_with_manual_invoicing
    {
        public StripeSubscription SubscriptionCreated { get; }
        public StripeSubscription SubscriptionUpdated { get; }

        public creating_and_updating_subscriptions_with_manual_invoicing()
        {
            var customerService = new StripeCustomerService(Cache.ApiKey);
            var subscriptionService = new StripeSubscriptionService(Cache.ApiKey);

            var CustomerCreateOptions = new StripeCustomerCreateOptions
            {
                Email = "manual-invoicing@example.com",
            };
            var Customer = customerService.Create(CustomerCreateOptions);

            var SubscriptionCreateOptions = new StripeSubscriptionCreateOptions
            {
                Billing = StripeBilling.SendInvoice,
                DaysUntilDue = 7,
                PlanId = Cache.GetPlan("silver").Id
            };
            SubscriptionCreated = subscriptionService.Create(Customer.Id, SubscriptionCreateOptions);

            var SubscriptionUpdateOptions = new StripeSubscriptionUpdateOptions
            {
                DaysUntilDue = 2,
            };
            SubscriptionUpdated = subscriptionService.Update(SubscriptionCreated.Id, SubscriptionUpdateOptions);
        }

        [Fact]
        public void subscription_created_should_not_be_null()
        {
            SubscriptionCreated.Should().NotBeNull();
        }

        [Fact]
        public void subscription_created_has_correct_billing()
        {
            SubscriptionCreated.Billing.Should().Be(StripeBilling.SendInvoice);
        }

        [Fact]
        public void subscription_created_has_correct_days_until_due()
        {
            SubscriptionCreated.DaysUntilDue.Should().Be(7);
        }

        [Fact]
        public void subscription_updated_should_not_be_null()
        {
            SubscriptionUpdated.Should().NotBeNull();
        }

        [Fact]
        public void subscription_updated_has_correct_days_until_due()
        {
            SubscriptionUpdated.DaysUntilDue.Should().Be(2);
        }
    }
}
