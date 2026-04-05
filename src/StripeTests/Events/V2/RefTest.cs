namespace StripeTests.V2
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;
    using Stripe;
    using Stripe.Infrastructure;
    using Stripe.V2;
    using Xunit;

    public class RefTest : BaseStripeTest
    {
        public RefTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
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
        public void DeserializeViaRequestorInjectsRequestor()
        {
            var json = @"{
                ""id"": ""fa_123"",
                ""type"": ""financial_account"",
                ""url"": ""/v2/financial_accounts/fa_123""
            }";

            // Simulate how LiveApiRequestor.ProcessResponse deserializes: cloned options
            // with the factory prepended.
            var opts = new JsonSerializerOptions(StripeConfiguration.SerializerOptions);
            opts.Converters.Insert(0, new STJRequestorInjectionConverterFactory(this.Requestor));

            var refObj = JsonSerializer.Deserialize<Ref<Stripe.V2.Core.Account>>(json, opts);

            Assert.NotNull(refObj);
            Assert.Equal("fa_123", refObj.Id);
            Assert.Same(this.Requestor, ((IHasRequestor)refObj).Requestor);
        }

        [Fact]
        public void FetchThrowsWithNoRequestor()
        {
            var json = @"{
                ""id"": ""fa_123"",
                ""type"": ""financial_account"",
                ""url"": ""/v2/financial_accounts/fa_123""
            }";

            var refObj = StripeEntity.FromJson<Ref<Stripe.V2.Core.Account>>(json);

            // Requestor is null — Fetch() should throw
            var ex = Assert.Throws<Exception>(() => refObj.Fetch());
            Assert.Contains("no requestor", ex.Message);
        }

        [Fact]
        public async Task FetchAsyncThrowsWithNoRequestor()
        {
            var json = @"{
                ""id"": ""fa_123"",
                ""type"": ""financial_account"",
                ""url"": ""/v2/financial_accounts/fa_123""
            }";

            var refObj = StripeEntity.FromJson<Ref<Stripe.V2.Core.Account>>(json);

            // Requestor is null — FetchAsync() should throw
            var ex = await Assert.ThrowsAsync<Exception>(() => refObj.FetchAsync());
            Assert.Contains("no requestor", ex.Message);
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
            ((IHasRequestor)refObj).Requestor = this.Requestor;

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
            ((IHasRequestor)refObj).Requestor = this.Requestor;

            var result = refObj.Fetch();

            Assert.NotNull(result);
            Assert.Equal("fa_123", result.Id);

            this.AssertRequest(HttpMethod.Get, "/v2/financial_accounts/fa_123");
        }
    }
}
