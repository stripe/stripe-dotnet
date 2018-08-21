namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class EventTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/events/evt_123");
            var evt = Mapper<Event>.MapFromJson(json);
            Assert.NotNull(evt);
            Assert.IsType<Event>(evt);
            Assert.NotNull(evt.Id);
            Assert.Equal("event", evt.Object);
        }
    }
}
