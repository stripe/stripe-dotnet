namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class BalanceTest : BaseStripeTest
    {
        public BalanceTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/balance");
            var balance = JsonConvert.DeserializeObject<Balance>(json);
            Assert.NotNull(balance);
            Assert.IsType<Balance>(balance);
            Assert.Equal("balance", balance.Object);
        }
    }
}
