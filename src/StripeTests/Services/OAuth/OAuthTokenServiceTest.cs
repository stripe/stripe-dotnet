namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class OAuthTokenServiceTest : BaseStripeTest
    {
        private const string AccountId = "acct_123";
        private const string AuthorizationCode = "ac_123";
        private const string ClientId = "ca_123";

        private readonly OAuthTokenService service;
        private readonly OAuthTokenCreateOptions createOptions;
        private readonly OAuthTokenDeauthorizeOptions deauthorizeOptions;

        public OAuthTokenServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new OAuthTokenService();

            this.createOptions = new OAuthTokenCreateOptions
            {
                Code = AuthorizationCode,
                GrantType = "authorization_code",
            };

            this.deauthorizeOptions = new OAuthTokenDeauthorizeOptions
            {
                ClientId = ClientId,
                StripeUserId = AccountId,
            };
        }

        [Fact]
        public void Create()
        {
            // stripe-mock doesn't support OAuth endpoints, so stub the request
            var json = GetResourceAsString("oauth_fixtures.token_response.json");
            this.StubRequest(HttpMethod.Post, "/oauth/token", HttpStatusCode.OK, json);

            var oauthToken = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/oauth/token");
            Assert.NotNull(oauthToken);
            Assert.Equal("sk_test_access_token", oauthToken.AccessToken);
        }

        [Fact]
        public async Task CreateAsync()
        {
            // stripe-mock doesn't support OAuth endpoints, so stub the request
            var json = GetResourceAsString("oauth_fixtures.token_response.json");
            this.StubRequest(HttpMethod.Post, "/oauth/token", HttpStatusCode.OK, json);

            var oauthToken = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/oauth/token");
            Assert.NotNull(oauthToken);
            Assert.Equal("sk_test_access_token", oauthToken.AccessToken);
        }

        [Fact]
        public void Deauthorize()
        {
            // stripe-mock doesn't support OAuth endpoints, so stub the request
            var json = $"{{\"stripe_user_id\": \"{AccountId}\"}}";
            this.StubRequest(HttpMethod.Post, "/oauth/deauthorize", HttpStatusCode.OK, json);

            var deauth = this.service.Deauthorize(this.deauthorizeOptions);
            this.AssertRequest(HttpMethod.Post, "/oauth/deauthorize");
            Assert.NotNull(deauth);
            Assert.Equal(AccountId, deauth.StripeUserId);
        }

        [Fact]
        public async Task DeauthorizeAsync()
        {
            // stripe-mock doesn't support OAuth endpoints, so stub the request
            var json = $"{{\"stripe_user_id\": \"{AccountId}\"}}";
            this.StubRequest(HttpMethod.Post, "/oauth/deauthorize", HttpStatusCode.OK, json);

            var deauth = await this.service.DeauthorizeAsync(this.deauthorizeOptions);
            this.AssertRequest(HttpMethod.Post, "/oauth/deauthorize");
            Assert.NotNull(deauth);
            Assert.Equal(AccountId, deauth.StripeUserId);
        }
    }
}
