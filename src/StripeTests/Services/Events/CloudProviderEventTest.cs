namespace StripeTests
{
    using System;
    using System.Text.Json;
    using Stripe;
    using Xunit;

    public class CloudProviderEventTest : BaseStripeTest
    {
        private const string EventBridgePayload =
            "{\"version\":\"0\",\"id\":\"17e8dff5-d6cd-3770-ace9-aeac02b6ac3f\","
            + "\"detail-type\":\"customer.created\","
            + "\"source\":\"aws.partner/stripe.com/ed_123\","
            + "\"account\":\"506417113029\","
            + "\"time\":\"2024-03-07T18:27:56Z\","
            + "\"region\":\"us-west-2\","
            + "\"resources\":[],"
            + "\"detail\":{"
            + "\"id\":\"evt_test_123\","
            + "\"object\":\"event\","
            + "\"api_version\":\"2023-10-16\","
            + "\"created\":1709836076,"
            + "\"data\":{\"object\":{\"id\":\"cus_123\",\"object\":\"customer\"}},"
            + "\"livemode\":true,"
            + "\"pending_webhooks\":0,"
            + "\"request\":{\"id\":\"req_123\",\"idempotency_key\":null},"
            + "\"type\":\"customer.created\"}}";

        private const string EventGridPayload =
            "{\"specversion\":\"1.0\","
            + "\"type\":\"customer.created\","
            + "\"source\":\"/providers/stripe/ed_test_123\","
            + "\"id\":\"9aeb0fdf-c01e-0131-0922-9eb54906e209\","
            + "\"time\":\"2025-07-11T14:30:00Z\","
            + "\"subject\":null,"
            + "\"dataContentType\":\"application/cloudevents+json\","
            + "\"data\":{"
            + "\"id\":\"evt_test_456\","
            + "\"object\":\"event\","
            + "\"api_version\":\"2023-10-16\","
            + "\"created\":1709836076,"
            + "\"data\":{\"object\":{\"id\":\"cus_456\",\"object\":\"customer\"}},"
            + "\"livemode\":false,"
            + "\"pending_webhooks\":0,"
            + "\"request\":{\"id\":\"req_456\",\"idempotency_key\":null},"
            + "\"type\":\"customer.created\"}}";

        private const string EventBridgeV2NotificationPayload =
            "{\"version\":\"0\",\"id\":\"17e8dff5-d6cd-3770-ace9-aeac02b6ac3f\","
            + "\"detail-type\":\"v1.billing.meter.error_report_triggered\","
            + "\"source\":\"aws.partner/stripe.com/ed_123\","
            + "\"account\":\"506417113029\","
            + "\"time\":\"2024-03-07T18:27:56Z\","
            + "\"region\":\"us-west-2\","
            + "\"resources\":[],"
            + "\"detail\":{"
            + "\"id\":\"evt_234\","
            + "\"object\":\"v2.core.event\","
            + "\"type\":\"v1.billing.meter.error_report_triggered\","
            + "\"created\":\"2022-02-15T00:27:45.330Z\","
            + "\"livemode\":true}}";

        private const string EventGridV2NotificationPayload =
            "{\"specversion\":\"1.0\","
            + "\"type\":\"v1.billing.meter.error_report_triggered\","
            + "\"source\":\"/providers/stripe/ed_test_123\","
            + "\"id\":\"9aeb0fdf-c01e-0131-0922-9eb54906e209\","
            + "\"time\":\"2025-07-11T14:30:00Z\","
            + "\"subject\":null,"
            + "\"dataContentType\":\"application/cloudevents+json\","
            + "\"data\":{"
            + "\"id\":\"evt_234\","
            + "\"object\":\"v2.core.event\","
            + "\"type\":\"v1.billing.meter.error_report_triggered\","
            + "\"created\":\"2022-02-15T00:27:45.330Z\","
            + "\"livemode\":true}}";

        [Fact]
        public void EventBridge()
        {
            var client = new StripeClient("sk_test_fake");
            var result = client.ConstructEventFromCloudProvider(EventBridgePayload);
            Assert.NotNull(result);
            Assert.Equal("evt_test_123", result.Id);
            Assert.Equal("customer.created", result.Type);
        }

        [Fact]
        public void EventGrid()
        {
            var client = new StripeClient("sk_test_fake");
            var result = client.ConstructEventFromCloudProvider(EventGridPayload);
            Assert.NotNull(result);
            Assert.Equal("evt_test_456", result.Id);
            Assert.Equal("customer.created", result.Type);
        }

        [Fact]
        public void InvalidJson()
        {
            var client = new StripeClient("sk_test_fake");
            Assert.ThrowsAny<JsonException>(() =>
                client.ConstructEventFromCloudProvider("not valid json"));
        }

        [Fact]
        public void RawEventSuggestsConstructEvent()
        {
            var rawEvent = "{\"id\":\"evt_test_123\",\"object\":\"event\",\"type\":\"customer.created\"}";
            var client = new StripeClient("sk_test_fake");
            var ex = Assert.Throws<ArgumentException>(() =>
                client.ConstructEventFromCloudProvider(rawEvent));
            Assert.Contains("ConstructEvent", ex.Message);
        }

        [Fact]
        public void UnrecognizedFormat()
        {
            var client = new StripeClient("sk_test_fake");
            var ex = Assert.Throws<ArgumentException>(() =>
                client.ConstructEventFromCloudProvider("{\"foo\":\"bar\"}"));
            Assert.Contains("Unrecognized cloud event format", ex.Message);
        }

        [Fact]
        public void ParseEventNotificationFromCloudProvider_EventBridge()
        {
            var client = new StripeClient("sk_test_fake");
            var result = client.ParseEventNotificationFromCloudProvider(EventBridgeV2NotificationPayload);
            Assert.NotNull(result);
            Assert.Equal("evt_234", result.Id);
            Assert.Equal("v1.billing.meter.error_report_triggered", result.Type);
        }

        [Fact]
        public void ParseEventNotificationFromCloudProvider_EventGrid()
        {
            var client = new StripeClient("sk_test_fake");
            var result = client.ParseEventNotificationFromCloudProvider(EventGridV2NotificationPayload);
            Assert.NotNull(result);
            Assert.Equal("evt_234", result.Id);
            Assert.Equal("v1.billing.meter.error_report_triggered", result.Type);
        }

        [Fact]
        public void ParseEventNotificationFromCloudProvider_V1EventThrows()
        {
            var client = new StripeClient("sk_test_fake");
            var ex = Assert.Throws<ArgumentException>(() =>
                client.ParseEventNotificationFromCloudProvider(EventBridgePayload));
            Assert.Contains("ConstructEvent", ex.Message);
        }
    }
}
