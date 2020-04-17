namespace StripeTests
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;
    using Moq;
    using Moq.Protected;
    using Newtonsoft.Json.Linq;
    using Stripe;
    using Xunit;

    public class SystemNetHttpClientTest : BaseStripeTest
    {
        public SystemNetHttpClientTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
        }

        [Fact]
        public async Task MakeRequestAsync()
        {
            var responseMessage = new HttpResponseMessage(HttpStatusCode.OK);
            responseMessage.Content = new StringContent("Hello world!");
            this.MockHttpClientFixture.MockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(responseMessage));
            var client = new SystemNetHttpClient(
                new HttpClient(this.MockHttpClientFixture.MockHandler.Object));
            var request = new StripeRequest(
                this.StripeClient,
                HttpMethod.Post,
                "/foo",
                null,
                null);

            var response = await client.MakeRequestAsync(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("Hello world!", response.Content);
        }

        [Fact]
        public async Task UserAgentIncludesAppInfo()
        {
            var appInfo = new AppInfo
            {
                Name = "MyAwesomeApp",
                PartnerId = "pp_123",
                Version = "1.2.34",
                Url = "https://myawesomeapp.info",
            };

            var responseMessage = new HttpResponseMessage(HttpStatusCode.OK);
            responseMessage.Content = new StringContent("Hello world!");
            this.MockHttpClientFixture.MockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(responseMessage));

            var client = new SystemNetHttpClient(
                httpClient: new HttpClient(this.MockHttpClientFixture.MockHandler.Object),
                appInfo: appInfo);
            var request = new StripeRequest(
                this.StripeClient,
                HttpMethod.Post,
                "/foo",
                null,
                null);
            await client.MakeRequestAsync(request);

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m => this.VerifyHeaders(m.Headers)),
                    ItExpr.IsAny<CancellationToken>());
        }

        [Fact]
        public void CanInspectMaxNetworkRetries()
        {
            var client = new SystemNetHttpClient(
                httpClient: new HttpClient(this.MockHttpClientFixture.MockHandler.Object),
                maxNetworkRetries: 2);

            Assert.Equal(2, client.MaxNetworkRetries);
        }

        [Fact]
        public void CanInspectEnableTelemetry()
        {
            var client = new SystemNetHttpClient(
                httpClient: new HttpClient(this.MockHttpClientFixture.MockHandler.Object),
                enableTelemetry: true);

            Assert.True(client.EnableTelemetry);
        }

        private bool VerifyHeaders(HttpRequestHeaders headers)
        {
            var userAgent = headers.UserAgent.ToString();
            var appInfo = JObject.Parse(headers.GetValues("X-Stripe-Client-User-Agent").First())["application"];

            return userAgent.Contains("MyAwesomeApp/1.2.34 (https://myawesomeapp.info)") &&
                appInfo.Value<string>("name") == "MyAwesomeApp" &&
                appInfo.Value<string>("partner_id") == "pp_123" &&
                appInfo.Value<string>("version") == "1.2.34" &&
                appInfo.Value<string>("url") == "https://myawesomeapp.info";
        }
    }
}
