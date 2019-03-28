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
        private readonly OAuthDeauthorizeOptions deauthorizeOptions;

        public OAuthTokenServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new OAuthTokenService();

            this.createOptions = new OAuthTokenCreateOptions
            {
                Code = AuthorizationCode,
                GrantType = "authorization_code",
            };

            this.deauthorizeOptions = new OAuthDeauthorizeOptions
            {
                ClientId = ClientId,
                StripeUserId = AccountId,
            };
        }

        [Fact]
        public void AuthorizeUrl_Standard()
        {
            var options = new OAuthAuthorizeUrlOptions
            {
                Scope = "read_write",
                State = "csrf_token",
                StripeUser = new OAuthAuthorizeUrlStripeUserOptions
                {
                    Email = "test@example.com",
                    Url = "https://example.com/profile/test",
                    Country = "US",
                },
            };

            var uri = this.service.AuthorizeUrl(options);

            Assert.Equal("https", uri.Scheme);
            Assert.Equal("connect.stripe.com", uri.Host);
            Assert.Equal("/oauth/authorize", uri.AbsolutePath);

            var query = this.ParseQueryString(uri.Query);
            Assert.Equal("ca_123", query["client_id"]);
            Assert.Equal("code", query["response_type"]);
            Assert.Equal("read_write", query["scope"]);
            Assert.Equal("csrf_token", query["state"]);
            Assert.Equal("test@example.com", query["stripe_user[email]"]);
            Assert.Equal("https://example.com/profile/test", query["stripe_user[url]"]);
            Assert.Equal("US", query["stripe_user[country]"]);
        }

        [Fact]
        public void AuthorizeUrl_Express()
        {
            var options = new OAuthAuthorizeUrlOptions { Scope = "read_write" };

            var uri = this.service.AuthorizeUrl(options, express: true);

            Assert.Equal("https", uri.Scheme);
            Assert.Equal("connect.stripe.com", uri.Host);
            Assert.Equal("/express/oauth/authorize", uri.AbsolutePath);

            var query = this.ParseQueryString(uri.Query);
            Assert.Equal("ca_123", query["client_id"]);
            Assert.Equal("code", query["response_type"]);
            Assert.Equal("read_write", query["scope"]);
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
        public void Create_Error()
        {
            var json = "{\"error\": \"invalid_grant\", \"error_description\": \"Authorization code does not exist: ac_123\"}";
            this.StubRequest(HttpMethod.Post, "/oauth/token", HttpStatusCode.BadRequest, json);

            var exception = Assert.Throws<StripeException>(() =>
                this.service.Create(this.createOptions));
            Assert.Equal("Authorization code does not exist: ac_123", exception.Message);
            Assert.NotNull(exception.StripeError);
            Assert.Equal("invalid_grant", exception.StripeError.Error);
            Assert.Equal("Authorization code does not exist: ac_123", exception.StripeError.ErrorDescription);
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
        public void Deauthorize_Error()
        {
            var json = "{\"error\": \"invalid_client\", \"error_description\": \"No such application: ca_123\"}";
            this.StubRequest(HttpMethod.Post, "/oauth/deauthorize", HttpStatusCode.Unauthorized, json);

            var exception = Assert.Throws<StripeException>(() =>
                this.service.Deauthorize(this.deauthorizeOptions));
            Assert.Equal("No such application: ca_123", exception.Message);
            Assert.NotNull(exception.StripeError);
            Assert.Equal("invalid_client", exception.StripeError.Error);
            Assert.Equal("No such application: ca_123", exception.StripeError.ErrorDescription);
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

        private Dictionary<string, string> ParseQueryString(string query)
        {
            return query.TrimStart('?').Split('&')
                .Select(x => x.Split(new[] { '=' }, 2))
                .ToDictionary(x => WebUtility.UrlDecode(x[0]), x => WebUtility.UrlDecode(x[1]));
        }
    }
}
