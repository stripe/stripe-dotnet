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
    using Stripe.Billing;
    using Stripe.Events;
    using Stripe.Infrastructure;
    using Stripe.V2;
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
                  ""livemode"": true,
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
                ""livemode"": true,
              }";

        private static string v2KnownEventPayload =
            @"{
                ""id"": ""evt_234"",
                ""object"": ""event"",
                ""type"": ""v1.billing.meter.error_report_triggered"",
                ""created"": ""2022-02-15T00:27:45.330Z"",
                ""context"": ""context 123"",
                ""livemode"": true,
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
                  ""livemode"": true,
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

        private static string v2KnownEventLivemodeFalsePayload =
            @"{
                ""id"": ""evt_234"",
                ""object"": ""event"",
                ""type"": ""v1.billing.meter.no_meter_found"",
                ""created"": ""2022-02-15T00:27:45.330Z"",
                ""livemode"": false,
              }";

        private static string v2KnownEventWithReasonPayload =
            @"{
                ""id"": ""evt_234"",
                ""object"": ""event"",
                ""type"": ""v1.billing.meter.no_meter_found"",
                ""created"": ""2022-02-15T00:27:45.330Z"",
                ""livemode"": true,
                ""reason"": {
                    ""type"": ""a.b.c"",
                    ""request"": {
                        ""id"": ""r_123"",
                        ""idempotency_key"": ""key""
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
        /// Parse a EventNotification payload. This uses StripeClient.ParseEventNotification to
        /// parse a EventNotification and then uses the method to retrieve the full Event.
        /// </summary>
        /// <param name="payload">The json payload to parse.</param>
        /// <returns>A V2.Core.Event derived class.</returns>
        private Stripe.V2.Core.Event DoParseSignedEventAndFetch(string payload)
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

            var bte = this.DoParseSignedEventNotification(payload);

            // fetch full event
            return bte.FetchEvent<Stripe.V2.Core.Event>();
        }

        /// <summary>
        /// Parse a EventNotification payload. This uses StripeClient.ParseEventNotification to
        /// parse a EventNotification and then uses the EventService.
        /// </summary>
        /// <param name="payload">The json payload to parse.</param>
        /// <returns>An EventNotification derived class.</returns>
        private Stripe.V2.Core.EventNotification DoParseSignedEventNotification(string payload)
        {
            var notif = this.stripeClient.ParseEventNotification(payload, GenerateSigHeader(payload), WebhookSecret);

            // Check to make sure this parsed the payload correctly
            Assert.NotNull(notif.Id);
            return notif;
        }

        /// <summary>
        /// Helper for asserting an object is of a type and casting to that type, all in one go.
        /// </summary>
        /// <typeparam name="T">The type your object should be.</typeparam>
        /// <param name="o">Your object.</param>
        /// <returns>The input object, cast to type T.</returns>
        private T AssertAndCast<T>(object o)
        {
            Assert.IsType<T>(o);
            return (T)o;
        }

        [Fact]
        public void ParseEventNotificationWithoutRelatedObject()
        {
            var eventNotif = this.stripeClient.ParseEventNotification(v2KnownEventNoRelatedObjectPayload, GenerateSigHeader(v2KnownEventNoRelatedObjectPayload), WebhookSecret);
            Assert.NotNull(eventNotif);
            Assert.Equal("evt_234", eventNotif.Id);
            Assert.Equal("v1.billing.meter.no_meter_found", eventNotif.Type);
            Assert.Equal(new DateTime(2022, 2, 15, 0, 27, 45, 330, DateTimeKind.Utc), eventNotif.Created);
            Assert.True(eventNotif.Livemode);
            Assert.Null(eventNotif.Context);
        }

        [Fact]
        public void ParseEventNotificationWithRelatedObject()
        {
            var eventNotif = this.stripeClient.ParseEventNotification(v2KnownEventPayload, GenerateSigHeader(v2KnownEventPayload), WebhookSecret);
            Assert.NotNull(eventNotif);
            Assert.Equal("evt_234", eventNotif.Id);
            Assert.Equal("v1.billing.meter.error_report_triggered", eventNotif.Type);
            Assert.Equal(new DateTime(2022, 2, 15, 0, 27, 45, 330, DateTimeKind.Utc), eventNotif.Created);
            Assert.True(eventNotif.Livemode);
            Assert.Equal("context 123", eventNotif.Context);
            var evt = this.AssertAndCast<V1BillingMeterErrorReportTriggeredEventNotification>(eventNotif);

            Assert.NotNull(evt.RelatedObject);
            Assert.Equal("me_123", evt.RelatedObject.Id);
            Assert.Equal("billing.meter", evt.RelatedObject.Type);
            Assert.Equal("/v1/billing/meters/me_123", evt.RelatedObject.Url);
        }

        [Fact]
        public void ParseUnknownEvent()
        {
            var notif = this.DoParseSignedEventNotification(v2UnknownEventPayload);
            var stripeEvent = this.AssertAndCast<UnknownEventNotification>(notif);

            Assert.NotNull(stripeEvent);
            Assert.Equal("evt_234", stripeEvent.Id);
            Assert.Equal("this.event.doesnt.exist", stripeEvent.Type);
            Assert.Equal(new DateTime(2022, 2, 15, 0, 27, 45, 330, DateTimeKind.Utc), stripeEvent.Created);
        }

        [Fact]
        public void ParseEventNotificationWithLivemodeFalse()
        {
            var eventNotif = this.stripeClient.ParseEventNotification(v2KnownEventLivemodeFalsePayload, GenerateSigHeader(v2KnownEventLivemodeFalsePayload), WebhookSecret);
            Assert.NotNull(eventNotif);
            Assert.Equal("evt_234", eventNotif.Id);
            Assert.Equal("v1.billing.meter.no_meter_found", eventNotif.Type);
            Assert.Equal(new DateTime(2022, 2, 15, 0, 27, 45, 330, DateTimeKind.Utc), eventNotif.Created);
            Assert.False(eventNotif.Livemode);
            Assert.Null(eventNotif.Context);
        }

        [Fact]
        public void ParseEventNotificationWithReason()
        {
            var eventNotif = this.stripeClient.ParseEventNotification(v2KnownEventWithReasonPayload, GenerateSigHeader(v2KnownEventWithReasonPayload), WebhookSecret);
            Assert.NotNull(eventNotif);
            Assert.Equal("evt_234", eventNotif.Id);
            Assert.Equal("v1.billing.meter.no_meter_found", eventNotif.Type);
            Assert.Equal(new DateTime(2022, 2, 15, 0, 27, 45, 330, DateTimeKind.Utc), eventNotif.Created);
            Assert.True(eventNotif.Livemode);
            Assert.Null(eventNotif.Context);

            Assert.NotNull(eventNotif.Reason);
            Assert.Equal("a.b.c", eventNotif.Reason.Type);
            Assert.Equal("r_123", eventNotif.Reason.Request.Id);
            Assert.Equal("key", eventNotif.Reason.Request.IdempotencyKey);
        }

        [Fact]
        public void ParseEventNotificationWithInvalidSignature()
        {
            var exception = Assert.Throws<StripeException>(() => this.stripeClient.ParseEventNotification(v2UnknownEventPayload, "invalid signature", WebhookSecret));

            Assert.Matches("header format is unexpected", exception.Message);
        }

        [Fact]
        public void ParseUnknownEventDirectly()
        {
            var stripeEvent = JsonUtils.DeserializeObject<Stripe.V2.Core.Event>(v2UnknownEventPayload);
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
            var stripeEvent = this.DoParseSignedEventAndFetch(v2KnownEventPayload);
            Assert.NotNull(stripeEvent);
            Assert.True(stripeEvent is V1BillingMeterErrorReportTriggeredEvent);
            Assert.Equal(this.stripeClient.Requestor, stripeEvent.Requestor);
        }

        [Fact]
        public void ParseEventData()
        {
            var parsed = this.DoParseSignedEventAndFetch(v2KnownEventWithDataPayload);
            var stripeEvent = this.AssertAndCast<V1BillingMeterErrorReportTriggeredEvent>(parsed);

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
            var parsed = this.DoParseSignedEventAndFetch(v2KnownEventPayload);
            var stripeEvent = this.AssertAndCast<V1BillingMeterErrorReportTriggeredEvent>(parsed);

            var relatedObjectPayload = @"
            {
                ""id"": ""meter_123"",
                ""object"": ""billing.meter""
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
            Assert.Equal("meter_123", relatedObject.Id);
            Assert.Equal("billing.meter", relatedObject.Object);
        }

        [Fact]
        public void FetchRelatedObjectFromNotif()
        {
            var notif = this.DoParseSignedEventNotification(v2KnownEventPayload);
            var evt = this.AssertAndCast<V1BillingMeterErrorReportTriggeredEventNotification>(notif);

            Assert.IsType<StripeContext>(evt.Context);

            var relatedObjectPayload = @"
            {
                ""id"": ""meter_123"",
                ""object"": ""billing.meter""
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
            var relatedObject = evt.FetchRelatedObject();
            Assert.IsType<Meter>(relatedObject);

            Assert.Equal("meter_123", relatedObject.Id);
            Assert.Equal("billing.meter", relatedObject.Object);
        }

        [Fact]
        public void FetchObjectNoRelatedObject()
        {
            var parsed = this.DoParseSignedEventNotification(v2KnownEventNoRelatedObjectPayload);
            Assert.IsType<V1BillingMeterNoMeterFoundEventNotification>(parsed);

            var eventType = typeof(V1BillingMeterNoMeterFoundEventNotification);
            Assert.Null(eventType.GetMethod("FetchRelatedObject"));
            Assert.Null(eventType.GetMethod("FetchRelatedObjectAsync"));
            Assert.Null(eventType.GetProperty("RelatedObject"));
        }

        [Fact]
        public async void FetchRelatedObjectAsync()
        {
            var parsed = this.DoParseSignedEventNotification(v2KnownEventPayload);
            var stripeEvent = this.AssertAndCast<V1BillingMeterErrorReportTriggeredEventNotification>(parsed);

            var relatedObjectPayload = @"
            {
                ""id"": ""meter_123"",
                ""object"": ""billing.meter""
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
            Assert.Equal("meter_123", relatedObject.Id);
            Assert.Equal("billing.meter", relatedObject.Object);
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
