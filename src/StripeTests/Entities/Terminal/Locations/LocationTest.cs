namespace StripeTests.Terminal
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Terminal;
    using Xunit;

    public class LocationTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/terminal/locations/loc_123");
            var location = Mapper<Location>.MapFromJson(json);
            Assert.NotNull(location);
            Assert.IsType<Location>(location);
            Assert.NotNull(location.Id);
            Assert.Equal("terminal.location", location.Object);
        }
    }
}
