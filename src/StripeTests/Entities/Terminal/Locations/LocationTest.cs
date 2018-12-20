namespace StripeTests.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Terminal;
    using Xunit;

    public class LocationTest : BaseStripeTest
    {
        public LocationTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/terminal/locations/loc_123");
            var location = JsonConvert.DeserializeObject<Location>(json);
            Assert.NotNull(location);
            Assert.IsType<Location>(location);
            Assert.NotNull(location.Id);
            Assert.Equal("terminal.location", location.Object);
        }
    }
}
