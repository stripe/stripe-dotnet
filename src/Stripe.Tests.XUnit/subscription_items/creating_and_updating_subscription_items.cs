using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_subscription_items : IClassFixture<subscription_item_fixture>
    {
        private readonly subscription_item_fixture fixture;

        public creating_and_updating_subscription_items(subscription_item_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_is_not_null()
        {
            fixture.SubscriptionItem.Should().NotBeNull();
        }

        [Fact]
        public void created_has_right_quantity()
        {
            fixture.SubscriptionItem.Quantity.Should().Be(fixture.SubscriptionItemCreateOptions.Quantity);
        }

        [Fact]
        public void created_has_right_plan()
        {
            fixture.SubscriptionItem.Plan.Id.Should().Be(fixture.SubscriptionItemCreateOptions.PlanId);
        }

        [Fact]
        public void updated_is_not_null()
        {
            fixture.SubscriptionItemUpdated.Should().NotBeNull();
        }

        [Fact]
        public void updated_has_right_quantity()
        {
            fixture.SubscriptionItemUpdated.Quantity.Should().Be(fixture.SubscriptionItemUpdateOptions.Quantity);
        }

        [Fact]
        public void retrieved_is_not_null()
        {
            fixture.SubscriptionItemRetrieved.Should().NotBeNull();
        }

        [Fact]
        public void list_is_not_null()
        {
            fixture.SubscriptionItemList.Should().NotBeNull();
        }

        [Fact]
        public void list_has_atleast_one_item()
        {
            fixture.SubscriptionItemList.ToList().Count.Should().BeGreaterOrEqualTo(1);
        }

        [Fact]
        public void subscription_has_subscription_items()
        {
            Cache.GetSubscription().Items.Should().NotBeNull();
        }

        [Fact]
        public void subscriptions_first_subscription_item_has_a_plan()
        {
            Cache.GetSubscription().Items.Data.First().Plan.Should().NotBeNull();
        }
    }
}
