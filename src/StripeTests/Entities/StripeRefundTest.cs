namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeRefundTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/refunds/re_123");
            var refund = Mapper<StripeRefund>.MapFromJson(json);
            Assert.NotNull(refund);
            Assert.IsType<StripeRefund>(refund);
            Assert.NotNull(refund.Id);
            Assert.Equal("refund", refund.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "balance_transaction",
              "charge",
              "failure_balance_transaction",
            };

            string json = GetFixture("/v1/refunds/re_123", expansions);
            var charge = Mapper<StripeRefund>.MapFromJson(json);
            Assert.NotNull(charge);
            Assert.IsType<StripeRefund>(charge);
            Assert.NotNull(charge.Id);
            Assert.Equal("refund", charge.Object);

            Assert.NotNull(charge.BalanceTransaction);
            Assert.Equal("balance_transaction", charge.BalanceTransaction.Object);

            Assert.NotNull(charge.Charge);
            Assert.Equal("charge", charge.Charge.Object);

            Assert.NotNull(charge.FailureBalanceTransaction);
            Assert.Equal("balance_transaction", charge.FailureBalanceTransaction.Object);
        }
    }
}
