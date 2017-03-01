using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_a_subscription_item
    {
        private StripeSubscriptionItem SubscriptionItem { get; set; }

        public creating_a_subscription_item()
        {
            SubscriptionItem = new StripeSubscriptionItemService(Cache.ApiKey).Create(
                new StripeSubscriptionItemCreateOptions
                {
                    PlanId = Cache.GetPlan().Id,
                    SubscriptionId = Cache.GetSubscription().Id,
                    Quantity = 2
                }
            );
        }

        [Fact]
        public void is_not_null()
        {
            SubscriptionItem.Should().NotBeNull();
        }


        [Fact]
        public void has_right_quantity()
        {
            SubscriptionItem.Quantity.Should().Be(2);
        }
    }
}
