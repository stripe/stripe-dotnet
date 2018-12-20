namespace StripeTests.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Terminal;
    using Xunit;

    public class ConnectionTokenTest : BaseStripeTest
    {
        public ConnectionTokenTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.connection_token.json");
            var connectionToken = JsonConvert.DeserializeObject<ConnectionToken>(json);
            Assert.NotNull(connectionToken);
            Assert.IsType<ConnectionToken>(connectionToken);
            Assert.NotNull(connectionToken.Secret);
            Assert.Equal("terminal.connection_token", connectionToken.Object);
        }
    }
}
