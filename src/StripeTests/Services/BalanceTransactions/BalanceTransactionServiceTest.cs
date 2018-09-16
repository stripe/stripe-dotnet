namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class BalanceTransactionServiceTest : BaseStripeTest
    {
        private const string BalanceTransactionId = "txn_123";

        private BalanceTransactionService service;
        private BalanceTransactionListOptions listOptions;

        public BalanceTransactionServiceTest()
        {
            this.service = new BalanceTransactionService();

            this.listOptions = new BalanceTransactionListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Get()
        {
            var balanceTransaction = this.service.Get(BalanceTransactionId);
            Assert.NotNull(balanceTransaction);
            Assert.Equal("balance_transaction", balanceTransaction.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var balanceTransaction = await this.service.GetAsync(BalanceTransactionId);
            Assert.NotNull(balanceTransaction);
            Assert.Equal("balance_transaction", balanceTransaction.Object);
        }

        [Fact]
        public void List()
        {
            var balanceTransactions = this.service.List(this.listOptions);
            Assert.NotNull(balanceTransactions);
            Assert.Equal("list", balanceTransactions.Object);
            Assert.Single(balanceTransactions.Data);
            Assert.Equal("balance_transaction", balanceTransactions.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var balanceTransactions = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(balanceTransactions);
            Assert.Equal("list", balanceTransactions.Object);
            Assert.Single(balanceTransactions.Data);
            Assert.Equal("balance_transaction", balanceTransactions.Data[0].Object);
        }
    }
}
