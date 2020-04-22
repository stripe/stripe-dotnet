namespace StripeTests.BillingPortal
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Stripe.BillingPortal;
    using Xunit;

    public class SessionServiceTest : BaseStripeTest
    {
        private const string SessionId = "pts_123";
        private readonly SessionService service;
        private readonly SessionCreateOptions createOptions;

        public SessionServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new SessionService(this.StripeClient);

            this.createOptions = new SessionCreateOptions
            {
                Customer = "cus_123",
                ReturnUrl = "https://stripe.com/return",
            };
        }

        [Fact]
        public void Create()
        {
            var session = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/billing_portal/sessions");
            Assert.NotNull(session);
            Assert.Equal("billing_portal.session", session.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var session = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/billing_portal/sessions");
            Assert.NotNull(session);
            Assert.Equal("billing_portal.session", session.Object);
        }
    }
}
