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
        private readonly HttpMessageHandler origHandler;

        public MockHttpClientFixture()
        {
            this.MockHandler = new Mock<HttpClientHandler>
            {
                CallBase = true
            };

            this.origHandler = StripeConfiguration.HttpMessageHandler;
            StripeConfiguration.HttpMessageHandler = this.MockHandler.Object;
        }

        public Mock<HttpClientHandler> MockHandler { get; }

        public void Dispose()
        {
            StripeConfiguration.HttpMessageHandler = this.origHandler;
        }

        /// <summary>
        /// Resets the mock's state.
        /// </summary>
        public void Reset()
        {
            this.MockHandler.Reset();
        }

        /// <summary>
        /// Asserts that a single HTTP request was made with the specified method and path.
        /// </summary>
        public void AssertRequest(HttpMethod method, string path)
        {
            this.MockHandler.Protected().Verify(
                "SendAsync",
                Times.Once(),
                ItExpr.Is<HttpRequestMessage>(m =>
                    m.Method == method &&
                    m.RequestUri.AbsolutePath == path),
                ItExpr.IsAny<CancellationToken>());
        }
    }
}
