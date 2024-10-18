namespace StripeTests
{
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Moq;
    using Moq.Protected;
    using Stripe;
    using StripeTests.V2;
    using Xunit;

    public class StripeClientTest : BaseStripeTest
    {
        private StripeClient stripeClient;

        public StripeClientTest(StripeMockFixture stripeMockFixture, MockHttpClientFixture mockHttpClient)
            : base(stripeMockFixture, mockHttpClient)
        {
            this.stripeClient = this.StripeClient as StripeClient;
        }

        [Fact]
        public void Ctr_StripeClientOptions()
        {
            var options = new StripeClientOptions
            {
                ApiKey = "ak_123",
                ClientId = "ci_456",
                ApiBase = "localhost:8086",
                ConnectBase = "localhost:8087",
                MeterEventsBase = "localhost:6502",
                FilesBase = "localhost:555",
                HttpClient = new TestHttpClient(),
            };

            // This test is designed to ensure StripeClient properly consumes all options.  If any are
            // missing, this will fail which means we added a new option but did not add it to the
            // test.
            foreach (var pinfo in options.GetType().GetProperties())
            {
                Assert.NotNull(pinfo.GetValue(options));
            }

            var client = new StripeClient(options);

            Assert.Equal(options.ApiKey, client.ApiKey);
            Assert.Equal(options.ClientId, client.ClientId);
            Assert.Equal(options.ApiBase, client.ApiBase);
            Assert.Equal(options.ConnectBase, client.ConnectBase);
            Assert.Equal(options.MeterEventsBase, client.MeterEventsBase);
            Assert.Equal(options.FilesBase, client.FilesBase);
            Assert.Equal(options.HttpClient, client.HttpClient);
        }

        [Fact]
        public void Ctr_StripeClientOptions_ChangesAfterConstruction()
        {
            var options = new StripeClientOptions
            {
                ApiKey = "ak_123",
            };

            var client = new StripeClient(options);

            Assert.Equal(options.ApiKey, client.ApiKey);
            var goodApiKey = options.ApiKey;
            options.ApiKey = "wrong_key_456";
            Assert.NotEqual(options.ApiKey, client.ApiKey);
            Assert.Equal(goodApiKey, client.ApiKey);
        }

        [Fact]
        public async Task RawRequestAsync_Json()
        {
            // Stub a request as stripe-mock does not support v2
            this.MockHttpClientFixture.StubRequest(
                    HttpMethod.Post,
                    "/v2/billing/meter_event_session",
                    System.Net.HttpStatusCode.OK,
                    "{\"id\": \"mes_123\",\"object\":\"v2.billing.meter_event_session\"}");

            var rawResponse = await this.stripeClient.RawRequestAsync(
                HttpMethod.Post,
                "/v2/billing/meter_event_session",
                "{}",
                new RawRequestOptions
                {
                    AdditionalHeaders =
                    {
                        { "foo", "bar" },
                    },
                });

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                        "SendAsync",
                        Times.Once(),
                        ItExpr.Is<HttpRequestMessage>(m =>
                            m.Headers.GetValues("Stripe-Version").First() == ApiVersion.Current &&
                            m.Headers.GetValues("foo").First() == "bar"),
                        ItExpr.IsAny<CancellationToken>());

            var obj = this.stripeClient.Deserialize<Stripe.V2.Billing.MeterEventSession>(rawResponse.Content);
            Assert.Equal("mes_123", obj.Id);
        }

        [Fact]
        public void ConstructThinEvent()
        {
            string payload = @"{
                ""object"": ""event"",
                ""type"": ""unknown"",
                ""data"": {},
                ""relatedObject"": {
                    ""id"": ""acct_123"",
                    ""type"": ""account"",
                    ""url"": ""/v2/accounts""
                }
            }";
            var evt = this.stripeClient.ParseThinEvent(
                payload,
                V2.EventTest.GenerateSigHeader(payload),
                V2.EventTest.WebhookSecret);

            Assert.NotNull(evt);
        }

        [Fact]
        public void ConstructSnapshotEvent()
        {
            var json = GetResourceAsString("event_test_signature.json");
            var eventUtilityEvent = EventUtility.ConstructEvent(
                json,
                V2.EventTest.GenerateSigHeader(json),
                V2.EventTest.WebhookSecret,
                throwOnApiVersionMismatch: false);

            Assert.NotNull(eventUtilityEvent);
            Assert.Equal("acct_123", eventUtilityEvent.Account);
            Assert.Equal("req_123", eventUtilityEvent.Request.Id);
            Assert.Equal("idempotency-key-123", eventUtilityEvent.Request.IdempotencyKey);
        }

        [Fact]
        public async Task RawRequestAsync_Form()
        {
            // Don't stub, we can use stripe-mock
            var rawResponse = await this.stripeClient.RawRequestAsync(
                HttpMethod.Post,
                "/v1/customers",
                "description=hello",
                new RawRequestOptions
                {
                    AdditionalHeaders =
                    {
                        { "foo", "bar" },
                    },
                    ApiMode = ApiMode.V1,
                });

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                        "SendAsync",
                        Times.Once(),
                        ItExpr.Is<HttpRequestMessage>(m =>
                            m.Headers.GetValues("Stripe-Version").First() == ApiVersion.Current &&
                            m.Headers.GetValues("foo").First() == "bar"),
                        ItExpr.IsAny<CancellationToken>());

            var cus = this.stripeClient.Deserialize<Stripe.Customer>(rawResponse.Content);
            Assert.Equal("customer", cus.Object);
        }

        // NOTE: This doesn't need to do anything except be a type we can instantiate
        private class TestHttpClient : IHttpClient
        {
            public Task<StripeResponse> MakeRequestAsync(StripeRequest request, CancellationToken cancellationToken = default)
            {
                throw new System.NotImplementedException();
            }

            public Task<StripeStreamedResponse> MakeStreamingRequestAsync(StripeRequest request, CancellationToken cancellationToken = default)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
