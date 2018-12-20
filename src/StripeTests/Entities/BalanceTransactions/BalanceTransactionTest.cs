namespace StripeTests
{
    using System;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class BalanceTransactionTest : BaseStripeTest
    {
        public BalanceTransactionTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/balance/history/txn_123");
            var balanceTransaction = JsonConvert.DeserializeObject<BalanceTransaction>(json);
            Assert.NotNull(balanceTransaction);
            Assert.IsType<BalanceTransaction>(balanceTransaction);
            Assert.NotNull(balanceTransaction.Id);
            Assert.Equal("balance_transaction", balanceTransaction.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            // We test all balance transaction possible source types to ensure the deserializer
            // works as expectes.
            var json = GetResourceAsString("api_fixtures.balance_transaction_with_expansion.json");
            var balanceTransactions = JsonConvert.DeserializeObject<StripeList<BalanceTransaction>>(json);

            Assert.NotNull(balanceTransactions);
            Assert.NotNull(balanceTransactions.Data);
            Assert.Equal(11, balanceTransactions.Data.Count);

            Assert.NotNull(balanceTransactions.Data[0]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[0].Object);
            Assert.NotNull(balanceTransactions.Data[0].SourceId);
            Assert.NotNull(balanceTransactions.Data[0].Source);
            Assert.IsType<ApplicationFee>(balanceTransactions.Data[0].Source);
            Assert.Equal("application_fee", balanceTransactions.Data[0].Source.Object);
            Assert.Equal(balanceTransactions.Data[0].SourceId, balanceTransactions.Data[0].Source.Id);

            Assert.NotNull(balanceTransactions.Data[1]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[1].Object);
            Assert.NotNull(balanceTransactions.Data[1].SourceId);
            Assert.NotNull(balanceTransactions.Data[1].Source);
            Assert.IsType<Charge>(balanceTransactions.Data[1].Source);
            Assert.Equal("charge", balanceTransactions.Data[1].Source.Object);
            Assert.Equal(balanceTransactions.Data[1].SourceId, balanceTransactions.Data[1].Source.Id);

            Assert.NotNull(balanceTransactions.Data[2]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[2].Object);
            Assert.NotNull(balanceTransactions.Data[2].SourceId);
            Assert.NotNull(balanceTransactions.Data[2].Source);
            Assert.IsType<Dispute>(balanceTransactions.Data[2].Source);
            Assert.Equal("dispute", balanceTransactions.Data[2].Source.Object);
            Assert.Equal(balanceTransactions.Data[2].SourceId, balanceTransactions.Data[2].Source.Id);

            Assert.NotNull(balanceTransactions.Data[3]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[3].Object);
            Assert.NotNull(balanceTransactions.Data[3].SourceId);
            Assert.NotNull(balanceTransactions.Data[3].Source);
            Assert.IsType<Payout>(balanceTransactions.Data[3].Source);
            Assert.Equal("payout", balanceTransactions.Data[3].Source.Object);
            Assert.Equal(balanceTransactions.Data[3].SourceId, balanceTransactions.Data[3].Source.Id);

            Assert.NotNull(balanceTransactions.Data[4]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[4].Object);
            Assert.NotNull(balanceTransactions.Data[4].SourceId);
            Assert.NotNull(balanceTransactions.Data[4].Source);
            Assert.IsType<Refund>(balanceTransactions.Data[4].Source);
            Assert.Equal("refund", balanceTransactions.Data[4].Source.Object);
            Assert.Equal(balanceTransactions.Data[4].SourceId, balanceTransactions.Data[4].Source.Id);

            Assert.NotNull(balanceTransactions.Data[5]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[5].Object);
            Assert.NotNull(balanceTransactions.Data[5].SourceId);
            Assert.NotNull(balanceTransactions.Data[5].Source);
            Assert.IsType<Transfer>(balanceTransactions.Data[5].Source);
            Assert.Equal("transfer", balanceTransactions.Data[5].Source.Object);
            Assert.Equal(balanceTransactions.Data[5].SourceId, balanceTransactions.Data[5].Source.Id);

            Assert.NotNull(balanceTransactions.Data[6]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[6].Object);
            Assert.NotNull(balanceTransactions.Data[6].SourceId);
            Assert.NotNull(balanceTransactions.Data[6].Source);
            Assert.IsType<TransferReversal>(balanceTransactions.Data[6].Source);
            Assert.Equal("transfer_reversal", balanceTransactions.Data[6].Source.Object);
            Assert.Equal(balanceTransactions.Data[6].SourceId, balanceTransactions.Data[6].Source.Id);

            Assert.NotNull(balanceTransactions.Data[7]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[7].Object);
            Assert.NotNull(balanceTransactions.Data[7].SourceId);
            Assert.NotNull(balanceTransactions.Data[7].Source);
            Assert.IsType<Topup>(balanceTransactions.Data[7].Source);
            Assert.Equal("topup", balanceTransactions.Data[7].Source.Object);
            Assert.Equal(balanceTransactions.Data[7].SourceId, balanceTransactions.Data[7].Source.Id);

            Assert.NotNull(balanceTransactions.Data[8]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[8].Object);
            Assert.NotNull(balanceTransactions.Data[8].SourceId);
            Assert.NotNull(balanceTransactions.Data[8].Source);
            Assert.IsType<Stripe.Issuing.Authorization>(balanceTransactions.Data[8].Source);
            Assert.Equal("issuing.authorization", balanceTransactions.Data[8].Source.Object);
            Assert.Equal(balanceTransactions.Data[8].SourceId, balanceTransactions.Data[8].Source.Id);

            Assert.NotNull(balanceTransactions.Data[9]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[9].Object);
            Assert.NotNull(balanceTransactions.Data[9].SourceId);
            Assert.NotNull(balanceTransactions.Data[9].Source);
            Assert.IsType<Stripe.Issuing.Transaction>(balanceTransactions.Data[9].Source);
            Assert.Equal("issuing.transaction", balanceTransactions.Data[9].Source.Object);
            Assert.Equal(balanceTransactions.Data[9].SourceId, balanceTransactions.Data[9].Source.Id);

            Assert.NotNull(balanceTransactions.Data[10]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[10].Object);
            Assert.NotNull(balanceTransactions.Data[10].SourceId);
            Assert.Null(balanceTransactions.Data[10].Source);
        }
    }
}
