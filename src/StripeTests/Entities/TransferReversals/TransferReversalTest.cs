namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class TransferReversalTest : BaseStripeTest
    {
        public TransferReversalTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/transfers/tr_123/reversals/trr_123");
            var transferReversal = JsonConvert.DeserializeObject<TransferReversal>(json);
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

            string json = this.GetFixture("/v1/transfers/tr_123/reversals/trr_123", expansions);
            var transferReversal = JsonConvert.DeserializeObject<TransferReversal>(json);
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
