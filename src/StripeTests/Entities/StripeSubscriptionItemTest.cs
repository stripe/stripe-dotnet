namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class SubscriptionItemTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/subscription_items/si_123");
            var subscriptionItem = Mapper<SubscriptionItem>.MapFromJson(json);
            Assert.NotNull(subscriptionItem);
            Assert.IsType<SubscriptionItem>(subscriptionItem);
            Assert.NotNull(subscriptionItem.Id);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }
    }
}
