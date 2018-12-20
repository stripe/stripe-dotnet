namespace StripeTests
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using Moq;
    using Moq.Protected;
    using Stripe;

    public class MockHttpClientFixture : IDisposable
    {
        private Mock<HttpClientHandler> mockHandler;

        private HttpMessageHandler origHandler;

        public MockHttpClientFixture()
        {
            this.mockHandler = new Mock<HttpClientHandler>
            {
                CallBase = true
            };

            this.origHandler = StripeConfiguration.HttpMessageHandler;
            StripeConfiguration.HttpMessageHandler = this.mockHandler.Object;
        }

        public void Dispose()
        {
            StripeConfiguration.HttpMessageHandler = this.origHandler;
        }

        /// <summary>
        /// Resets all invocations recorded for the mock client.
        /// </summary>
        public void Reset()
        {
            this.mockHandler.Invocations.Clear();
        }

        /// <summary>
        /// Asserts that a single HTTP request was made with the specified method and path.
        /// </summary>
        public void AssertRequest(HttpMethod method, string path)
        {
            this.mockHandler.Protected().Verify(
                "SendAsync",
                Times.Once(),
                ItExpr.Is<HttpRequestMessage>(m =>
                    m.Method == method &&
                    m.RequestUri.AbsolutePath == path),
                ItExpr.IsAny<CancellationToken>());
        }
    }
}
