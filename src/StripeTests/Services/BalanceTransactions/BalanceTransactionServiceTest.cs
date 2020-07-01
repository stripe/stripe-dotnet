namespace StripeTests
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class BalanceTransactionServiceTest : BaseStripeTest
    {
        private const string BalanceTransactionId = "txn_123";

        private readonly BalanceTransactionService service;
        private readonly BalanceTransactionListOptions listOptions;

        public BalanceTransactionServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new BalanceTransactionService(this.StripeClient);

            this.listOptions = new BalanceTransactionListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Get()
        {
            var balanceTransaction = this.service.Get(BalanceTransactionId);
            this.AssertRequest(HttpMethod.Get, "/v1/balance_transactions/txn_123");
            Assert.NotNull(balanceTransaction);
            Assert.Equal("balance_transaction", balanceTransaction.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var balanceTransaction = await this.service.GetAsync(BalanceTransactionId);
            this.AssertRequest(HttpMethod.Get, "/v1/balance_transactions/txn_123");
            Assert.NotNull(balanceTransaction);
            Assert.Equal("balance_transaction", balanceTransaction.Object);
        }

        [Fact]
        public void List()
        {
            var balanceTransactions = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/balance_transactions");
            Assert.NotNull(balanceTransactions);
            Assert.Equal("list", balanceTransactions.Object);
            Assert.Single(balanceTransactions.Data);
            Assert.Equal("balance_transaction", balanceTransactions.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var balanceTransactions = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/balance_transactions");
            Assert.NotNull(balanceTransactions);
            Assert.Equal("list", balanceTransactions.Object);
            Assert.Single(balanceTransactions.Data);
            Assert.Equal("balance_transaction", balanceTransactions.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var balanceTransaction = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(balanceTransaction);
            Assert.Equal("balance_transaction", balanceTransaction.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var balanceTransaction = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(balanceTransaction);
            Assert.Equal("balance_transaction", balanceTransaction.Object);
        }
    }
}
