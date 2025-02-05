namespace StripeTests
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class AccountLoginLinkServiceTest : BaseStripeTest
    {
        private const string AccountId = "acct_123";

        private readonly AccountLoginLinkService service;
        private readonly AccountLoginLinkCreateOptions createOptions;

        public AccountLoginLinkServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new AccountLoginLinkService(this.StripeClient);

            this.createOptions = new AccountLoginLinkCreateOptions();
        }

        [Fact]
        public void Create()
        {
            var loginLink = this.service.Create(AccountId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123/login_links");
            Assert.NotNull(loginLink);
            Assert.Equal("login_link", loginLink.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var loginLink = await this.service.CreateAsync(AccountId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123/login_links");
            Assert.NotNull(loginLink);
            Assert.Equal("login_link", loginLink.Object);
        }
    }
}
