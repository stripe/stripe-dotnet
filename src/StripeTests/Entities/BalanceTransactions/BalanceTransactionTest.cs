namespace StripeTests
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class BalanceTransactionTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/balance/history/txn_123");
            var balanceTransaction = Mapper<BalanceTransaction>.MapFromJson(json);
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
            var balanceTransactions = Mapper<StripeList<BalanceTransaction>>.MapFromJson(json);

            Assert.NotNull(balanceTransactions);
            Assert.NotNull(balanceTransactions.Data);
            Assert.Equal(11, balanceTransactions.Data.Count);

            Assert.NotNull(balanceTransactions.Data[0]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[0].Object);
            Assert.NotNull(balanceTransactions.Data[0].Source);
            Assert.Equal(BalanceTransactionSourceType.ApplicationFee, balanceTransactions.Data[0].Source.Type);
            Assert.NotNull(balanceTransactions.Data[0].Source.ApplicationFee);
            Assert.Equal("application_fee", balanceTransactions.Data[0].Source.ApplicationFee.Object);

            Assert.NotNull(balanceTransactions.Data[1]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[1].Object);
            Assert.NotNull(balanceTransactions.Data[1].Source);
            Assert.Equal(BalanceTransactionSourceType.Charge, balanceTransactions.Data[1].Source.Type);
            Assert.NotNull(balanceTransactions.Data[1].Source.Charge);
            Assert.Equal("charge", balanceTransactions.Data[1].Source.Charge.Object);

            Assert.NotNull(balanceTransactions.Data[2]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[2].Object);
            Assert.NotNull(balanceTransactions.Data[2].Source);
            Assert.Equal(BalanceTransactionSourceType.Dispute, balanceTransactions.Data[2].Source.Type);
            Assert.NotNull(balanceTransactions.Data[2].Source.Dispute);
            Assert.Equal("dispute", balanceTransactions.Data[2].Source.Dispute.Object);

            Assert.NotNull(balanceTransactions.Data[3]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[3].Object);
            Assert.NotNull(balanceTransactions.Data[3].Source);
            Assert.Equal(BalanceTransactionSourceType.Payout, balanceTransactions.Data[3].Source.Type);
            Assert.NotNull(balanceTransactions.Data[3].Source.Payout);
            Assert.Equal("payout", balanceTransactions.Data[3].Source.Payout.Object);

            Assert.NotNull(balanceTransactions.Data[4]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[4].Object);
            Assert.NotNull(balanceTransactions.Data[4].Source);
            Assert.Equal(BalanceTransactionSourceType.Refund, balanceTransactions.Data[4].Source.Type);
            Assert.NotNull(balanceTransactions.Data[4].Source.Refund);
            Assert.Equal("refund", balanceTransactions.Data[4].Source.Refund.Object);

            Assert.NotNull(balanceTransactions.Data[5]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[5].Object);
            Assert.NotNull(balanceTransactions.Data[5].Source);
            Assert.Equal(BalanceTransactionSourceType.Transfer, balanceTransactions.Data[5].Source.Type);
            Assert.NotNull(balanceTransactions.Data[5].Source.Transfer);
            Assert.Equal("transfer", balanceTransactions.Data[5].Source.Transfer.Object);

            Assert.NotNull(balanceTransactions.Data[6]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[6].Object);
            Assert.NotNull(balanceTransactions.Data[6].Source);
            Assert.Equal(BalanceTransactionSourceType.TransferReversal, balanceTransactions.Data[6].Source.Type);
            Assert.NotNull(balanceTransactions.Data[6].Source.TransferReversal);
            Assert.Equal("transfer_reversal", balanceTransactions.Data[6].Source.TransferReversal.Object);

            Assert.NotNull(balanceTransactions.Data[7]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[7].Object);
            Assert.NotNull(balanceTransactions.Data[7].Source);
            Assert.Equal(BalanceTransactionSourceType.Topup, balanceTransactions.Data[7].Source.Type);
            Assert.NotNull(balanceTransactions.Data[7].Source.Topup);
            Assert.Equal("topup", balanceTransactions.Data[7].Source.Topup.Object);

            Assert.NotNull(balanceTransactions.Data[8]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[8].Object);
            Assert.NotNull(balanceTransactions.Data[8].Source);
            Assert.Equal(BalanceTransactionSourceType.IssuingAuthorization, balanceTransactions.Data[8].Source.Type);
            Assert.NotNull(balanceTransactions.Data[8].Source.IssuingAuthorization);
            Assert.Equal("issuing.authorization", balanceTransactions.Data[8].Source.IssuingAuthorization.Object);

            Assert.NotNull(balanceTransactions.Data[9]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[9].Object);
            Assert.NotNull(balanceTransactions.Data[9].Source);
            Assert.Equal(BalanceTransactionSourceType.IssuingTransaction, balanceTransactions.Data[9].Source.Type);
            Assert.NotNull(balanceTransactions.Data[9].Source.IssuingTransaction);
            Assert.Equal("issuing.transaction", balanceTransactions.Data[9].Source.IssuingTransaction.Object);

            Assert.NotNull(balanceTransactions.Data[10]);
            Assert.Equal("balance_transaction", balanceTransactions.Data[10].Object);
            Assert.NotNull(balanceTransactions.Data[10].Source);
            Assert.Equal(BalanceTransactionSourceType.Unknown, balanceTransactions.Data[10].Source.Type);
        }
    }
}
