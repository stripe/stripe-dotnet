namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeBalanceTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/balance");
            var balance = Mapper<StripeBalance>.MapFromJson(json);
            Assert.NotNull(balance);
            Assert.IsType<StripeBalance>(balance);
            Assert.Equal("balance", balance.Object);
        }
    }
}
