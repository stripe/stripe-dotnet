using FluentAssertions;
using System.Collections.Generic;
using System;
using System.Linq;
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

        [Fact]
        public void ended_should_not_be_null()
        {
            fixture.SubscriptionEnded.Should().NotBeNull();
        }

        [Fact]
        public void list_is_iterable()
        {
            var count = 0;
            IEnumerable<StripeSubscription> enumerable = fixture.SubscriptionList as IEnumerable<StripeSubscription>;
            foreach (var obj in enumerable)
            {
                count += 1;
            }
            Assert.Equal(fixture.SubscriptionList.ToList().Count > 0, true);
            Assert.Equal(fixture.SubscriptionList.ToList().Count, count);

        }

        [Fact]
        public void list_contents_equal()
        {

            var datahash = new HashSet<String>();
            foreach (var obj in fixture.SubscriptionList.Data)
            {
                datahash.Add(obj.Id);
            }

            var enumhash = new HashSet<String>();
            IEnumerable<StripeSubscription> enumerable = fixture.SubscriptionList as IEnumerable<StripeSubscription>;
            foreach (var obj in enumerable)
            {
                enumhash.Add(obj.Id);
            }

            Assert.Equal(datahash, enumhash);

        }

        [Fact]
        public void list_contains_extra_attributes()
        {
            Assert.NotNull(fixture.SubscriptionList.Object);
            Assert.Equal(fixture.SubscriptionList.Object, "list");
            Assert.NotNull(fixture.SubscriptionList.Data);
            Assert.NotNull(fixture.SubscriptionList.Url);
        }

    }
}
