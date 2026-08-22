namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Stripe;
    using Stripe.Events;
    using Xunit;

    public class StripeEventNotificationHandlerTest : BaseStripeTest
    {
        private const string WebhookSecret = "whsec_test_secret";
        private StripeClient stripeClient;

        public StripeEventNotificationHandlerTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.stripeClient = this.StripeClient as StripeClient;
        }

        private string V1BillingMeterPayload => @"{
            ""id"": ""evt_123"",
            ""object"": ""v2.core.event"",
            ""type"": ""v1.billing.meter.error_report_triggered"",
            ""livemode"": false,
            ""created"": ""2022-02-15T00:27:45.330Z"",
            ""context"": ""event_context_456"",
            ""related_object"": {
                ""id"": ""mtr_123"",
                ""type"": ""billing.meter"",
                ""url"": ""/v1/billing/meters/mtr_123""
            }
        }";

        private string V1BillingMeterNoMeterFoundPayload => @"{
            ""id"": ""evt_789"",
            ""object"": ""v2.core.event"",
            ""type"": ""v1.billing.meter.no_meter_found"",
            ""livemode"": false,
            ""created"": ""2022-02-15T00:27:45.330Z"",
            ""context"": null
        }";

        private string UnknownEventPayload => @"{
            ""id"": ""evt_unknown"",
            ""object"": ""v2.core.event"",
            ""type"": ""llama.created"",
            ""livemode"": false,
            ""created"": ""2022-02-15T00:27:45.330Z"",
            ""context"": ""event_context_unknown"",
            ""related_object"": {
                ""id"": ""llama_123"",
                ""type"": ""llama"",
                ""url"": ""/v1/llamas/llama_123""
            }
        }";

        [Fact]
        public void RoutesEventToRegisteredHandler()
        {
            var handlerCalled = false;
            StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> receivedArgs = null;

            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
                handlerCalled = true;
                receivedArgs = e;
            }

            var unhandledCalled = false;

            void UnhandledHandler(object sender, StripeUnhandledEventNotificationEventArgs e)
            {
                unhandledCalled = true;
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, UnhandledHandler);
            handler.V1BillingMeterErrorReportTriggered += Handler;

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload);
            handler.Handle(this.V1BillingMeterPayload, sigHeader);

            Assert.True(handlerCalled);
            Assert.NotNull(receivedArgs);
            Assert.IsType<V1BillingMeterErrorReportTriggeredEventNotification>(receivedArgs.EventNotification);
            Assert.Equal("evt_123", receivedArgs.EventNotification.Id);
            Assert.False(unhandledCalled);
        }

        [Fact]
        public void RoutesDifferentEventsToCorrectHandlers()
        {
            var billingHandlerCalled = false;
            StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> billingArgs = null;

            void BillingHandler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
                billingHandlerCalled = true;
                billingArgs = e;
            }

            var noMeterHandlerCalled = false;
            StripeEventNotificationEventArgs<V1BillingMeterNoMeterFoundEventNotification> noMeterArgs = null;

            void NoMeterHandler(object sender, StripeEventNotificationEventArgs<V1BillingMeterNoMeterFoundEventNotification> e)
            {
                noMeterHandlerCalled = true;
                noMeterArgs = e;
            }

            var unhandledCalled = false;

            void UnhandledHandler(object sender, StripeUnhandledEventNotificationEventArgs e)
            {
                unhandledCalled = true;
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, UnhandledHandler);
            handler.V1BillingMeterErrorReportTriggered += BillingHandler;
            handler.V1BillingMeterNoMeterFound += NoMeterHandler;

            var sigHeader1 = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload);
            handler.Handle(this.V1BillingMeterPayload, sigHeader1);

            var sigHeader2 = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterNoMeterFoundPayload);
            handler.Handle(this.V1BillingMeterNoMeterFoundPayload, sigHeader2);

            Assert.True(billingHandlerCalled);
            Assert.NotNull(billingArgs);
            Assert.IsType<V1BillingMeterErrorReportTriggeredEventNotification>(billingArgs.EventNotification);
            Assert.Equal("evt_123", billingArgs.EventNotification.Id);

            Assert.True(noMeterHandlerCalled);
            Assert.NotNull(noMeterArgs);
            Assert.IsType<V1BillingMeterNoMeterFoundEventNotification>(noMeterArgs.EventNotification);
            Assert.Equal("evt_789", noMeterArgs.EventNotification.Id);

            Assert.False(unhandledCalled);
        }

        [Fact]
        public void HandlerReceivesCorrectRuntimeType()
        {
            V1BillingMeterErrorReportTriggeredEventNotification receivedEvent = null;
            StripeClient receivedClient = null;

            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
                receivedEvent = e.EventNotification;
                receivedClient = e.Client;
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });
            handler.V1BillingMeterErrorReportTriggered += Handler;

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload);
            handler.Handle(this.V1BillingMeterPayload, sigHeader);

            Assert.NotNull(receivedEvent);
            Assert.IsType<V1BillingMeterErrorReportTriggeredEventNotification>(receivedEvent);
            Assert.Equal("v1.billing.meter.error_report_triggered", receivedEvent.Type);
            Assert.Equal("evt_123", receivedEvent.Id);
            Assert.Equal("mtr_123", receivedEvent.RelatedObject.Id);
            Assert.NotNull(receivedClient);
            Assert.IsType<StripeClient>(receivedClient);
        }

        [Fact]
        public void CannotRegisterDuplicateHandler()
        {
            void Handler1(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
            }

            void Handler2(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });
            handler.V1BillingMeterErrorReportTriggered += Handler1;

            var exception = Assert.Throws<InvalidOperationException>(() =>
            {
                handler.V1BillingMeterErrorReportTriggered += Handler2;
            });

            Assert.Contains("already registered", exception.Message);
        }

        [Fact]
        public void CannotRegisterNullHandler()
        {
            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });

            Assert.Throws<ArgumentNullException>(() =>
            {
                handler.V1BillingMeterErrorReportTriggered += null;
            });

            // the event type must not have been recorded as handled, otherwise dispatch would
            // take the registered branch and invoke a null delegate instead of the fallback
            Assert.Empty(handler.HandledEventTypes());
        }

        [Fact]
        public void RegisteringNullHandlerLeavesFallbackIntact()
        {
            var fallbackCalls = new List<string>();
            var handler = new StripeEventNotificationHandler(
                this.stripeClient,
                WebhookSecret,
                (s, e) => fallbackCalls.Add(e.EventNotification.Type));

            Assert.Throws<ArgumentNullException>(() =>
            {
                handler.V1BillingMeterErrorReportTriggered += null;
            });

            handler.Handle(this.V1BillingMeterPayload, StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload));

            Assert.Single(fallbackCalls);
            Assert.Equal("v1.billing.meter.error_report_triggered", fallbackCalls[0]);
        }

        [Fact]
        public void CannotRegisterHandlerAfterHandling()
        {
            void Handler1(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
            }

            void Handler2(object sender, StripeEventNotificationEventArgs<V1BillingMeterNoMeterFoundEventNotification> e)
            {
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });
            handler.V1BillingMeterErrorReportTriggered += Handler1;

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload);
            handler.Handle(this.V1BillingMeterPayload, sigHeader);

            // registration is expected to happen once at startup; doing it later is a bug
            var exception = Assert.Throws<InvalidOperationException>(() =>
            {
                handler.V1BillingMeterNoMeterFound += Handler2;
            });

            Assert.Contains("after an event has been handled", exception.Message);
        }

        [Fact]
        public void CannotRemoveHandler()
        {
            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });
            handler.V1BillingMeterErrorReportTriggered += Handler;

            var exception = Assert.Throws<InvalidOperationException>(() =>
            {
                handler.V1BillingMeterErrorReportTriggered -= Handler;
            });

            Assert.Contains("not supported", exception.Message);
        }

        [Fact]
        public void ValidatesWebhookSignature()
        {
            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });

            var exception = Assert.Throws<StripeException>(() =>
            {
                handler.Handle(this.V1BillingMeterPayload, "invalid_signature");
            });

            Assert.Contains("header format is unexpected", exception.Message);
        }

        [Fact]
        public void HandledEventTypesReturnsEmpty()
        {
            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });

            var types = handler.HandledEventTypes();

            Assert.Empty(types);
        }

        [Fact]
        public void HandledEventTypesReturnsSingle()
        {
            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });
            handler.V1BillingMeterErrorReportTriggered += Handler;

            var types = handler.HandledEventTypes();

            Assert.Single(types);
            Assert.Equal("v1.billing.meter.error_report_triggered", types[0]);
        }

        [Fact]
        public void HandledEventTypesReturnsMultipleAlphabetized()
        {
            void Handler(object sender, EventArgs e)
            {
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });

            // Register in non-alphabetical order
            handler.V2CoreAccountUpdated += Handler;
            handler.V1BillingMeterErrorReportTriggered += Handler;
            handler.V2CoreAccountCreated += Handler;

            var types = handler.HandledEventTypes();

            Assert.Equal(3, types.Count);
            Assert.Equal("v1.billing.meter.error_report_triggered", types[0]);
            Assert.Equal("v2.core.account.created", types[1]);
            Assert.Equal("v2.core.account.updated", types[2]);
        }

        [Fact]
        public void UnknownEventRoutesToUnhandledHandler()
        {
            var unhandledCalled = false;
            Stripe.V2.Core.EventNotification receivedNotification = null;
            StripeClient receivedClient = null;
            UnhandledNotificationDetails receivedDetails = null;

            void UnhandledHandler(object sender, StripeUnhandledEventNotificationEventArgs e)
            {
                unhandledCalled = true;
                receivedNotification = e.EventNotification;
                receivedClient = e.Client;
                receivedDetails = e.Details;
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, UnhandledHandler);

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.UnknownEventPayload);
            handler.Handle(this.UnknownEventPayload, sigHeader);

            Assert.True(unhandledCalled);
            Assert.NotNull(receivedNotification);
            Assert.IsType<UnknownEventNotification>(receivedNotification);
            Assert.Equal("llama.created", receivedNotification.Type);
            Assert.NotNull(receivedClient);
            Assert.IsType<StripeClient>(receivedClient);
            Assert.NotNull(receivedDetails);
            Assert.False(receivedDetails.IsKnownEventType);
        }

        [Fact]
        public void KnownUnregisteredEventRoutesToUnhandledHandler()
        {
            var unhandledCalled = false;
            Stripe.V2.Core.EventNotification receivedNotification = null;
            StripeClient receivedClient = null;
            UnhandledNotificationDetails receivedDetails = null;

            void UnhandledHandler(object sender, StripeUnhandledEventNotificationEventArgs e)
            {
                unhandledCalled = true;
                receivedNotification = e.EventNotification;
                receivedClient = e.Client;
                receivedDetails = e.Details;
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, UnhandledHandler);

            // Don't register a handler for this event type
            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload);
            handler.Handle(this.V1BillingMeterPayload, sigHeader);

            Assert.True(unhandledCalled);
            Assert.NotNull(receivedNotification);
            Assert.IsType<V1BillingMeterErrorReportTriggeredEventNotification>(receivedNotification);
            Assert.Equal("v1.billing.meter.error_report_triggered", receivedNotification.Type);
            Assert.NotNull(receivedClient);
            Assert.IsType<StripeClient>(receivedClient);
            Assert.NotNull(receivedDetails);
            Assert.True(receivedDetails.IsKnownEventType);
        }

        [Fact]
        public void RegisteredEventDoesNotCallUnhandledHandler()
        {
            var handlerCalled = false;

            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
                handlerCalled = true;
            }

            var unhandledCalled = false;

            void UnhandledHandler(object sender, StripeUnhandledEventNotificationEventArgs e)
            {
                unhandledCalled = true;
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, UnhandledHandler);
            handler.V1BillingMeterErrorReportTriggered += Handler;

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload);
            handler.Handle(this.V1BillingMeterPayload, sigHeader);

            Assert.True(handlerCalled);
            Assert.False(unhandledCalled);
        }

        [Fact]
        public void HandlerUsesEventStripeContext()
        {
            StripeContext receivedContext = null;

            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
                var requestor = e.Client.Requestor as LiveApiRequestor;
                receivedContext = requestor?.CurrentStripeContext;
            }

            var clientOptions = new StripeClientOptions
            {
                ApiKey = "sk_test_123",
                StripeContext = "original_context_123",
            };
            var client = new StripeClient(clientOptions);
            var handler = new StripeEventNotificationHandler(client, WebhookSecret, (s, e) => { });

            // Verify original context is set
            var requestor = client.Requestor as LiveApiRequestor;
            Assert.Equal("original_context_123", requestor?.CurrentStripeContext?.ToString());

            handler.V1BillingMeterErrorReportTriggered += Handler;

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload);
            handler.Handle(this.V1BillingMeterPayload, sigHeader);

            // Handler should have received the event's context
            Assert.NotNull(receivedContext);
            Assert.Equal("event_context_456", receivedContext.ToString());

            // Original context should be restored after handling
            Assert.Equal("original_context_123", requestor?.CurrentStripeContext?.ToString());
        }

        [Fact]
        public void HandlerExceptionRestoresOriginalContext()
        {
            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
                var requestor = e.Client.Requestor as LiveApiRequestor;
                Assert.Equal("event_context_456", requestor?.CurrentStripeContext?.ToString());
                throw new InvalidOperationException("Handler error!");
            }

            var clientOptions = new StripeClientOptions
            {
                ApiKey = "sk_test_123",
                StripeContext = "original_context_123",
            };
            var client = new StripeClient(clientOptions);
            var handler = new StripeEventNotificationHandler(client, WebhookSecret, (s, e) => { });

            handler.V1BillingMeterErrorReportTriggered += Handler;

            var requestor = client.Requestor as LiveApiRequestor;
            Assert.Equal("original_context_123", requestor?.CurrentStripeContext?.ToString());

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload);

            Assert.Throws<InvalidOperationException>(() =>
            {
                handler.Handle(this.V1BillingMeterPayload, sigHeader);
            });

            // Original context should be restored even after exception
            Assert.Equal("original_context_123", requestor?.CurrentStripeContext?.ToString());
        }

        [Fact]
        public void NoPreHandleHookRegisteredHandlerStillRuns()
        {
            var handlerCalled = false;

            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
                handlerCalled = true;
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });
            handler.V1BillingMeterErrorReportTriggered += Handler;

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload);
            handler.Handle(this.V1BillingMeterPayload, sigHeader);

            Assert.True(handlerCalled);
        }

        [Fact]
        public void PreHandleReturningTrueRunsBeforeRegisteredHandler()
        {
            var callOrder = new List<string>();

            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
                callOrder.Add("handler");
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });
            handler.V1BillingMeterErrorReportTriggered += Handler;
            handler.PreHandle((notification, client) =>
            {
                callOrder.Add("preHandle");
                return true;
            });

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload);
            handler.Handle(this.V1BillingMeterPayload, sigHeader);

            Assert.Equal(new List<string> { "preHandle", "handler" }, callOrder);
        }

        [Fact]
        public void PreHandleReturningFalsePreventsRegisteredHandler()
        {
            var handlerCalled = false;

            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
                handlerCalled = true;
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });
            handler.V1BillingMeterErrorReportTriggered += Handler;
            handler.PreHandle((notification, client) => false);

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload);
            handler.Handle(this.V1BillingMeterPayload, sigHeader);

            Assert.False(handlerCalled);
        }

        [Fact]
        public void PreHandleReturningFalsePreventsFallbackForUnknownEvent()
        {
            var unhandledCalled = false;

            void UnhandledHandler(object sender, StripeUnhandledEventNotificationEventArgs e)
            {
                unhandledCalled = true;
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, UnhandledHandler);
            handler.PreHandle((notification, client) => false);

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.UnknownEventPayload);
            handler.Handle(this.UnknownEventPayload, sigHeader);

            Assert.False(unhandledCalled);
        }

        [Fact]
        public void PreHandleReceivesContextScopedClientAndDoesNotMutateHandlerClient()
        {
            StripeContext receivedContext = null;

            var clientOptions = new StripeClientOptions
            {
                ApiKey = "sk_test_123",
                StripeContext = "original_context_123",
            };
            var client = new StripeClient(clientOptions);
            var handler = new StripeEventNotificationHandler(client, WebhookSecret, (s, e) => { });
            handler.V1BillingMeterErrorReportTriggered += (sender, e) => { };
            handler.PreHandle((notification, preHandleClient) =>
            {
                var requestor = preHandleClient.Requestor as LiveApiRequestor;
                receivedContext = requestor?.CurrentStripeContext;
                return true;
            });

            var requestor = client.Requestor as LiveApiRequestor;
            Assert.Equal("original_context_123", requestor?.CurrentStripeContext?.ToString());

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload);
            handler.Handle(this.V1BillingMeterPayload, sigHeader);

            // PreHandle should have received the event's context-scoped client
            Assert.NotNull(receivedContext);
            Assert.Equal("event_context_456", receivedContext.ToString());

            // The handler's own client is unmutated
            Assert.Equal("original_context_123", requestor?.CurrentStripeContext?.ToString());
        }

        [Fact]
        public void PreHandleThrowingPropagatesAndPreventsCallbacks()
        {
            var handlerCalled = false;
            var unhandledCalled = false;

            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
                handlerCalled = true;
            }

            void UnhandledHandler(object sender, StripeUnhandledEventNotificationEventArgs e)
            {
                unhandledCalled = true;
            }

            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, UnhandledHandler);
            handler.V1BillingMeterErrorReportTriggered += Handler;
            handler.PreHandle((notification, client) => throw new InvalidOperationException("PreHandle blew up!"));

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload);

            Assert.Throws<InvalidOperationException>(() =>
            {
                handler.Handle(this.V1BillingMeterPayload, sigHeader);
            });

            Assert.False(handlerCalled);
            Assert.False(unhandledCalled);
        }

        [Fact]
        public void PreHandleNullThrowsArgumentNullException()
        {
            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });

            Assert.Throws<ArgumentNullException>(() =>
            {
                handler.PreHandle(null);
            });
        }

        [Fact]
        public void PreHandleAfterHandlingThrowsInvalidOperationException()
        {
            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(this.V1BillingMeterPayload);
            handler.Handle(this.V1BillingMeterPayload, sigHeader);

            var exception = Assert.Throws<InvalidOperationException>(() =>
            {
                handler.PreHandle((notification, client) => true);
            });

            Assert.Contains("after an event has been handled", exception.Message);
        }

        [Fact]
        public void PreHandleRegisteredTwiceThrowsInvalidOperationException()
        {
            var handler = new StripeEventNotificationHandler(this.stripeClient, WebhookSecret, (s, e) => { });
            handler.PreHandle((notification, client) => true);

            var exception = Assert.Throws<InvalidOperationException>(() =>
            {
                handler.PreHandle((notification, client) => true);
            });

            Assert.Contains("already registered", exception.Message);
        }

        [Fact]
        public void HandlerWithNullEventContextUsesNull()
        {
            StripeContext receivedContext = StripeContext.Parse("should_be_replaced");

            void Handler(object sender, StripeEventNotificationEventArgs<V2CoreAccountCreatedEventNotification> e)
            {
                var requestor = e.Client.Requestor as LiveApiRequestor;
                receivedContext = requestor?.CurrentStripeContext;
            }

            var clientOptions = new StripeClientOptions
            {
                ApiKey = "sk_test_123",
                StripeContext = "original_context_123",
            };
            var client = new StripeClient(clientOptions);
            var handler = new StripeEventNotificationHandler(client, WebhookSecret, (s, e) => { });

            handler.V2CoreAccountCreated += Handler;

            var payload = @"{
                ""id"": ""evt_account_created"",
                ""object"": ""v2.core.event"",
                ""type"": ""v2.core.account.created"",
                ""livemode"": false,
                ""created"": ""2022-02-15T00:27:45.330Z"",
                ""context"": null
            }";

            var requestor = client.Requestor as LiveApiRequestor;
            Assert.IsType<StripeContext>(requestor?.CurrentStripeContext);
            Assert.Equal("original_context_123", requestor?.CurrentStripeContext?.ToString());

            var sigHeader = StripeTests.V2.EventTest.GenerateSigHeader(payload);
            handler.Handle(payload, sigHeader);

            // Handler should have received null context
            Assert.Null(receivedContext);

            // Original context should be restored
            Assert.Equal("original_context_123", requestor?.CurrentStripeContext?.ToString());
        }
    }

