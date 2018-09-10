namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class StripeAccountServiceTest : BaseStripeTest
    {
        private const string AccountId = "acct_123";

        private StripeAccountService service;
        private StripeAccountCreateOptions createOptions;
        private StripeAccountUpdateOptions updateOptions;
        private StripeAccountListOptions listOptions;
        private StripeAccountRejectOptions rejectOptions;

        public StripeAccountServiceTest()
        {
            this.service = new StripeAccountService();

            this.createOptions = new StripeAccountCreateOptions
            {
                Type = StripeAccountType.Custom,
                ExternalAccountId = "tok_visa_debit",
                LegalEntity = new StripeAccountLegalEntityOptions
                {
                    AdditionalOwners = new List<StripeAccountAdditionalOwner>
                    {
                        new StripeAccountAdditionalOwner
                        {
                            FirstName = "John",
                            LastName = "Doe",

                            // Commenting these temporarily until stripe-mock is fixed
                            // BirthDay = 1,
                            // BirthMonth = 1,
                            // BirthYear = 1980,
                            VerificationDocument = "file_123",
                            VerificationDocumentBack = "file_234",
                        },
                        new StripeAccountAdditionalOwner
                        {
                            FirstName = "Jenny",
                            LastName = "Rosen",
                            State = "CA",
                            CityOrTown = "City",
                            Line1 = "Line1",
                            Line2 = "Line2",
                            PostalCode = "90210",
                            Country = "US",
                        }
                    },
                    VerificationDocumentFileId = "file_abc",
                    VerificationDocumentFileBackId = "file_bcd",
                }
            };

            this.updateOptions = new StripeAccountUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.rejectOptions = new StripeAccountRejectOptions
            {
                Reason = "terms_of_service"
            };

            this.listOptions = new StripeAccountListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var account = this.service.Create(this.createOptions);
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var account = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(AccountId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(AccountId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var account = this.service.Get(AccountId);
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var account = await this.service.GetAsync(AccountId);
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public void GetWithNoId()
        {
            var account = this.service.Get();
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public void List()
        {
            var accounts = this.service.List(this.listOptions);
            Assert.NotNull(accounts);
            Assert.Equal("list", accounts.Object);
            Assert.Single(accounts.Data);
            Assert.Equal("account", accounts.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var accounts = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(accounts);
            Assert.Equal("list", accounts.Object);
            Assert.Single(accounts.Data);
            Assert.Equal("account", accounts.Data[0].Object);
        }

        [Fact]
        public void Reject()
        {
            var account = this.service.Reject(AccountId, this.rejectOptions);
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public async Task RejectAsync()
        {
            var account = await this.service.RejectAsync(AccountId, this.rejectOptions);
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public void Update()
        {
            var account = this.service.Update(AccountId, this.updateOptions);
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var account = await this.service.UpdateAsync(AccountId, this.updateOptions);
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }
    }
}
