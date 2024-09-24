namespace StripeTests
{
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
        public async Task RawRequestAsync_Json()
        {
            // Stub a request as stripe-mock does not support v2
            this.MockHttpClientFixture.StubRequest(
                    HttpMethod.Post,
                    "/v2/financial_accounts",
                    System.Net.HttpStatusCode.OK,
                    "{\"id\": \"fa_123\",\"object\":\"financial_account\"}");

            var rawResponse = await this.stripeClient.RawRequestAsync(
                HttpMethod.Post,
                "/v2/financial_accounts",
                "{\"description\":\"hello\"}",
                new RawRequestOptions
                {
                    AdditionalHeaders =
                    {
                        { "foo", "bar" },
                    },
                    ApiMode = ApiMode.V2,
                });

            this.MockHttpClientFixture.MockHandler.Protected()
                .Verify(
                        "SendAsync",
                        Times.Once(),
                        ItExpr.Is<HttpRequestMessage>(m =>
                            m.Headers.GetValues("Stripe-Version").First() == ApiVersion.CurrentPreview &&
                            m.Headers.GetValues("foo").First() == "bar"),
                        ItExpr.IsAny<CancellationToken>());

            var fa = this.stripeClient.Deserialize<Stripe.V2.FinancialAccount>(rawResponse.Content);
            Assert.Equal("fa_123", fa.Id);
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
            var stripeClientParsedEvent = this.stripeClient.ParseSnapshotEvent(
                json,
                V2.EventTest.GenerateSigHeader(json),
                V2.EventTest.WebhookSecret);

            Assert.NotNull(stripeClientParsedEvent);
            Assert.Equal("acct_123", eventUtilityEvent.Account);
            Assert.Equal("req_123", eventUtilityEvent.Request.Id);
            Assert.Equal("idempotency-key-123", eventUtilityEvent.Request.IdempotencyKey);
            Assert.Equal("acct_123", stripeClientParsedEvent.Account);
            Assert.Equal("req_123", stripeClientParsedEvent.Request.Id);
            Assert.Equal("idempotency-key-123", stripeClientParsedEvent.Request.IdempotencyKey);
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
    }
}
