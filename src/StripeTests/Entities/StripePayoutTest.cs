namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripePayoutTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/payouts/po_123");
            var payout = Mapper<StripePayout>.MapFromJson(json);
            Assert.NotNull(payout);
            Assert.IsType<StripePayout>(payout);
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

            string json = GetFixture("/v1/payouts/po_123", expansions);
            var payout = Mapper<StripePayout>.MapFromJson(json);
            Assert.NotNull(payout);
            Assert.IsType<StripePayout>(payout);
            Assert.NotNull(payout.Id);
            Assert.Equal("payout", payout.Object);

            Assert.NotNull(payout.BalanceTransaction);
            Assert.Equal("balance_transaction", payout.BalanceTransaction.Object);

            Assert.NotNull(payout.Destination);
            Assert.Equal(ExternalAccountType.BankAccount, payout.Destination.Type);
            Assert.NotNull(payout.Destination.BankAccount);
            Assert.Equal("bank_account", payout.Destination.BankAccount.Object);

            Assert.NotNull(payout.FailureBalanceTransaction);
            Assert.Equal("balance_transaction", payout.FailureBalanceTransaction.Object);
        }
    }
}
