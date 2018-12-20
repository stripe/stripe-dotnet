namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class PayoutTest : BaseStripeTest
    {
        public PayoutTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/payouts/po_123");
            var payout = JsonConvert.DeserializeObject<Payout>(json);
            Assert.NotNull(payout);
            Assert.IsType<Payout>(payout);
            Assert.NotNull(payout.Id);
            Assert.Equal("payout", payout.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "balance_transaction",
              "destination",
              "failure_balance_transaction",
            };

            string json = this.GetFixture("/v1/payouts/po_123", expansions);
            var payout = JsonConvert.DeserializeObject<Payout>(json);
            Assert.NotNull(payout);
            Assert.IsType<Payout>(payout);
            Assert.NotNull(payout.Id);
            Assert.Equal("payout", payout.Object);

            Assert.NotNull(payout.BalanceTransaction);
            Assert.Equal("balance_transaction", payout.BalanceTransaction.Object);

            Assert.NotNull(payout.Destination);
            Assert.IsType<BankAccount>(payout.Destination);
            Assert.Equal("bank_account", payout.Destination.Object);

            Assert.NotNull(payout.FailureBalanceTransaction);
            Assert.Equal("balance_transaction", payout.FailureBalanceTransaction.Object);
        }
    }
}
