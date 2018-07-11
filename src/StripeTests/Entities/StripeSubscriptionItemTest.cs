namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeSubscriptionItemTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/subscription_items/si_123");
            var subscriptionItem = Mapper<StripeSubscriptionItem>.MapFromJson(json);
            Assert.NotNull(subscriptionItem);
            Assert.IsType<StripeSubscriptionItem>(subscriptionItem);
            Assert.NotNull(subscriptionItem.Id);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }
    }
}
