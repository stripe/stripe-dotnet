namespace StripeTests
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Moq;
    using Moq.Protected;
    using Stripe;

    public class MockHttpClientFixture
    {
        public MockHttpClientFixture()
        {
            this.MockHandler = new Mock<HttpClientHandler>
            {
                CallBase = true,
            };
            this.HttpClient = new SystemNetHttpClient(
                new System.Net.Http.HttpClient(this.MockHandler.Object));
        }

        public Mock<HttpClientHandler> MockHandler { get; }

        public SystemNetHttpClient HttpClient { get; }

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
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The HTTP path.</param>
        /// <param name="path">The HTTP query.</param>
        public void AssertRequest(HttpMethod method, string path, string query = null)
        {
            this.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == method &&
                        m.RequestUri.AbsolutePath == path &&
                        QueryEquivalent(query, m.RequestUri.Query)),
                    ItExpr.IsAny<CancellationToken>());
        }

        /// <summary>
        /// Stubs an HTTP request with the specified method and path to return the specified status
        /// code and response body.
        /// </summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The HTTP path.</param>
        /// <param name="status">The status code to return.</param>
        /// <param name="response">The response body to return.</param>
        /// <param name="query">The HTTP query.</param>
        public void StubRequest(HttpMethod method, string path, HttpStatusCode status, string response, string query = null)
        {
            var responseMessage = new HttpResponseMessage(status);
            responseMessage.Content = new StringContent(response);

            this.MockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m =>
                        (m.Method == method &&
                        m.RequestUri.AbsolutePath == path) &&
                        (query == null || m.RequestUri.Query == query)),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(responseMessage));
        }

        private static bool QueryEquivalent(string expected, string actual)
        {
            var expectedParts = (expected ?? string.Empty).TrimStart('?').Split('&');
            var actualParts = (actual ?? string.Empty).TrimStart('?').Split('&');

            Array.Sort(expectedParts);
            Array.Sort(actualParts);

            return expectedParts.SequenceEqual(actualParts);
        }
    }
}
