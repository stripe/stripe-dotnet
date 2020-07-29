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

        public AccountLinkServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new AccountLinkService(this.StripeClient);

            this.createOptions = new AccountLinkCreateOptions
            {
                Account = "acct_123",
                Collect = "eventually_due",
                RefreshUrl = "https://stripe.com/refresh",
                ReturnUrl = "https://stripe.com/return",
                Type = "account_onboarding",
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
