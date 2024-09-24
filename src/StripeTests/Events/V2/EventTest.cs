namespace StripeTests.V2
{
    using System;
    using System.Net.Http;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Moq;
    using Moq.Protected;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class EventTest : BaseStripeTest
    {
        public static readonly string WebhookSecret = "whsec_test_secret";
        private static readonly string Scheme = "v1";

        private static string v2UnknownEventPayload =
            @"{
                  ""id"": ""evt_234"",
                  ""object"": ""event"",
                  ""type"": ""this.event.doesnt.exist"",
                  ""created"": ""2022-02-15T00:27:45.330Z"",
                  ""related_object"": {
                    ""id"": ""fa_123"",
                    ""type"": ""financial_account"",
                    ""url"": ""/v2/financial_accounts/fa_123"",
                    ""stripe_context"": ""acct_123""
                  },
                  ""data"": {
                    ""v1_event_id"": ""evt_789"",
                    ""enabled_features"": [""foo""]
                  }
              }";

        private static string v2KnownEventNoRelatedObjectPayload =
            @"{
                ""id"": ""evt_234"",
                ""object"": ""event"",
                ""type"": ""financial_account.balance.opened"",
                ""created"": ""2022-02-15T00:27:45.330Z"",
              }";

        private static string v2KnownEventPayload =
            @"{
                ""id"": ""evt_234"",
                ""object"": ""event"",
                ""type"": ""financial_account.balance.opened"",
                ""created"": ""2022-02-15T00:27:45.330Z"",
                ""related_object"": {
                  ""id"": ""fa_123"",
                  ""type"": ""financial_account"",
                  ""url"": ""/v2/financial_accounts/fa_123"",
                  ""stripe_context"": ""acct_123""
                }
              }";

        private static string v2KnownEventWithDataPayload =
            @"{
                  ""id"": ""evt_234"",
                  ""object"": ""event"",
                  ""type"": ""financial_account.balance.opened"",
                  ""created"": ""2022-02-15T00:27:45.330Z"",
                  ""related_object"": {
                    ""id"": ""fa_123"",
                    ""type"": ""financial_account"",
                    ""url"": ""/v2/financial_accounts/fa_123"",
                    ""stripe_context"": ""acct_123""
                  },
                  ""data"": {
                    ""containing_compartment_id"": ""bar"",
                    ""id"": ""foo""
                  }
                }";

        private StripeClient stripeClient;

        public EventTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.stripeClient = this.StripeClient as StripeClient;
        }

        private static string ComputeHmacSha256(string secret, string message)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(secret);
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);

            using var hmac = new HMACSHA256(keyBytes);
            byte[] hashBytes = hmac.ComputeHash(messageBytes);
            return BitConverter.ToString(hashBytes).Replace("-", string.Empty).ToLower();
        }

        /// <summary>
        /// Generates a Stripe-Signature header.
        /// </summary>
        /// <param name="payload">JSON payload to sign.</param>
        /// <returns>The contents of the generated header.</returns>
        public static string GenerateSigHeader(string payload)
        {
            long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            string signature = ComputeHmacSha256(WebhookSecret, $"{timestamp}.{payload}");
            string header = $"t={timestamp},{Scheme}={signature}";
            return header;
        }

        private Stripe.ThinEvent ParseSignedEvent(string payload)
        {
            return this.stripeClient.ParseThinEvent(payload, GenerateSigHeader(payload), WebhookSecret);
        }

        [Fact]
        public void ParseUnknownEvent()
        {
            var stripeEvent = this.ParseSignedEvent(v2UnknownEventPayload);
            Assert.NotNull(stripeEvent);
            Assert.Equal("evt_234", stripeEvent.Id);
            Assert.Equal("event", stripeEvent.Object);
            Assert.Equal("this.event.doesnt.exist", stripeEvent.Type);
            Assert.Equal(new DateTime(2022, 2, 15, 0, 27, 45, 330, DateTimeKind.Utc), stripeEvent.Created);
            Assert.Equal(this.stripeClient.Requestor, stripeEvent.Requestor);
        }

        [Fact]
        public void ParseThinEventWithInvalidSignature()
        {
            var exception = Assert.Throws<StripeException>(() => this.stripeClient.ParseThinEvent(v2UnknownEventPayload, "invalid signature", WebhookSecret));

            Assert.Matches("header format is unexpected", exception.Message);
        }

        [Fact]
        public void ParseUnknownEventDirectly()
        {
            var stripeEvent = JsonUtils.DeserializeObject<Stripe.ThinEvent>(v2UnknownEventPayload);
            Assert.NotNull(stripeEvent);
            Assert.Equal("evt_234", stripeEvent.Id);
            Assert.Equal("event", stripeEvent.Object);
            Assert.Equal("this.event.doesnt.exist", stripeEvent.Type);
            Assert.Equal(new DateTime(2022, 2, 15, 0, 27, 45, 330, DateTimeKind.Utc), stripeEvent.Created);
            Assert.Null(stripeEvent.Requestor);
        }

        [Fact]
        public void ParseKnownEvent()
        {
            var stripeEvent = this.ParseSignedEvent(v2KnownEventPayload);
            Assert.NotNull(stripeEvent);
            Assert.True(stripeEvent is Stripe.V2.FinancialAccountBalanceOpenedEvent);
            Assert.Equal(this.stripeClient.Requestor, stripeEvent.Requestor);
        }

        [Fact]
        public void FetchData()
        {
            var parsed = this.ParseSignedEvent(v2KnownEventPayload);
            Assert.True(this.ParseSignedEvent(v2KnownEventPayload) is Stripe.V2.FinancialAccountBalanceOpenedEvent);
            var stripeEvent = this.ParseSignedEvent(v2KnownEventPayload) as Stripe.V2.FinancialAccountBalanceOpenedEvent;

            this.MockHttpClientFixture.MockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    Content = new StringContent(v2KnownEventWithDataPayload),
                });
            var eventData = stripeEvent.FetchData();

            // TODO: There is nothing on event data to test. Once more events are supported, update test
        }

        [Fact]
        public async void FetchDataAsync()
        {
            var parsed = this.ParseSignedEvent(v2KnownEventPayload);
            Assert.True(this.ParseSignedEvent(v2KnownEventPayload) is Stripe.V2.FinancialAccountBalanceOpenedEvent);
            var stripeEvent = this.ParseSignedEvent(v2KnownEventPayload) as Stripe.V2.FinancialAccountBalanceOpenedEvent;

            this.MockHttpClientFixture.MockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    Content = new StringContent(v2KnownEventWithDataPayload),
                });
            var eventData = await stripeEvent.FetchDataAsync();

            // TODO: There is nothing on event data to test. Once more events are supported, update test
        }

        [Fact]
        public void FetchRelatedObject()
        {
            var parsed = this.ParseSignedEvent(v2KnownEventPayload);
            Assert.True(parsed is Stripe.V2.FinancialAccountBalanceOpenedEvent);
            var stripeEvent = this.ParseSignedEvent(v2KnownEventPayload) as Stripe.V2.FinancialAccountBalanceOpenedEvent;

            var relatedObjectPayload = @"
            {
                ""id"": ""fa_123"",
                ""object"": ""financial_account""
            }";
            this.MockHttpClientFixture.MockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    Content = new StringContent(relatedObjectPayload),
                });
            var relatedObject = stripeEvent.FetchObject();
            Assert.Equal("fa_123", relatedObject.Id);
            Assert.Equal("financial_account", relatedObject.Object);
        }

        [Fact]
        public void FetchObjectNoRelatedObject()
        {
            var parsed = this.ParseSignedEvent(v2KnownEventNoRelatedObjectPayload);
            Assert.True(parsed is Stripe.V2.FinancialAccountBalanceOpenedEvent);
            var stripeEvent = this.ParseSignedEvent(v2KnownEventNoRelatedObjectPayload) as Stripe.V2.FinancialAccountBalanceOpenedEvent;

            var relatedObject = stripeEvent.FetchObject();
            Assert.Null(relatedObject);
        }

        [Fact]
        public async void FetchRelatedObjectAsync()
        {
            var parsed = this.ParseSignedEvent(v2KnownEventPayload);
            Assert.True(parsed is Stripe.V2.FinancialAccountBalanceOpenedEvent);
            var stripeEvent = this.ParseSignedEvent(v2KnownEventPayload) as Stripe.V2.FinancialAccountBalanceOpenedEvent;

            var relatedObjectPayload = @"
            {
                ""id"": ""fa_123"",
                ""object"": ""financial_account""
            }";
            this.MockHttpClientFixture.MockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    Content = new StringContent(relatedObjectPayload),
                });
            var relatedObject = await stripeEvent.FetchObjectAsync();
            Assert.Equal("fa_123", relatedObject.Id);
            Assert.Equal("financial_account", relatedObject.Object);
        }

        [Fact]
        public async void RequestorIsPropagated()
        {
            this.MockHttpClientFixture.MockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    Content = new StringContent(v2KnownEventWithDataPayload),
                });

            var v2EventService = new Stripe.V2.ThinEventService(this.stripeClient);
            var v2Event = await v2EventService.GetAsync("evt_234");
            Assert.Equal(this.stripeClient.Requestor, v2Event.Requestor);
        }
    }
}
