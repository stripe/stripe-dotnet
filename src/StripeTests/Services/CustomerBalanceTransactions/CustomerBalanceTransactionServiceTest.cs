namespace StripeTests
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class CustomerBalanceTransactionServiceTest : BaseStripeTest
    {
        private const string CustomerId = "cus_123";
        private const string CustomerBalanceTransactionId = "cbtxn_123";

        private readonly CustomerBalanceTransactionService service;
        private readonly CustomerBalanceTransactionCreateOptions createOptions;
        private readonly CustomerBalanceTransactionListOptions listOptions;
        private readonly CustomerBalanceTransactionUpdateOptions updateOptions;

        public CustomerBalanceTransactionServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new CustomerBalanceTransactionService(this.StripeClient);

            this.createOptions = new CustomerBalanceTransactionCreateOptions
            {
                Amount = 1234,
                Currency = "usd",
            };

            this.listOptions = new CustomerBalanceTransactionListOptions
            {
                Limit = 1,
            };

            this.updateOptions = new CustomerBalanceTransactionUpdateOptions
            {
                Description = "description",
            };
        }

        [Fact]
        public void Create()
        {
            var transaction = this.service.Create(CustomerId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/balance_transactions");
            Assert.NotNull(transaction);
            Assert.Equal("customer_balance_transaction", transaction.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var transaction = await this.service.CreateAsync(CustomerId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/balance_transactions");
            Assert.NotNull(transaction);
            Assert.Equal("customer_balance_transaction", transaction.Object);
        }

        [Fact]
        public void Get()
        {
            var transaction = this.service.Get(CustomerId, CustomerBalanceTransactionId);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/balance_transactions/cbtxn_123");
            Assert.NotNull(transaction);
            Assert.Equal("customer_balance_transaction", transaction.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var transaction = await this.service.GetAsync(CustomerId, CustomerBalanceTransactionId);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/balance_transactions/cbtxn_123");
            Assert.NotNull(transaction);
            Assert.Equal("customer_balance_transaction", transaction.Object);
        }

        [Fact]
        public void List()
        {
            var transactions = this.service.List(CustomerId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/balance_transactions");
            Assert.NotNull(transactions);
            Assert.Equal("list", transactions.Object);
            Assert.Single(transactions.Data);
            Assert.Equal("customer_balance_transaction", transactions.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var transactions = await this.service.ListAsync(CustomerId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/balance_transactions");
            Assert.NotNull(transactions);
            Assert.Equal("list", transactions.Object);
            Assert.Single(transactions.Data);
            Assert.Equal("customer_balance_transaction", transactions.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var transaction = this.service.ListAutoPaging(CustomerId, this.listOptions).First();
            Assert.NotNull(transaction);
            Assert.Equal("customer_balance_transaction", transaction.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var transaction = await this.service.ListAutoPagingAsync(CustomerId, this.listOptions).FirstAsync();
            Assert.NotNull(transaction);
            Assert.Equal("customer_balance_transaction", transaction.Object);
        }

        [Fact]
        public void Update()
        {
            var customer = this.service.Update(CustomerId, CustomerBalanceTransactionId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/balance_transactions/cbtxn_123");
            Assert.NotNull(customer);
            Assert.Equal("customer_balance_transaction", customer.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var customer = await this.service.UpdateAsync(CustomerId, CustomerBalanceTransactionId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/balance_transactions/cbtxn_123");
            Assert.NotNull(customer);
            Assert.Equal("customer_balance_transaction", customer.Object);
        }
    }
}