#pragma warning disable SA1402 // File may only contain a single type
    public class StripeEventNotificationHandlerWithoutVerificationTest : BaseStripeTest
    {
        private StripeClient stripeClient;

        public StripeEventNotificationHandlerWithoutVerificationTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.stripeClient = this.StripeClient as StripeClient;
        }

        private string V1BillingMeterPayload => @"{
            ""id"": ""evt_123"",
            ""object"": ""v2.core.event"",
            ""type"": ""v1.billing.meter.error_report_triggered"",
            ""livemode"": false,
            ""created"": ""2022-02-15T00:27:45.330Z"",
            ""context"": ""event_context_456"",
            ""related_object"": {
                ""id"": ""mtr_123"",
                ""type"": ""billing.meter"",
                ""url"": ""/v1/billing/meters/mtr_123""
            }
        }";

        private string UnknownEventPayload => @"{
            ""id"": ""evt_unknown"",
            ""object"": ""v2.core.event"",
            ""type"": ""llama.created"",
            ""livemode"": false,
            ""created"": ""2022-02-15T00:27:45.330Z"",
            ""context"": ""event_context_unknown"",
            ""related_object"": {
                ""id"": ""llama_123"",
                ""type"": ""llama"",
                ""url"": ""/v1/llamas/llama_123""
            }
        }";

        [Fact]
        public void RoutesEventToRegisteredHandler()
        {
            var handlerCalled = false;
            StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> receivedArgs = null;

            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
                handlerCalled = true;
                receivedArgs = e;
            }

            var unhandledCalled = false;

            void UnhandledHandler(object sender, StripeUnhandledEventNotificationEventArgs e)
            {
                unhandledCalled = true;
            }

            var handler = StripeEventNotificationHandler.WithoutVerification(this.stripeClient, UnhandledHandler);
            handler.V1BillingMeterErrorReportTriggered += Handler;

            handler.Handle(this.V1BillingMeterPayload);

            Assert.True(handlerCalled);
            Assert.NotNull(receivedArgs);
            Assert.IsType<V1BillingMeterErrorReportTriggeredEventNotification>(receivedArgs.EventNotification);
            Assert.Equal("evt_123", receivedArgs.EventNotification.Id);
            Assert.False(unhandledCalled);
        }

        [Fact]
        public void HandleTakesOnlyBody()
        {
            // Handle(json) takes a single parameter — no signature header required.
            var handlerCalled = false;

            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
                handlerCalled = true;
            }

            var handler = StripeEventNotificationHandler.WithoutVerification(this.stripeClient, (s, e) => { });
            handler.V1BillingMeterErrorReportTriggered += Handler;

            // No sig header — this must not throw.
            handler.Handle(this.V1BillingMeterPayload);

            Assert.True(handlerCalled);
        }

        [Fact]
        public void KnownUnregisteredEventRoutesToFallbackWithIsKnownTrue()
        {
            var unhandledCalled = false;
            Stripe.V2.Core.EventNotification receivedNotification = null;
            StripeClient receivedClient = null;
            UnhandledNotificationDetails receivedDetails = null;

            void UnhandledHandler(object sender, StripeUnhandledEventNotificationEventArgs e)
            {
                unhandledCalled = true;
                receivedNotification = e.EventNotification;
                receivedClient = e.Client;
                receivedDetails = e.Details;
            }

            var handler = StripeEventNotificationHandler.WithoutVerification(this.stripeClient, UnhandledHandler);

            // Don't register a handler for this event type
            handler.Handle(this.V1BillingMeterPayload);

            Assert.True(unhandledCalled);
            Assert.NotNull(receivedNotification);
            Assert.IsType<V1BillingMeterErrorReportTriggeredEventNotification>(receivedNotification);
            Assert.Equal("v1.billing.meter.error_report_triggered", receivedNotification.Type);
            Assert.NotNull(receivedClient);
            Assert.IsType<StripeClient>(receivedClient);
            Assert.NotNull(receivedDetails);
            Assert.True(receivedDetails.IsKnownEventType);
        }

        [Fact]
        public void UnknownEventRoutesToFallbackWithIsKnownFalse()
        {
            var unhandledCalled = false;
            Stripe.V2.Core.EventNotification receivedNotification = null;
            StripeClient receivedClient = null;
            UnhandledNotificationDetails receivedDetails = null;

            void UnhandledHandler(object sender, StripeUnhandledEventNotificationEventArgs e)
            {
                unhandledCalled = true;
                receivedNotification = e.EventNotification;
                receivedClient = e.Client;
                receivedDetails = e.Details;
            }

            var handler = StripeEventNotificationHandler.WithoutVerification(this.stripeClient, UnhandledHandler);

            handler.Handle(this.UnknownEventPayload);

            Assert.True(unhandledCalled);
            Assert.NotNull(receivedNotification);
            Assert.IsType<UnknownEventNotification>(receivedNotification);
            Assert.Equal("llama.created", receivedNotification.Type);
            Assert.NotNull(receivedClient);
            Assert.IsType<StripeClient>(receivedClient);
            Assert.NotNull(receivedDetails);
            Assert.False(receivedDetails.IsKnownEventType);
        }

        [Fact]
        public void HandlerUsesEventStripeContext()
        {
            StripeContext receivedContext = null;

            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
                var requestor = e.Client.Requestor as LiveApiRequestor;
                receivedContext = requestor?.CurrentStripeContext;
            }

            var clientOptions = new StripeClientOptions
            {
                ApiKey = "sk_test_123",
                StripeContext = "original_context_123",
            };
            var client = new StripeClient(clientOptions);
            var handler = StripeEventNotificationHandler.WithoutVerification(client, (s, e) => { });

            // Verify original context is set
            var requestor = client.Requestor as LiveApiRequestor;
            Assert.Equal("original_context_123", requestor?.CurrentStripeContext?.ToString());

            handler.V1BillingMeterErrorReportTriggered += Handler;

            handler.Handle(this.V1BillingMeterPayload);

            // Handler should have received the event's context
            Assert.NotNull(receivedContext);
            Assert.Equal("event_context_456", receivedContext.ToString());

            // Original context should be restored after handling
            Assert.Equal("original_context_123", requestor?.CurrentStripeContext?.ToString());
        }

        [Fact]
        public void CannotRegisterHandlerAfterHandling()
        {
            void Handler1(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
            }

            void Handler2(object sender, StripeEventNotificationEventArgs<V1BillingMeterNoMeterFoundEventNotification> e)
            {
            }

            var handler = StripeEventNotificationHandler.WithoutVerification(this.stripeClient, (s, e) => { });
            handler.V1BillingMeterErrorReportTriggered += Handler1;

            handler.Handle(this.V1BillingMeterPayload);

            // the guard lives on the shared base, so it applies to this sibling too
            var exception = Assert.Throws<InvalidOperationException>(() =>
            {
                handler.V1BillingMeterNoMeterFound += Handler2;
            });

            Assert.Contains("after an event has been handled", exception.Message);
        }

        [Fact]
        public void PreHandleGatesRegisteredHandlerAndFallback()
        {
            // the PreHandle hook lives on the shared base, so it applies to this sibling too
            var handlerCalled = false;
            var unhandledCalled = false;

            void Handler(object sender, StripeEventNotificationEventArgs<V1BillingMeterErrorReportTriggeredEventNotification> e)
            {
                handlerCalled = true;
            }

            void UnhandledHandler(object sender, StripeUnhandledEventNotificationEventArgs e)
            {
                unhandledCalled = true;
            }

            var handler = StripeEventNotificationHandler.WithoutVerification(this.stripeClient, UnhandledHandler);
            handler.V1BillingMeterErrorReportTriggered += Handler;
            handler.PreHandle((notification, client) => false);

            handler.Handle(this.V1BillingMeterPayload);

            Assert.False(handlerCalled);
            Assert.False(unhandledCalled);
        }

        [Fact]
        public void DoesNotExposeVerifyingHandle()
        {
            // The two handlers are siblings, so the signature-verifying Handle(json, sigHeader)
            // isn't inherited here at all -- passing a signature header is a compile error rather
            // than a runtime one. Assert on the declared methods so a refactor can't quietly
            // reintroduce it.
            var handleMethods = typeof(StripeEventNotificationHandlerWithoutVerification)
                .GetMethods()
                .Where(m => m.Name == "Handle")
                .ToList();

            Assert.Single(handleMethods);
            Assert.Single(handleMethods[0].GetParameters());
        }

        [Fact]
        public void CannotBeDerivedOutsideThisAssembly()
        {
            // The shared base has to be public (CS0060), so its constructor is internal instead.
            var ctors = typeof(StripeEventNotificationHandlerBase)
                .GetConstructors(BindingFlags.Instance | BindingFlags.Public);

            Assert.Empty(ctors);
        }

        [Fact]
        public void StaticFactoryReturnsCorrectType()
        {
            var handler = StripeEventNotificationHandler.WithoutVerification(this.stripeClient, (s, e) => { });

            Assert.IsType<StripeEventNotificationHandlerWithoutVerification>(handler);
        }

        [Fact]
        public void ClientFactoryMethodReturnsCorrectType()
        {
            var handler = this.stripeClient.NotificationHandlerWithoutVerification((s, e) => { });

            Assert.IsType<StripeEventNotificationHandlerWithoutVerification>(handler);
        }
    }
#pragma warning restore SA1402 // File may only contain a single type
}
