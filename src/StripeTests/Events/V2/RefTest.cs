namespace StripeTests.V2
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Stripe;
    using Stripe.V2;
    using Xunit;

    public class RefTest : BaseStripeTest
    {
        private StripeClient stripeClient;

        public RefTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.stripeClient = this.StripeClient as StripeClient;
        }

        [Fact]
        public void Deserialize()
        {
            var json = @"{
                ""id"": ""fa_123"",
                ""type"": ""financial_account"",
                ""url"": ""/v2/financial_accounts/fa_123""
            }";

            var refObj = StripeEntity.FromJson<Ref<Stripe.V2.Core.Account>>(json);

            Assert.NotNull(refObj);
            Assert.Equal("fa_123", refObj.Id);
            Assert.Equal("financial_account", refObj.Type);
            Assert.Equal("/v2/financial_accounts/fa_123", refObj.Url);
        }

        [Fact]
        public void FetchThrowsWithNoClient()
        {
            var json = @"{
                ""id"": ""fa_123"",
                ""type"": ""financial_account"",
                ""url"": ""/v2/financial_accounts/fa_123""
            }";

            var refObj = StripeEntity.FromJson<Ref<Stripe.V2.Core.Account>>(json);

            // Client is null — Fetch() should throw
            var ex = Assert.Throws<Exception>(() => refObj.Fetch());
            Assert.Contains("no client", ex.Message);
        }

        [Fact]
        public async Task FetchAsyncThrowsWithNoClient()
        {
            var json = @"{
                ""id"": ""fa_123"",
                ""type"": ""financial_account"",
                ""url"": ""/v2/financial_accounts/fa_123""
            }";

            var refObj = StripeEntity.FromJson<Ref<Stripe.V2.Core.Account>>(json);

            // Client is null — FetchAsync() should throw
            var ex = await Assert.ThrowsAsync<Exception>(() => refObj.FetchAsync());
            Assert.Contains("no client", ex.Message);
        }

        [Fact]
        public async Task FetchAsyncGetsUrlAndDeserializes()
        {
            var refJson = @"{
                ""id"": ""fa_123"",
                ""type"": ""financial_account"",
                ""url"": ""/v2/financial_accounts/fa_123""
            }";

            var responseJson = @"{
                ""id"": ""fa_123"",
                ""object"": ""financial_account"",
                ""livemode"": false
            }";

            this.MockHttpClientFixture.StubRequest(
                HttpMethod.Get,
                "/v2/financial_accounts/fa_123",
                HttpStatusCode.OK,
                responseJson);

            var refObj = StripeEntity.FromJson<Ref<Stripe.V2.Core.Account>>(refJson);
            refObj.Client = this.stripeClient;

            var result = await refObj.FetchAsync();

            Assert.NotNull(result);
            Assert.Equal("fa_123", result.Id);

            this.AssertRequest(HttpMethod.Get, "/v2/financial_accounts/fa_123");
        }

        [Fact]
        public void FetchGetsUrlAndDeserializes()
        {
            var refJson = @"{
                ""id"": ""fa_123"",
                ""type"": ""financial_account"",
                ""url"": ""/v2/financial_accounts/fa_123""
            }";

            var responseJson = @"{
                ""id"": ""fa_123"",
                ""object"": ""financial_account"",
                ""livemode"": false
            }";

            this.MockHttpClientFixture.StubRequest(
                HttpMethod.Get,
                "/v2/financial_accounts/fa_123",
                HttpStatusCode.OK,
                responseJson);

            var refObj = StripeEntity.FromJson<Ref<Stripe.V2.Core.Account>>(refJson);
            refObj.Client = this.stripeClient;

            var result = refObj.Fetch();

            Assert.NotNull(result);
            Assert.Equal("fa_123", result.Id);

            this.AssertRequest(HttpMethod.Get, "/v2/financial_accounts/fa_123");
        }
    }
}
