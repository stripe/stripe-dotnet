namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class ExchangeRateTest : BaseStripeTest
    {
        public ExchangeRateTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/exchange_rates/usd");
            var exchangeRate = JsonConvert.DeserializeObject<ExchangeRate>(json);
            Assert.NotNull(exchangeRate);
            Assert.IsType<ExchangeRate>(exchangeRate);
            Assert.NotNull(exchangeRate.Id);
            Assert.Equal("exchange_rate", exchangeRate.Object);
        }
    }
}
