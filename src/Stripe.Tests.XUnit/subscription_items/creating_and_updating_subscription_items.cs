
﻿using FluentAssertions;
using System.Collections.Generic;
using System;
using System.Linq;
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
        public void created_has_right_metadata()
        {
            fixture.SubscriptionItem.Metadata["key"].Should().Be(
              fixture.SubscriptionItemCreateOptions.Metadata["key"]);
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
        public void updated_has_right_metadata()
        {
            fixture.SubscriptionItemUpdated.Metadata["key"].Should().Be(
              fixture.SubscriptionItemUpdateOptions.Metadata["key"]);
        }

        [Fact]
        public void retrieved_is_not_null()
        {
            fixture.SubscriptionItemRetrieved.Should().NotBeNull();
        }

        [Fact]
        public void retrieved_has_right_metadata()
        {
            fixture.SubscriptionItemRetrieved.Metadata["key"].Should().Be(
              fixture.SubscriptionItemUpdateOptions.Metadata["key"]
            );
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

        [Fact]
        public void list_is_iterable()
        {
            var count = 0;
            IEnumerable<StripeSubscriptionItem> enumerable = fixture.SubscriptionItemList as IEnumerable<StripeSubscriptionItem>;
            foreach (var obj in enumerable)
            {
                count += 1;
            }
            Assert.Equal(fixture.SubscriptionItemList.ToList().Count > 0, true);
            Assert.Equal(fixture.SubscriptionItemList.ToList().Count, count);

        }

        [Fact]
        public void list_contents_equal()
        {

            var datahash = new HashSet<String>();
            foreach (var obj in fixture.SubscriptionItemList.Data)
            {
                datahash.Add(obj.Id);
            }

            var enumhash = new HashSet<String>();
            IEnumerable<StripeSubscriptionItem> enumerable = fixture.SubscriptionItemList as IEnumerable<StripeSubscriptionItem>;
            foreach (var obj in enumerable)
            {
                enumhash.Add(obj.Id);
            }

            Assert.Equal(datahash, enumhash);

        }

        [Fact]
        public void list_contains_extra_attributes()
        {
            Assert.NotNull(fixture.SubscriptionItemList.Object);
            Assert.Equal(fixture.SubscriptionItemList.Object, "list");
            Assert.NotNull(fixture.SubscriptionItemList.Data);
            Assert.NotNull(fixture.SubscriptionItemList.Url);
        }

    }
}
