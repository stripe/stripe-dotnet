namespace StripeTests
{
    using System;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class ChargeTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/charges/ch_123");
            var charge = Mapper<Charge>.MapFromJson(json);
            Assert.NotNull(charge);
            Assert.IsType<Charge>(charge);
            Assert.NotNull(charge.Id);
            Assert.Equal("charge", charge.Object);
            Assert.NotNull(charge.Source);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "application",
              "application_fee",
              "balance_transaction",
              "customer",
              "destination",
              "dispute",
              "invoice",
              "on_behalf_of",
              "order",
              "review",
              "source_transfer",
              "transfer",
            };

            string json = GetFixture("/v1/charges/ch_123", expansions);
            var charge = Mapper<Charge>.MapFromJson(json);
            Assert.NotNull(charge);
            Assert.IsType<Charge>(charge);
            Assert.NotNull(charge.Id);
            Assert.Equal("charge", charge.Object);

            Assert.NotNull(charge.Application);
            Assert.Equal("application", charge.Application.Object);

            Assert.NotNull(charge.ApplicationFee);
            Assert.Equal("application_fee", charge.ApplicationFee.Object);

            Assert.NotNull(charge.BalanceTransaction);
            Assert.Equal("balance_transaction", charge.BalanceTransaction.Object);

            Assert.NotNull(charge.Customer);
            Assert.Equal("customer", charge.Customer.Object);

            Assert.NotNull(charge.Destination);
            Assert.Equal("account", charge.Destination.Object);

            Assert.NotNull(charge.Dispute);
            Assert.Equal("dispute", charge.Dispute.Object);

            Assert.NotNull(charge.Invoice);
            Assert.Equal("invoice", charge.Invoice.Object);

            Assert.NotNull(charge.OnBehalfOf);
            Assert.Equal("account", charge.OnBehalfOf.Object);

            Assert.NotNull(charge.Order);
            Assert.Equal("order", charge.Order.Object);

            Assert.NotNull(charge.Review);
            Assert.Equal("review", charge.Review.Object);

            Assert.NotNull(charge.SourceTransfer);
            Assert.Equal("transfer", charge.SourceTransfer.Object);

            Assert.NotNull(charge.Transfer);
            Assert.Equal("transfer", charge.Transfer.Object);
        }

        [Fact]
        public void DeserializeWithJsonConvert()
        {
            string json = GetFixture("/v1/charges/ch_123");
            var charge = JsonConvert.DeserializeObject<Charge>(json);
            Assert.NotNull(charge);
            Assert.IsType<Charge>(charge);
            Assert.NotNull(charge.Id);
            Assert.Equal("charge", charge.Object);
            Assert.NotNull(charge.Source);
        }
    }
}
