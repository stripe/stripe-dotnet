using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_a_subscription_item : IClassFixture<subscription_item_fixture>
    {
        private readonly subscription_item_fixture fixture;

        public creating_a_subscription_item(subscription_item_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void is_not_null()
        {
            fixture.SubscriptionItem.Should().NotBeNull();
        }

        [Fact]
        public void has_right_quantity()
        {
            fixture.SubscriptionItem.Quantity.Should().Be(fixture.SubscriptionItemCreateOptions.Quantity);
        }
    }
}
