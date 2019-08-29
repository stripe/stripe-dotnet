namespace StripeTests
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Moq;
    using Moq.Protected;
    using Newtonsoft.Json.Linq;
    using Stripe;
    using Xunit;

    public class TelemetryTest : BaseStripeTest
    {
        public TelemetryTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
        }

        [Fact]
        public void TelemetryWorks()
        {
            this.MockHttpClientFixture.Reset();
            var fakeServer = FakeServer.ForMockHandler(this.MockHttpClientFixture.MockHandler);
            fakeServer.Delay = TimeSpan.FromMilliseconds(20);

            var service = new BalanceService(this.StripeClient);
            service.Get();
            fakeServer.Delay = TimeSpan.FromMilliseconds(40);
            service.Get();
            service.Get();

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        !m.Headers.Contains("X-Stripe-Client-Telemetry")),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        TelemetryHeaderMatcher(
                            m.Headers,
                            (s) => s == "req_1",
                            (d) => d >= 15)),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        TelemetryHeaderMatcher(
                            m.Headers,
                            (s) => s == "req_2",
                            (d) => d >= 30)),
                    ItExpr.IsAny<CancellationToken>());
        }

        [Fact]
        public async Task TelemetryWorksWithConcurrentRequests()
        {
            this.MockHttpClientFixture.Reset();
            var fakeServer = FakeServer.ForMockHandler(this.MockHttpClientFixture.MockHandler);
            fakeServer.Delay = TimeSpan.FromMilliseconds(20);

            var service = new BalanceService(this.StripeClient);

            // the first 2 requests will not contain telemetry
            await Task.WhenAll(service.GetAsync(), service.GetAsync());

            // the following 2 requests will contain telemetry
            await Task.WhenAll(service.GetAsync(), service.GetAsync());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Exactly(2),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        !m.Headers.Contains("X-Stripe-Client-Telemetry")),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        TelemetryHeaderMatcher(
                            m.Headers,
                            (s) => s == "req_1",
                            (d) => d >= 15)),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        TelemetryHeaderMatcher(
                            m.Headers,
                            (s) => s == "req_2",
                            (d) => d >= 15)),
                    ItExpr.IsAny<CancellationToken>());
        }

        [Fact]
        public void NoTelemetryWhenDisabled()
        {
            var mockHandler = new Mock<HttpClientHandler> { CallBase = true };
            var httpClient = new SystemNetHttpClient(
                new System.Net.Http.HttpClient(mockHandler.Object),
                enableTelemetry: false);
            var stripeClient = new StripeClient("sk_test_123", httpClient: httpClient);

            mockHandler.Reset();
            var fakeServer = FakeServer.ForMockHandler(mockHandler);
            fakeServer.Delay = TimeSpan.FromMilliseconds(20);

            var service = new BalanceService(stripeClient);
            service.Get();
            fakeServer.Delay = TimeSpan.FromMilliseconds(40);
            service.Get();
            service.Get();

            mockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Exactly(3),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        !m.Headers.Contains("X-Stripe-Client-Telemetry")),
                    ItExpr.IsAny<CancellationToken>());
        }

        private static bool TelemetryHeaderMatcher(
            HttpHeaders headers,
            Func<string, bool> requestIdMatcher,
            Func<long, bool> durationMatcher)
        {
            if (!headers.Contains("X-Stripe-Client-Telemetry"))
            {
                return false;
            }

            var payload = headers.GetValues("X-Stripe-Client-Telemetry").First();

            var deserialized = JToken.Parse(payload);
            var requestId = (string)deserialized["last_request_metrics"]["request_id"];
            var duration = (long)deserialized["last_request_metrics"]["request_duration_ms"];

            return requestIdMatcher(requestId) && durationMatcher(duration);
        }

        private class FakeServer
        {
            private readonly object lockObject = new object();

            public TimeSpan Delay { get; set; } = TimeSpan.Zero;

            public int RequestCount { get; protected set; }

            public static FakeServer ForMockHandler(Mock<HttpClientHandler> mockHandler)
            {
                var fakeServer = new FakeServer();
                mockHandler.Protected()
                    .Setup<Task<HttpResponseMessage>>(
                        "SendAsync",
                        ItExpr.IsAny<HttpRequestMessage>(),
                        ItExpr.IsAny<CancellationToken>())
                    .Returns(fakeServer.NextResponse);
                return fakeServer;
            }

            public async Task<HttpResponseMessage> NextResponse()
            {
                string requestId;

                lock (this.lockObject)
                {
                    this.RequestCount += 1;
                    requestId = $"req_{this.RequestCount}";
                }

                await Task.Delay(this.Delay).ConfigureAwait(false);

                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Headers = { { "Request-Id", requestId } },
                    Content = new StringContent("{}", Encoding.UTF8),
                };
            }
        }
    }
}
