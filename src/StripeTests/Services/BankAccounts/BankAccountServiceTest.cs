namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class BankAccountServiceTest : BaseStripeTest
    {
        private const string CustomerId = "cus_123";
        private const string BankAccountId = "ba_123";

        private BankAccountService service;
        private BankAccountCreateOptions createOptions;
        private BankAccountUpdateOptions updateOptions;
        private BankAccountListOptions listOptions;
        private BankAccountVerifyOptions verifyOptions;

        public BankAccountServiceTest()
        {
            this.service = new BankAccountService();

            this.createOptions = new BankAccountCreateOptions
            {
                SourceBankAccount = new SourceBankAccount()
                {
                    AccountNumber = "000123456789",
                    Country = "US",
                    Currency = "usd",
                    AccountHolderName = "John Doe",
                    AccountHolderType = BankAccountHolderType.Company,
                    RoutingNumber = "110000000",
                    Metadata = new Dictionary<string, string>
                    {
                        { "key", "value" },
                    },
                }
            };

            this.updateOptions = new BankAccountUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new BankAccountListOptions()
            {
                Limit = 1,
            };

            this.verifyOptions = new BankAccountVerifyOptions
            {
                AmountOne = 32,
                AmountTwo = 45,
            };
        }

        [Fact]
        public void Create()
        {
            var bankAccount = this.service.Create(CustomerId, this.createOptions);
            Assert.NotNull(bankAccount);
            Assert.Equal("bank_account", bankAccount.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var bankAccount = await this.service.CreateAsync(CustomerId, this.createOptions);
            Assert.NotNull(bankAccount);
            Assert.Equal("bank_account", bankAccount.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(CustomerId, BankAccountId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(CustomerId, BankAccountId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var bankAccount = this.service.Get(CustomerId, BankAccountId);
            Assert.NotNull(bankAccount);
            Assert.Equal("bank_account", bankAccount.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var bankAccount = await this.service.GetAsync(CustomerId, BankAccountId);
            Assert.NotNull(bankAccount);
            Assert.Equal("bank_account", bankAccount.Object);
        }

        [Fact]
        public void List()
        {
            var bankAccounts = this.service.List(CustomerId, this.listOptions);
            Assert.NotNull(bankAccounts);
            Assert.Equal("list", bankAccounts.Object);
            Assert.Single(bankAccounts.Data);
            Assert.Equal("bank_account", bankAccounts.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var bankAccounts = await this.service.ListAsync(CustomerId, this.listOptions);
            Assert.NotNull(bankAccounts);
            Assert.Equal("list", bankAccounts.Object);
            Assert.Single(bankAccounts.Data);
            Assert.Equal("bank_account", bankAccounts.Data[0].Object);
        }

        // stripe-mock does not return a bank account object on update today so we do not test
        // the returned value's object
        [Fact]
        public void Update()
        {
            var bankAccount = this.service.Update(CustomerId, BankAccountId, this.updateOptions);
            Assert.NotNull(bankAccount);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var bankAccount = await this.service.UpdateAsync(CustomerId, BankAccountId, this.updateOptions);
            Assert.NotNull(bankAccount);
        }

        [Fact]
        public void Verify()
        {
            var bankAccount = this.service.Verify(CustomerId, BankAccountId, this.verifyOptions);
            Assert.NotNull(bankAccount);
        }

        [Fact]
        public async Task VerifyAsync()
        {
            var bankAccount = await this.service.VerifyAsync(CustomerId, BankAccountId, this.verifyOptions);
            Assert.NotNull(bankAccount);
        }
    }
}
