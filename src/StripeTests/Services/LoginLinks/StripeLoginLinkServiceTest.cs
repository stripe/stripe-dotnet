namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class StripeLoginLinkServiceTest : BaseStripeTest
    {
        private const string AccountId = "acct_123";

        private StripeLoginLinkService service;
        private StripeLoginLinkCreateOptions createOptions;

        public StripeLoginLinkServiceTest()
        {
            this.service = new StripeLoginLinkService();

            this.createOptions = new StripeLoginLinkCreateOptions()
            {
                RedirectUrl = "https://stripe.com/redirect?param=value"
            };
        }

        [Fact]
        public void Create()
        {
            var loginLink = this.service.Create(AccountId, this.createOptions);
            Assert.NotNull(loginLink);
            Assert.Equal("login_link", loginLink.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var loginLink = await this.service.CreateAsync(AccountId, this.createOptions);
            Assert.NotNull(loginLink);
            Assert.Equal("login_link", loginLink.Object);
        }
    }
}
