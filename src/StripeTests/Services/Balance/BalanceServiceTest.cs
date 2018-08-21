namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class BalanceServiceTest : BaseStripeTest
    {
        private const string BalanceTransactionId = "txn_123";

        private BalanceService service;
        private BalanceTransactionListOptions listOptions;

        public BalanceServiceTest()
        {
            this.service = new BalanceService();

            this.listOptions = new BalanceTransactionListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Get()
        {
            var balance = this.service.Get();
            Assert.NotNull(balance);
            Assert.Equal("balance", balance.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var balance = await this.service.GetAsync();
            Assert.NotNull(balance);
            Assert.Equal("balance", balance.Object);
        }

        [Fact]
        public void BalanceTransactionGet()
        {
            var balanceTransaction = this.service.Get(BalanceTransactionId);
            Assert.NotNull(balanceTransaction);
            Assert.Equal("balance_transaction", balanceTransaction.Object);
        }

        [Fact]
        public async Task BalanceTransactionGetAsync()
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
