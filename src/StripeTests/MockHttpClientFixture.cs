namespace StripeTests
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Web;
    using Moq;
    using Moq.Protected;
    using Stripe;

    public class MockHttpClientFixture
    {
        private static readonly Regex QueryNormalizationRegex = new Regex(@"\[\d+\]");

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
        /// <param name="query">The HTTP query.</param>
        /// <param name="host">The HTTP host.</param>
        public void AssertRequest(HttpMethod method, string path, string query = null, string host = null)
        {
            this.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        m.Method == method &&
                        m.RequestUri.AbsolutePath == path &&
                        QueryEquivalent(query, m.RequestUri.Query) &&
                        HostEquivalent(host, m)),
                    ItExpr.IsAny<CancellationToken>());
        }

        private static bool MatchHttpRequest(HttpMethod method, string path, HttpStatusCode status, string response, string query, HttpRequestMessage m)
        {
            if (m.Method != method)
            {
                return false;
            }

            if (m.RequestUri.AbsolutePath != path)
            {
                return false;
            }

            if (query != null && !QueryEquivalent(m.RequestUri.Query, query))
            {
                return false;
            }

            return true;
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
                    ItExpr.Is<HttpRequestMessage>(m => MatchHttpRequest(method, path, status, response, query, m)),
                    ItExpr.IsAny<CancellationToken>())
                .Returns(Task.FromResult(responseMessage));
        }

        private static bool QueryEquivalent(string expected, string actual)
        {
            static string[] Normalize(string query)
            {
                var decoded = WebUtility.UrlDecode(query ?? string.Empty);

                // Expected query strings use non-numbered array format (e.g. `expand[]=`)
                // while the actual query string uses numbered array format (e.g. `expand[0]=`).
                decoded = QueryNormalizationRegex.Replace(decoded, "[]");

                var parts = decoded.TrimStart('?').Split('&');
                Array.Sort(parts);
                return parts;
            }

            if (expected == null)
            {
                return true;
            }

            return Normalize(expected).SequenceEqual(Normalize(actual));
        }

        private static bool HostEquivalent(string host, HttpRequestMessage httpRequestMessage)
        {
            if (host == null)
            {
                return true;
            }

            if (!httpRequestMessage.Properties.TryGetValue("OriginalHost", out var actual))
            {
                actual = httpRequestMessage.RequestUri.Host;
            }

            return (string)actual == host;
        }
    }
}
