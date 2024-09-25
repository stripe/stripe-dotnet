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

        // Note: yes the event type says v1; this is a v2 style event with a v1 event
        // payload that does not have a related object
        private static string v2KnownEventNoRelatedObjectPayload =
            @"{
                ""id"": ""evt_234"",
                ""object"": ""event"",
                ""type"": ""v1.billing.meter.no_meter_found"",
                ""created"": ""2022-02-15T00:27:45.330Z"",
              }";

        private static string v2KnownEventPayload =
            @"{
                ""id"": ""evt_234"",
                ""object"": ""event"",
                ""type"": ""v1.billing.meter.error_report_triggered"",
                ""created"": ""2022-02-15T00:27:45.330Z"",
                ""context"": ""context 123"",
                ""related_object"": {
                  ""id"": ""me_123"",
                  ""type"": ""billing.meter"",
                  ""url"": ""/v1/billing/meters/me_123"",
                  ""stripe_context"": ""acct_123""
                }
              }";

        private static string v2KnownEventWithDataPayload =
            @"{
                  ""id"": ""evt_234"",
                  ""object"": ""event"",
                  ""type"": ""v1.billing.meter.error_report_triggered"",
                  ""created"": ""2022-02-15T00:27:45.330Z"",
                  ""context"": ""context 123"",
                  ""related_object"": {
                    ""id"": ""me_123"",
                    ""type"": ""billing.meter"",
                    ""url"": ""/v1/billing/meters/me_123"",
                    ""stripe_context"": ""acct_123""
                  },
                  ""data"": {
                    ""developer_message_summary"": ""bar"",
                    ""reason"": {
                      ""error_count"": 1,
                      ""error_types"": [
                        {
                          ""code"": ""meter_event_invalid_value"",
                          ""error_count"": 1,
                          ""sample_errors"": [
                            {
                              ""error_message"": ""choose better"",
                              ""request"": {
                                  ""identifier"": ""a""
                              }
                            }
                          ]
                        }
                      ]
                    }
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

        /// <summary>
        /// Parse a ThinEvent object.  This uses StripeClient.ParseThinEvent to
        /// parse a BasePushedThinEventNameTBD and then uses the EventService
        /// to retrieve the ThinEvent.
        /// </summary>
        /// <param name="payload">The json payload to parse.</param>
        /// <returns>A ThinEvent derived class.</returns>
        private Stripe.V2.Event DoParseSignedEvent(string payload)
        {
            this.MockHttpClientFixture.MockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    Content = new StringContent(payload),
                });

            var bte = this.stripeClient.ParseThinEvent(payload, GenerateSigHeader(payload), WebhookSecret);

            // Check to make sure this parsed the payload correctly
            Assert.NotNull(bte.Id);
            var v2EventService = new Stripe.V2.Core.EventService(this.stripeClient);
            return v2EventService.Get(bte.Id);
        }

        [Fact]
        public void ParseThinEventWithoutRelatedObject()
        {
            var baseThinEvent = this.stripeClient.ParseThinEvent(v2KnownEventNoRelatedObjectPayload, GenerateSigHeader(v2KnownEventNoRelatedObjectPayload), WebhookSecret);
            Assert.NotNull(baseThinEvent);
            Assert.Equal("evt_234", baseThinEvent.Id);
            Assert.Equal("v1.billing.meter.no_meter_found", baseThinEvent.Type);
            Assert.Equal(new DateTime(2022, 2, 15, 0, 27, 45, 330, DateTimeKind.Utc), baseThinEvent.Created);
            Assert.Null(baseThinEvent.Context);
            Assert.Null(baseThinEvent.RelatedObject);
        }

        [Fact]
        public void ParseThinEventWithRelatedObject()
        {
            var baseThinEvent = this.stripeClient.ParseThinEvent(v2KnownEventPayload, GenerateSigHeader(v2KnownEventPayload), WebhookSecret);
            Assert.NotNull(baseThinEvent);
            Assert.Equal("evt_234", baseThinEvent.Id);
            Assert.Equal("v1.billing.meter.error_report_triggered", baseThinEvent.Type);
            Assert.Equal(new DateTime(2022, 2, 15, 0, 27, 45, 330, DateTimeKind.Utc), baseThinEvent.Created);
            Assert.Equal("context 123", baseThinEvent.Context);
            Assert.NotNull(baseThinEvent.RelatedObject);
            Assert.Equal("me_123", baseThinEvent.RelatedObject.Id);
            Assert.Equal("billing.meter", baseThinEvent.RelatedObject.Type);
            Assert.Equal("/v1/billing/meters/me_123", baseThinEvent.RelatedObject.Url);
        }

        [Fact]
        public void ParseUnknownEvent()
        {
            var stripeEvent = this.DoParseSignedEvent(v2UnknownEventPayload);
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
            var stripeEvent = JsonUtils.DeserializeObject<Stripe.V2.Event>(v2UnknownEventPayload);
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
            var stripeEvent = this.DoParseSignedEvent(v2KnownEventPayload);
            Assert.NotNull(stripeEvent);
            Assert.True(stripeEvent is Stripe.Events.V1BillingMeterErrorReportTriggeredEvent);
            Assert.Equal(this.stripeClient.Requestor, stripeEvent.Requestor);
        }

        [Fact]
        public void ParseEventData()
        {
            var parsed = this.DoParseSignedEvent(v2KnownEventWithDataPayload);
            Assert.True(parsed is Stripe.Events.V1BillingMeterErrorReportTriggeredEvent);
            var stripeEvent = parsed as Stripe.Events.V1BillingMeterErrorReportTriggeredEvent;

            var eventData = stripeEvent.Data;
            Assert.NotNull(eventData);

#pragma warning disable xUnit2013 // Do not use equality check to check for collection size.
            Assert.Equal("bar", eventData.DeveloperMessageSummary);
            Assert.Equal(1, eventData.Reason.ErrorCount);
            Assert.Equal(1, eventData.Reason.ErrorTypes.Count);
            Assert.Equal("meter_event_invalid_value", eventData.Reason.ErrorTypes[0].Code);
            Assert.Equal(1, eventData.Reason.ErrorTypes[0].ErrorCount);
            Assert.Equal(1, eventData.Reason.ErrorTypes[0].SampleErrors.Count);
            Assert.Equal("choose better", eventData.Reason.ErrorTypes[0].SampleErrors[0].ErrorMessage);
            Assert.Equal("a", eventData.Reason.ErrorTypes[0].SampleErrors[0].Request.Identifier);
#pragma warning restore xUnit2013 // Do not use equality check to check for collection size.
        }

        [Fact]
        public void FetchRelatedObject()
        {
            var parsed = this.DoParseSignedEvent(v2KnownEventPayload);
            Assert.True(parsed is Stripe.Events.V1BillingMeterErrorReportTriggeredEvent);
            var stripeEvent = this.DoParseSignedEvent(v2KnownEventPayload) as Stripe.Events.V1BillingMeterErrorReportTriggeredEvent;

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
            var relatedObject = stripeEvent.FetchRelatedObject();
            Assert.Equal("fa_123", relatedObject.Id);
            Assert.Equal("financial_account", relatedObject.Object);
        }

        [Fact]
        public void FetchObjectNoRelatedObject()
        {
            var parsed = this.DoParseSignedEvent(v2KnownEventNoRelatedObjectPayload);
            Assert.True(parsed is Stripe.Events.V1BillingMeterNoMeterFoundEvent);
            var stripeEvent = this.DoParseSignedEvent(v2KnownEventNoRelatedObjectPayload) as Stripe.Events.V1BillingMeterNoMeterFoundEvent;

            var eventType = typeof(Stripe.Events.V1BillingMeterNoMeterFoundEvent);
            Assert.Null(eventType.GetMethod("FetchRelatedObject"));
            Assert.Null(eventType.GetMethod("FetchRelatedObjectAsync"));
            Assert.Null(eventType.GetProperty("RelatedObject"));
        }

        [Fact]
        public async void FetchRelatedObjectAsync()
        {
            var parsed = this.DoParseSignedEvent(v2KnownEventPayload);
            Assert.True(parsed is Stripe.Events.V1BillingMeterErrorReportTriggeredEvent);
            var stripeEvent = this.DoParseSignedEvent(v2KnownEventPayload) as Stripe.Events.V1BillingMeterErrorReportTriggeredEvent;

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
            var relatedObject = await stripeEvent.FetchRelatedObjectAsync();
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

            var v2EventService = new Stripe.V2.Core.EventService(this.stripeClient);
            var v2Event = await v2EventService.GetAsync("evt_234");
            Assert.Equal(this.stripeClient.Requestor, v2Event.Requestor);
        }
    }
}
