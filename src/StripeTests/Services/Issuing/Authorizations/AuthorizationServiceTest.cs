namespace StripeTests.Issuing
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe.Issuing;
    using Xunit;

    public class AuthorizationServiceTest : BaseStripeTest
    {
        private const string AuthorizationId = "iauth_123";

        private readonly AuthorizationService service;
        private readonly AuthorizationUpdateOptions updateOptions;
        private readonly AuthorizationListOptions listOptions;

        public AuthorizationServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new AuthorizationService(this.StripeClient);

            this.updateOptions = new AuthorizationUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new AuthorizationListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Approve()
        {
            var authorization = this.service.Approve(AuthorizationId);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/authorizations/iauth_123/approve");
            Assert.NotNull(authorization);
        }

        [Fact]
        public async Task ApproveAsync()
        {
            var authorization = await this.service.ApproveAsync(AuthorizationId);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/authorizations/iauth_123/approve");
            Assert.NotNull(authorization);
        }

        [Fact]
        public void Decline()
        {
            var authorization = this.service.Decline(AuthorizationId);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/authorizations/iauth_123/decline");
            Assert.NotNull(authorization);
        }

        [Fact]
        public async Task DeclineAsync()
        {
            var authorization = await this.service.DeclineAsync(AuthorizationId);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/authorizations/iauth_123/decline");
            Assert.NotNull(authorization);
        }

        [Fact]
        public void Get()
        {
            var authorization = this.service.Get(AuthorizationId);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/authorizations/iauth_123");
            Assert.NotNull(authorization);
        }

        [Fact]
        public async Task GetAsync()
        {
            var authorization = await this.service.GetAsync(AuthorizationId);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/authorizations/iauth_123");
            Assert.NotNull(authorization);
        }

        [Fact]
        public void List()
        {
            var authorizations = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/authorizations");
            Assert.NotNull(authorizations);
        }

        [Fact]
        public async Task ListAsync()
        {
            var authorizations = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/issuing/authorizations");
            Assert.NotNull(authorizations);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var authorization = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(authorization);
            Assert.Equal("issuing.authorization", authorization.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var authorization = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(authorization);
            Assert.Equal("issuing.authorization", authorization.Object);
        }

        [Fact]
        public void Update()
        {
            var authorization = this.service.Update(AuthorizationId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/authorizations/iauth_123");
            Assert.NotNull(authorization);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var authorization = await this.service.UpdateAsync(AuthorizationId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/issuing/authorizations/iauth_123");
            Assert.NotNull(authorization);
        }
    }
}
