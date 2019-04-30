namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class BankAccountServiceTest : BaseStripeTest
    {
        private const string CustomerId = "cus_123";
        private const string BankAccountId = "ba_123";

        private readonly BankAccountService service;
        private readonly BankAccountCreateOptions createOptions;
        private readonly BankAccountUpdateOptions updateOptions;
        private readonly BankAccountListOptions listOptions;
        private readonly BankAccountVerifyOptions verifyOptions;

        public BankAccountServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new BankAccountService();

            this.createOptions = new BankAccountCreateOptions
            {
                Source = "btok_123",
            };

            this.updateOptions = new BankAccountUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new BankAccountListOptions
            {
                Limit = 1,
            };

            this.verifyOptions = new BankAccountVerifyOptions
            {
                Amounts = new List<long>
                {
                    32,
                    45,
                }
            };
        }

        [Fact]
        public void Create()
        {
            var bankAccount = this.service.Create(CustomerId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/sources");
            Assert.NotNull(bankAccount);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var bankAccount = await this.service.CreateAsync(CustomerId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/sources");
            Assert.NotNull(bankAccount);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(CustomerId, BankAccountId);
            this.AssertRequest(HttpMethod.Delete, "/v1/customers/cus_123/sources/ba_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(CustomerId, BankAccountId);
            this.AssertRequest(HttpMethod.Delete, "/v1/customers/cus_123/sources/ba_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var bankAccount = this.service.Get(CustomerId, BankAccountId);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/sources/ba_123");
            Assert.NotNull(bankAccount);
        }

        [Fact]
        public async Task GetAsync()
        {
            var bankAccount = await this.service.GetAsync(CustomerId, BankAccountId);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/sources/ba_123");
            Assert.NotNull(bankAccount);
        }

        [Fact]
        public void List()
        {
            var bankAccounts = this.service.List(CustomerId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/sources");
            Assert.NotNull(bankAccounts);
            Assert.Equal("list", bankAccounts.Object);
            Assert.Single(bankAccounts.Data);
        }

        [Fact]
        public async Task ListAsync()
        {
            var bankAccounts = await this.service.ListAsync(CustomerId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/customers/cus_123/sources");
            Assert.NotNull(bankAccounts);
            Assert.Equal("list", bankAccounts.Object);
            Assert.Single(bankAccounts.Data);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var bankAccounts = this.service.ListAutoPaging(CustomerId, this.listOptions).ToList();
            Assert.NotNull(bankAccounts);
        }

        // stripe-mock does not return a bank account object on update today so we do not test
        // the returned value's object
        [Fact]
        public void Update()
        {
            var bankAccount = this.service.Update(CustomerId, BankAccountId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/sources/ba_123");
            Assert.NotNull(bankAccount);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var bankAccount = await this.service.UpdateAsync(CustomerId, BankAccountId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/sources/ba_123");
            Assert.NotNull(bankAccount);
        }

        [Fact]
        public void Verify()
        {
            var bankAccount = this.service.Verify(CustomerId, BankAccountId, this.verifyOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/sources/ba_123/verify");
            Assert.NotNull(bankAccount);
        }

        [Fact]
        public async Task VerifyAsync()
        {
            var bankAccount = await this.service.VerifyAsync(CustomerId, BankAccountId, this.verifyOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/customers/cus_123/sources/ba_123/verify");
            Assert.NotNull(bankAccount);
        }
    }
}
