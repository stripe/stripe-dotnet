namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class TransferTest : BaseStripeTest
    {
        public TransferTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/transfers/tr_123");
            var transfer = JsonConvert.DeserializeObject<Transfer>(json);
            Assert.NotNull(transfer);
            Assert.IsType<Transfer>(transfer);
            Assert.NotNull(transfer.Id);
            Assert.Equal("transfer", transfer.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "balance_transaction",
              "destination",
              "destination_payment",
              "source_transaction",
            };

            string json = this.GetFixture("/v1/transfers/tr_123", expansions);
            var transfer = JsonConvert.DeserializeObject<Transfer>(json);
            Assert.NotNull(transfer);
            Assert.IsType<Transfer>(transfer);
            Assert.NotNull(transfer.Id);
            Assert.Equal("transfer", transfer.Object);

            Assert.NotNull(transfer.BalanceTransaction);
            Assert.Equal("balance_transaction", transfer.BalanceTransaction.Object);

            Assert.NotNull(transfer.Destination);
            Assert.Equal("account", transfer.Destination.Object);

            Assert.NotNull(transfer.DestinationPayment);
            Assert.Equal("charge", transfer.DestinationPayment.Object);

            Assert.NotNull(transfer.SourceTransaction);
            Assert.Equal("charge", transfer.SourceTransaction.Object);
        }
    }
}
