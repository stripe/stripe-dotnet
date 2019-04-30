namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class ExternalAccountServiceTest : BaseStripeTest
    {
        private const string AccountId = "acct_123";
        private const string ExternalAccountId = "ba_123";

        private readonly ExternalAccountService service;
        private readonly ExternalAccountCreateOptions createOptions;
        private readonly ExternalAccountUpdateOptions updateOptions;
        private readonly ExternalAccountListOptions listOptions;

        public ExternalAccountServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new ExternalAccountService();

            this.createOptions = new ExternalAccountCreateOptions
            {
                ExternalAccount = "btok_123",
            };

            this.updateOptions = new ExternalAccountUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new ExternalAccountListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var externalAccount = this.service.Create(AccountId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123/external_accounts");
            Assert.NotNull(externalAccount);
            Assert.IsType<BankAccount>(externalAccount);
            Assert.Equal("bank_account", externalAccount.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var externalAccount = await this.service.CreateAsync(AccountId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123/external_accounts");
            Assert.NotNull(externalAccount);
            Assert.IsType<BankAccount>(externalAccount);
            Assert.Equal("bank_account", externalAccount.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(AccountId, ExternalAccountId);
            this.AssertRequest(HttpMethod.Delete, "/v1/accounts/acct_123/external_accounts/ba_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(AccountId, ExternalAccountId);
            this.AssertRequest(HttpMethod.Delete, "/v1/accounts/acct_123/external_accounts/ba_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var externalAccount = this.service.Get(AccountId, ExternalAccountId);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts/acct_123/external_accounts/ba_123");
            Assert.NotNull(externalAccount);
            Assert.IsType<BankAccount>(externalAccount);
            Assert.Equal("bank_account", externalAccount.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var externalAccount = await this.service.GetAsync(AccountId, ExternalAccountId);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts/acct_123/external_accounts/ba_123");
            Assert.NotNull(externalAccount);
            Assert.IsType<BankAccount>(externalAccount);
            Assert.Equal("bank_account", externalAccount.Object);
        }

        // stripe-mock does not return a bank account object on list today so we do not test
        // the returned value's object
        [Fact]
        public void List()
        {
            var externalAccounts = this.service.List(AccountId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts/acct_123/external_accounts");
            Assert.NotNull(externalAccounts);
            Assert.Equal("list", externalAccounts.Object);
            Assert.Single(externalAccounts.Data);
        }

        [Fact]
        public async Task ListAsync()
        {
            var externalAccounts = await this.service.ListAsync(AccountId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts/acct_123/external_accounts");
            Assert.NotNull(externalAccounts);
            Assert.Equal("list", externalAccounts.Object);
            Assert.Single(externalAccounts.Data);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var externalAccounts = this.service.ListAutoPaging(AccountId, this.listOptions).ToList();
            Assert.NotNull(externalAccounts);
        }

        [Fact]
        public void Update()
        {
            var externalAccount = this.service.Update(AccountId, ExternalAccountId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123/external_accounts/ba_123");
            Assert.NotNull(externalAccount);
            Assert.IsType<BankAccount>(externalAccount);
            Assert.Equal("bank_account", externalAccount.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var externalAccount = await this.service.UpdateAsync(AccountId, ExternalAccountId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123/external_accounts/ba_123");
            Assert.NotNull(externalAccount);
            Assert.IsType<BankAccount>(externalAccount);
            Assert.Equal("bank_account", externalAccount.Object);
        }
    }
}
