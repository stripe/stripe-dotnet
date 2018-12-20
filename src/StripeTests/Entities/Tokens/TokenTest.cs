namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class TokenTest : BaseStripeTest
    {
        public TokenTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/tokens/tok_123");
            var token = JsonConvert.DeserializeObject<Token>(json);
            Assert.NotNull(token);
            Assert.IsType<Token>(token);
            Assert.NotNull(token.Id);
            Assert.Equal("token", token.Object);
        }
    }
}
