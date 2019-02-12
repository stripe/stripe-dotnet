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

    public class TelemetryTest : BaseStripeTest, IDisposable
    {
        public TelemetryTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
        }

        public void Dispose()
        {
            this.ResetStripeClient();
            StripeConfiguration.EnableTelemetry = false;
        }

        [Fact]
        public void TelemetryDisabled()
        {
            this.ResetStripeClient();
            var fakeServer = FakeServer.ForMockHandler(this.MockHttpClientFixture.MockHandler);

            StripeConfiguration.EnableTelemetry = false;
            var service = new BalanceService();
            service.Get();
            service.Get();
            service.Get();

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Exactly(3),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        !m.Headers.Contains("X-Stripe-Client-Telemetry")),
                    ItExpr.IsAny<CancellationToken>());
        }

        [Fact]
        public void TelemetryEnabled()
        {
            this.ResetStripeClient();
            var fakeServer = FakeServer.ForMockHandler(this.MockHttpClientFixture.MockHandler);
            fakeServer.DelayMilliseconds = 10;

            StripeConfiguration.EnableTelemetry = true;
            var service = new BalanceService();
            service.Get();
            fakeServer.DelayMilliseconds = 20;
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
                            (d) => d >= 10)),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        TelemetryHeaderMatcher(
                            m.Headers,
                            (s) => s == "req_2",
                            (d) => d >= 20)),
                    ItExpr.IsAny<CancellationToken>());
        }

        [Fact]
        public async Task TelemetryWorksWithConcurrentRequests()
        {
            this.ResetStripeClient();
            var fakeServer = FakeServer.ForMockHandler(this.MockHttpClientFixture.MockHandler);
            fakeServer.DelayMilliseconds = 10;

            StripeConfiguration.EnableTelemetry = true;
            var service = new BalanceService();

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
                            (d) => d >= 10)),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        TelemetryHeaderMatcher(
                            m.Headers,
                            (s) => s == "req_2",
                            (d) => d >= 10)),
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

        private void ResetStripeClient()
        {
            this.MockHttpClientFixture.Reset();

            var httpClient = new System.Net.Http.HttpClient(
                this.MockHttpClientFixture.MockHandler.Object);
            var stripeClient = new StripeClient(new Stripe.SystemNetHttpClient(httpClient));

            StripeConfiguration.StripeClient = stripeClient;
        }

        private class FakeServer
        {
            private object lockObject = new object();

            public int DelayMilliseconds { get; set; } = 0;

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

                await Task.Delay(this.DelayMilliseconds);

                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Headers = { { "Request-Id", requestId } },
                    Content = new StringContent("{}", Encoding.UTF8),
                };
            }
        }
    }
}
