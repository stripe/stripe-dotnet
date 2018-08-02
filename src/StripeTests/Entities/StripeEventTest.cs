namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeEventTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/events/evt_123");
            var evt = Mapper<StripeEvent>.MapFromJson(json);
            Assert.NotNull(evt);
            Assert.IsType<StripeEvent>(evt);
            Assert.NotNull(evt.Id);
            Assert.Equal("event", evt.Object);
        }
    }
}
