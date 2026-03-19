namespace StripeTests
{
    using System.Text.Json;
    using Stripe;
    using Xunit;

    public class EphemeralKeyTest : BaseStripeTest
    {
        public EphemeralKeyTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.ephemeral_key.json");
            var ephemeralKey = JsonSerializer.Deserialize<EphemeralKey>(json);

            Assert.NotNull(ephemeralKey);
            Assert.NotNull(ephemeralKey.Id);
            Assert.Equal("ephemeral_key", ephemeralKey.Object);
        }
    }
}
