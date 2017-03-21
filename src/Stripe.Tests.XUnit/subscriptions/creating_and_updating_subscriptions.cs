using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_subscriptions : IClassFixture<subscription_fixture>
    {
        private readonly subscription_fixture fixture;

        public creating_and_updating_subscriptions(subscription_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_is_not_null()
        {
            fixture.Subscription.Should().NotBeNull();
        }

        [Fact]
        public void created_items_is_not_null()
        {
            fixture.Subscription.Items.Should().NotBeNull();
        }

        [Fact]
        public void created_has_right_number_of_items()
        {
            fixture.Subscription.Items.TotalCount.Should().Be(fixture.SubscriptionCreateOptions.Items.Count);
        }

        [Fact]
        public void created_has_right_first_item_quantity()
        {
            fixture.Subscription.Items.Data[0].Quantity.Should().Be(fixture.SubscriptionCreateOptions.Items[0].Quantity);
        }

        [Fact]
        public void created_has_right_second_item_quantity()
        {
            fixture.Subscription.Items.Data[1].Quantity.Should().Be(fixture.SubscriptionCreateOptions.Items[1].Quantity);
        }

        [Fact]
        public void updated_has_right_number_of_items()
        {
            fixture.SubscriptionUpdated.Items.TotalCount.Should().Be(fixture.SubscriptionUpdateOptions.Items.Count - 1);
        }

        [Fact]
        public void updated_has_right_quantity()
        {
            fixture.SubscriptionUpdated.Items.Data[0].Quantity.Should().Be(fixture.SubscriptionUpdateOptions.Items[1].Quantity);
        }
    }
}
