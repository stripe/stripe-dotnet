namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeTopupTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/topups/tu_123");
            var topup = Mapper<StripeTopup>.MapFromJson(json);
            Assert.NotNull(topup);
            Assert.IsType<StripeTopup>(topup);
            Assert.NotNull(topup.Id);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "balance_transaction",
              "source",
            };

            string json = GetFixture("/v1/topups/tu_123", expansions);
            var topup = Mapper<StripeTopup>.MapFromJson(json);
            Assert.NotNull(topup);
            Assert.IsType<StripeTopup>(topup);
            Assert.NotNull(topup.Id);
            Assert.Equal("topup", topup.Object);

            Assert.NotNull(topup.BalanceTransaction);
            Assert.Equal("balance_transaction", topup.BalanceTransaction.Object);

            Assert.NotNull(topup.Source);
            Assert.Equal("ach_debit", topup.Source.Type);
            Assert.Equal("source", topup.Source.Object);
        }
    }
}
