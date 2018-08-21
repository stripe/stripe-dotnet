namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class ExternalAccountServiceTest : BaseStripeTest
    {
        private const string AccountId = "acct_123";
        private const string ExternalAccountId = "ba_123";

        private ExternalAccountService service;
        private ExternalAccountCreateOptions createOptions;
        private ExternalAccountUpdateOptions updateOptions;
        private ExternalAccountListOptions listOptions;

        public ExternalAccountServiceTest()
        {
            this.service = new ExternalAccountService();

            this.createOptions = new ExternalAccountCreateOptions
            {
                ExternalAccountBankAccount = new StripeAccountBankAccountOptions
                {
                    AccountNumber = "000123456789",
                    Country = "US",
                    Currency = "usd",
                    RoutingNumber = "110000000",
                }
            };

            this.updateOptions = new ExternalAccountUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new ExternalAccountListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var externalAccount = this.service.Create(AccountId, this.createOptions);
            Assert.NotNull(externalAccount);
            Assert.Equal(ExternalAccountType.BankAccount, externalAccount.Type);
            Assert.NotNull(externalAccount.BankAccount);
            Assert.Equal("bank_account", externalAccount.BankAccount.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var externalAccount = await this.service.CreateAsync(AccountId, this.createOptions);
            Assert.NotNull(externalAccount);
            Assert.Equal(ExternalAccountType.BankAccount, externalAccount.Type);
            Assert.NotNull(externalAccount.BankAccount);
            Assert.Equal("bank_account", externalAccount.BankAccount.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(AccountId, ExternalAccountId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(AccountId, ExternalAccountId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var externalAccount = this.service.Get(AccountId, ExternalAccountId);
            Assert.NotNull(externalAccount);
            Assert.Equal(ExternalAccountType.BankAccount, externalAccount.Type);
            Assert.NotNull(externalAccount.BankAccount);
            Assert.Equal("bank_account", externalAccount.BankAccount.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var externalAccount = await this.service.GetAsync(AccountId, ExternalAccountId);
            Assert.NotNull(externalAccount);
            Assert.Equal(ExternalAccountType.BankAccount, externalAccount.Type);
            Assert.NotNull(externalAccount.BankAccount);
            Assert.Equal("bank_account", externalAccount.BankAccount.Object);
        }

        // stripe-mock does not return a bank account object on list today so we do not test
        // the returned value's object
        [Fact]
        public void List()
        {
            var externalAccounts = this.service.List(AccountId, this.listOptions);
            Assert.NotNull(externalAccounts);
            Assert.Equal("list", externalAccounts.Object);
            Assert.Single(externalAccounts.Data);
        }

        [Fact]
        public async Task ListAsync()
        {
            var externalAccounts = await this.service.ListAsync(AccountId, this.listOptions);
            Assert.NotNull(externalAccounts);
            Assert.Equal("list", externalAccounts.Object);
            Assert.Single(externalAccounts.Data);
        }

        [Fact]
        public void Update()
        {
            var externalAccount = this.service.Update(AccountId, ExternalAccountId, this.updateOptions);
            Assert.NotNull(externalAccount);
            Assert.Equal(ExternalAccountType.BankAccount, externalAccount.Type);
            Assert.NotNull(externalAccount.BankAccount);
            Assert.Equal("bank_account", externalAccount.BankAccount.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var externalAccount = await this.service.UpdateAsync(AccountId, ExternalAccountId, this.updateOptions);
            Assert.NotNull(externalAccount);
            Assert.Equal(ExternalAccountType.BankAccount, externalAccount.Type);
            Assert.NotNull(externalAccount.BankAccount);
            Assert.Equal("bank_account", externalAccount.BankAccount.Object);
        }
    }
}
