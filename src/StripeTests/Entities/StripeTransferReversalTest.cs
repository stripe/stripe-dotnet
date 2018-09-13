namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class TransferReversalTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/transfers/tr_123/reversals/trr_123");
            var transferReversal = Mapper<TransferReversal>.MapFromJson(json);
            Assert.NotNull(transferReversal);
            Assert.IsType<TransferReversal>(transferReversal);
            Assert.NotNull(transferReversal.Id);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "balance_transaction",
              "transfer",
            };

            string json = GetFixture("/v1/transfers/tr_123/reversals/trr_123", expansions);
            var transferReversal = Mapper<TransferReversal>.MapFromJson(json);
            Assert.NotNull(transferReversal);
            Assert.IsType<TransferReversal>(transferReversal);
            Assert.NotNull(transferReversal.Id);
            Assert.Equal("transfer_reversal", transferReversal.Object);

            Assert.NotNull(transferReversal.BalanceTransaction);
            Assert.Equal("balance_transaction", transferReversal.BalanceTransaction.Object);

            Assert.NotNull(transferReversal.Transfer);
            Assert.Equal("transfer", transferReversal.Transfer.Object);
        }
    }
}
