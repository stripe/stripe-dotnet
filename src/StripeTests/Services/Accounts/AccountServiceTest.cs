namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class AccountServiceTest : BaseStripeTest
    {
        private const string AccountId = "acct_123";

        private readonly AccountService service;
        private readonly AccountCreateOptions createOptions;
        private readonly AccountUpdateOptions updateOptions;
        private readonly AccountListOptions listOptions;
        private readonly AccountRejectOptions rejectOptions;

        public AccountServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new AccountService();

            this.createOptions = new AccountCreateOptions
            {
                Type = AccountType.Custom,
                ExternalAccountId = "tok_visa_debit",
                LegalEntity = new AccountLegalEntityOptions
                {
                    AdditionalOwners = new List<AccountAdditionalOwner>
                    {
                        new AccountAdditionalOwner
                        {
                            // Verified this is encoded properly but stripe-mock does not
                            // support dob at the moment for additional owners.
                            // Dob = new AccountDobOptions
                            // {
                            //     Day = 1,
                            //     Month = 1,
                            //     Year = 1980,
                            // },
                            FirstName = "John",
                            LastName = "Doe",
                            Verification = new AccountVerificationOptions
                            {
                                DocumentBackId = "file_123",
                                DocumentId = "file_234",
                            },
                        },
                        new AccountAdditionalOwner
                        {
                            Address = new AddressOptions
                            {
                                State = "CA",
                                City = "City",
                                Line1 = "Line1",
                                Line2 = "Line2",
                                PostalCode = "90210",
                                Country = "US",
                            },
                            FirstName = "Jenny",
                            LastName = "Rosen",
                        }
                    },
                    Verification = new AccountVerificationOptions
                    {
                        DocumentBackId = "file_abc",
                        DocumentId = "file_bcd",
                    },
                }
            };

            this.updateOptions = new AccountUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.rejectOptions = new AccountRejectOptions
            {
                Reason = "terms_of_service"
            };

            this.listOptions = new AccountListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var account = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts");
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var account = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts");
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(AccountId);
            this.AssertRequest(HttpMethod.Delete, "/v1/accounts/acct_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(AccountId);
            this.AssertRequest(HttpMethod.Delete, "/v1/accounts/acct_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var account = this.service.Get(AccountId);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts/acct_123");
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var account = await this.service.GetAsync(AccountId);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts/acct_123");
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public void GetSelf()
        {
            var account = this.service.GetSelf();
            this.AssertRequest(HttpMethod.Get, "/v1/account");
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public async Task GetSelfAsync()
        {
            var account = await this.service.GetSelfAsync();
            this.AssertRequest(HttpMethod.Get, "/v1/account");
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public void List()
        {
            var accounts = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts");
            Assert.NotNull(accounts);
            Assert.Equal("list", accounts.Object);
            Assert.Single(accounts.Data);
            Assert.Equal("account", accounts.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var accounts = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts");
            Assert.NotNull(accounts);
            Assert.Equal("list", accounts.Object);
            Assert.Single(accounts.Data);
            Assert.Equal("account", accounts.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var accounts = this.service.ListAutoPaging(this.listOptions).ToList();
            Assert.NotNull(accounts);
            Assert.Equal("account", accounts[0].Object);
        }

        [Fact]
        public void Reject()
        {
            var account = this.service.Reject(AccountId, this.rejectOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123/reject");
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public async Task RejectAsync()
        {
            var account = await this.service.RejectAsync(AccountId, this.rejectOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123/reject");
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public void Update()
        {
            var account = this.service.Update(AccountId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123");
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var account = await this.service.UpdateAsync(AccountId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123");
            Assert.NotNull(account);
            Assert.Equal("account", account.Object);
        }
    }
}
