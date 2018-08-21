namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class TransferTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/transfers/tr_123");
            var transfer = Mapper<Transfer>.MapFromJson(json);
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

            string json = GetFixture("/v1/transfers/tr_123", expansions);
            var transfer = Mapper<Transfer>.MapFromJson(json);
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
