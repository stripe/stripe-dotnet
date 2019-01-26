namespace StripeTests
{
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Moq;
    using Moq.Protected;
    using Stripe;
    using Xunit;

    public class SystemNetHttpClientTest : BaseStripeTest
    {
        [Fact]
        public async Task MakeRequestAsync()
        {
            var responseMessage = new HttpResponseMessage(HttpStatusCode.OK);
            responseMessage.Content = new StringContent("Hello world!");
            var mockHandler = new Mock<HttpClientHandler>();
            mockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(responseMessage));
            var client = new SystemNetHttpClient(new System.Net.Http.HttpClient(mockHandler.Object));
            var request = new StripeRequest(HttpMethod.Post, "/foo", null, null);

            var response = await client.MakeRequestAsync(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("Hello world!", response.Content);
        }
    }
}
