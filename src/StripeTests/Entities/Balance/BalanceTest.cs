namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class BalanceTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/balance");
            var balance = Mapper<Balance>.MapFromJson(json);
            Assert.NotNull(balance);
            Assert.IsType<Balance>(balance);
            Assert.Equal("balance", balance.Object);
        }
    }
}
