namespace StripeTests
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class AccountLinkServiceTest : BaseStripeTest
    {
        private readonly AccountLinkService service;
        private readonly AccountLinkCreateOptions createOptions;

        public AccountLinkServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new AccountLinkService();

            this.createOptions = new AccountLinkCreateOptions
            {
                AccountId = "acct_123",
                Collect = "eventually_due",
                FailureUrl = "https://stripe.com/failure",
                SuccessUrl = "https://stripe.com/success",
                Type = "custom_account_verification",
            };
        }

        [Fact]
        public void Create()
        {
            var accountLink = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/account_links");
            Assert.NotNull(accountLink);
            Assert.Equal("account_link", accountLink.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var accountLink = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/account_links");
            Assert.NotNull(accountLink);
            Assert.Equal("account_link", accountLink.Object);
        }
    }
}
