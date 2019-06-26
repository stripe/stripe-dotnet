namespace StripeTests
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Stripe;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class StripeRequestTest : BaseStripeTest
    {
        private readonly IStripeClient stripeClient;

        public StripeRequestTest()
        {
            this.stripeClient = new StripeClient(
                "sk_test_123",
                apiBase: "https://client.example.com");
        }

        [Fact]
        public void Ctor_GetRequest()
        {
            var request = new StripeRequest(
                this.stripeClient,
                HttpMethod.Get,
                "/get",
                new TestOptions { String = "string!" },
                new RequestOptions());

            Assert.Equal(HttpMethod.Get, request.Method);
            Assert.Equal($"{this.stripeClient.ApiBase}/get?string=string!", request.Uri.ToString());
            Assert.Equal(
                $"Bearer {this.stripeClient.ApiKey}",
                request.AuthorizationHeader.ToString());
            Assert.True(request.StripeHeaders.ContainsKey("Stripe-Version"));
            Assert.Equal(StripeConfiguration.ApiVersion, request.StripeHeaders["Stripe-Version"]);
            Assert.False(request.StripeHeaders.ContainsKey("Idempotency-Key"));
            Assert.False(request.StripeHeaders.ContainsKey("Stripe-Account"));
            Assert.Null(request.Content);
        }

        [Fact]
        public async Task Ctor_PostRequest()
        {
            var request = new StripeRequest(
                this.stripeClient,
                HttpMethod.Post,
                "/post",
                new TestOptions { String = "string!" },
                new RequestOptions());

            Assert.Equal(HttpMethod.Post, request.Method);
            Assert.Equal($"{this.stripeClient.ApiBase}/post", request.Uri.ToString());
            Assert.Equal(
                $"Bearer {this.stripeClient.ApiKey}",
                request.AuthorizationHeader.ToString());
            Assert.True(request.StripeHeaders.ContainsKey("Stripe-Version"));
            Assert.Equal(StripeConfiguration.ApiVersion, request.StripeHeaders["Stripe-Version"]);
            Assert.True(request.StripeHeaders.ContainsKey("Idempotency-Key"));
            Assert.False(request.StripeHeaders.ContainsKey("Stripe-Account"));
            Assert.NotNull(request.Content);
            var content = await request.Content.ReadAsStringAsync();
            Assert.Equal("string=string!", content);
        }

        [Fact]
        public void Ctor_DeleteRequest()
        {
            var request = new StripeRequest(
                this.stripeClient,
                HttpMethod.Delete,
                "/delete",
                new TestOptions { String = "string!" },
                new RequestOptions());

            Assert.Equal(HttpMethod.Delete, request.Method);
            Assert.Equal(
                $"{this.stripeClient.ApiBase}/delete?string=string!",
                request.Uri.ToString());
            Assert.Equal(
                $"Bearer {this.stripeClient.ApiKey}",
                request.AuthorizationHeader.ToString());
            Assert.True(request.StripeHeaders.ContainsKey("Stripe-Version"));
            Assert.Equal(StripeConfiguration.ApiVersion, request.StripeHeaders["Stripe-Version"]);
            Assert.False(request.StripeHeaders.ContainsKey("Idempotency-Key"));
            Assert.False(request.StripeHeaders.ContainsKey("Stripe-Account"));
            Assert.Null(request.Content);
        }

        [Fact]
        public void Ctor_RequestOptions()
        {
            var client = new StripeClient("sk_test_123");
            var requestOptions = new RequestOptions
            {
                ApiKey = "sk_override",
                IdempotencyKey = "idempotency_key",
                StripeAccount = "acct_456",
                BaseUrl = "https://override.example.com",
                StripeVersion = "2012-12-21",
            };
            var request = new StripeRequest(
                this.stripeClient,
                HttpMethod.Get,
                "/get",
                null,
                requestOptions);

            Assert.Equal(HttpMethod.Get, request.Method);
            Assert.Equal($"{requestOptions.BaseUrl}/get", request.Uri.ToString());
            Assert.Equal($"Bearer {requestOptions.ApiKey}", request.AuthorizationHeader.ToString());
            Assert.True(request.StripeHeaders.ContainsKey("Stripe-Version"));
            Assert.Equal("2012-12-21", request.StripeHeaders["Stripe-Version"]);
            Assert.True(request.StripeHeaders.ContainsKey("Idempotency-Key"));
            Assert.Equal("idempotency_key", request.StripeHeaders["Idempotency-Key"]);
            Assert.True(request.StripeHeaders.ContainsKey("Stripe-Account"));
            Assert.Equal("acct_456", request.StripeHeaders["Stripe-Account"]);
            Assert.Null(request.Content);
        }

        [Fact]
        public void Ctor_ThrowsIfApiKeyIsNull()
        {
            var client = new StripeClient(null);
            var requestOptions = new RequestOptions();

            var exception = Assert.Throws<StripeException>(() =>
                new StripeRequest(client, HttpMethod.Get, "/get", null, requestOptions));

            Assert.Contains("No API key provided.", exception.Message);
        }
    }
}
