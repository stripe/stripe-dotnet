namespace StripeTests
{
    using System;
    using System.Collections.Generic;
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
                            (d) => d >= 15,
                            (_) => true)),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        TelemetryHeaderMatcher(
                            m.Headers,
                            (s) => s == "req_2",
                            (d) => d >= 30,
                            (_) => true)),
                    ItExpr.IsAny<CancellationToken>());
        }

        [Fact]
        public void TelemetryIncludesUsage()
        {
            this.MockHttpClientFixture.Reset();
            var fakeServer = FakeServer.ForMockHandler(this.MockHttpClientFixture.MockHandler);

            var service = new TestService(this.StripeClient);
            service.MakeRequestWithUsage(new RequestOptions());
            service.MakeRequestWithUsage(new RequestOptions());

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
                            (_) => true,
                            (_) => true,
                            (t) => t != null && t.Count == 2 && t.Contains("llama") && t.Contains("bufo"))),
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
                            (d) => d >= 15,
                            (_) => true)),
                    ItExpr.IsAny<CancellationToken>());

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                    "SendAsync",
                    Times.Once(),
                    ItExpr.Is<HttpRequestMessage>(m =>
                        TelemetryHeaderMatcher(
                            m.Headers,
                            (s) => s == "req_2",
                            (d) => d >= 15,
                            (_) => true)),
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
            Func<long, bool> durationMatcher,
            Func<List<string>, bool> usageMatcher)
        {
            if (!headers.Contains("X-Stripe-Client-Telemetry"))
            {
                return false;
            }

            var payload = headers.GetValues("X-Stripe-Client-Telemetry").First();

            var deserialized = JToken.Parse(payload);
            var requestId = (string)deserialized["last_request_metrics"]["request_id"];
            var duration = (long)deserialized["last_request_metrics"]["request_duration_ms"];
            var usageRaw = deserialized["last_request_metrics"]["usage"];

            List<string> usage = null;
            if (usageRaw != null)
            {
                usage = usageRaw.Select(x => (string)x).ToList();
            }

            return requestIdMatcher(requestId) && durationMatcher(duration) && usageMatcher(usage);
        }

        private class TestEntity : StripeEntity<TestEntity>
        {
        }

        private class TestService : Service<TestEntity>
        {
            // Real usage should mirror this and use a static readonly list, instead of creating
            // a new list every time.
            private static readonly List<string> TestUsage = new List<string> { "llama", "bufo" };

            public TestService(IStripeClient client)
                : base(client)
            {
            }

            [Obsolete("This member is deprecated and will be removed in a future release")]
            public override string BasePath => "/v1/test";

            public virtual void MakeRequestWithUsage(RequestOptions requestOptions)
            {
                RequestOptions ro = requestOptions.Clone();
                ro.Usage = TestUsage;
                this.Request<TestEntity>(HttpMethod.Get, $"/v1/customers/cus_xyz", null, ro);
            }
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
