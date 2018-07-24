namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeExchangeRateTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/exchange_rates/usd");
            var exchangeRate = Mapper<StripeExchangeRate>.MapFromJson(json);
            Assert.NotNull(exchangeRate);
            Assert.IsType<StripeExchangeRate>(exchangeRate);
            Assert.NotNull(exchangeRate.Id);
            Assert.Equal("exchange_rate", exchangeRate.Object);
        }
    }
}
