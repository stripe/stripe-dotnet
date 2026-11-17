namespace StripeTests.Infrastructure.Public
{
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Events;
    using Stripe.V2.Core;
    using Xunit;
    using STJ = System.Text.Json;

    public class StripeContextJsonTest
    {
        private const string NotificationPayload = @"{
            ""id"": ""evt_123"",
            ""object"": ""v2.core.event"",
            ""type"": ""v1.billing.meter.error_report_triggered"",
            ""livemode"": false,
            ""created"": ""2022-02-15T00:27:45.330Z"",
            ""context"": ""acct_A/acct_B"",
            ""related_object"": {
                ""id"": ""mtr_123"",
                ""type"": ""billing.meter"",
                ""url"": ""/v1/billing/meters/mtr_123""
            }
        }";

        [Fact]
        public void Newtonsoft_SerializesAsContextString()
        {
            var json = JsonConvert.SerializeObject(StripeContext.Parse("acct_A/acct_B"));
            Assert.Equal(@"""acct_A/acct_B""", json);
        }

        [Fact]
        public void STJ_SerializesAsContextString()
        {
            var json = STJ.JsonSerializer.Serialize(StripeContext.Parse("acct_A/acct_B"));
            Assert.Equal(@"""acct_A/acct_B""", json);
        }

        [Fact]
        public void Newtonsoft_RoundTripsSegments()
        {
            var context = StripeContext.Parse("acct_A/acct_B");
            var roundTripped = JsonConvert.DeserializeObject<StripeContext>(JsonConvert.SerializeObject(context));
            Assert.Equal(context, roundTripped);
        }

        [Fact]
        public void STJ_RoundTripsSegments()
        {
            var context = StripeContext.Parse("acct_A/acct_B");
            var roundTripped = STJ.JsonSerializer.Deserialize<StripeContext>(STJ.JsonSerializer.Serialize(context));
            Assert.Equal(context, roundTripped);
        }

        // Matches the implicit string conversion, which maps "" to null.
        [Fact]
        public void Newtonsoft_RoundTripsEmptyContextAsNull()
        {
            var json = JsonConvert.SerializeObject(new StripeContext());
            Assert.Equal("\"\"", json);
            Assert.Null(JsonConvert.DeserializeObject<StripeContext>(json));
        }

        // Matches the implicit string conversion, which maps "" to null.
        [Fact]
        public void STJ_RoundTripsEmptyContextAsNull()
        {
            var json = STJ.JsonSerializer.Serialize(new StripeContext());
            Assert.Equal("\"\"", json);
            Assert.Null(STJ.JsonSerializer.Deserialize<StripeContext>(json));
        }

        [Fact]
        public void Newtonsoft_ReadsEmptyStringAsNull()
        {
            Assert.Null(JsonConvert.DeserializeObject<StripeContext>("\"\""));
        }

        [Fact]
        public void Newtonsoft_ReadsWireContextString()
        {
            var notification = JsonConvert.DeserializeObject<EventNotification>(NotificationPayload);
            Assert.Equal(StripeContext.Parse("acct_A/acct_B"), notification.Context);
        }

        [Fact]
        public void Newtonsoft_ReadsNull()
        {
            Assert.Null(JsonConvert.DeserializeObject<StripeContext>("null"));
        }

        [Fact]
        public void STJ_ReadsNull()
        {
            Assert.Null(STJ.JsonSerializer.Deserialize<StripeContext>("null"));
        }

        // Earlier versions serialized StripeContext as an object, so payloads already sitting in
        // a queue or cache have this shape.
        [Fact]
        public void Newtonsoft_ReadsSegmentsObject()
        {
            var context = JsonConvert.DeserializeObject<StripeContext>(@"{""Segments"":[""acct_A"",""acct_B""]}");
            Assert.Equal(StripeContext.Parse("acct_A/acct_B"), context);
        }

        [Fact]
        public void STJ_ReadsSegmentsObject()
        {
            var context = STJ.JsonSerializer.Deserialize<StripeContext>(@"{""Segments"":[""acct_A"",""acct_B""]}");
            Assert.Equal(StripeContext.Parse("acct_A/acct_B"), context);
        }

        [Fact]
        public void Newtonsoft_RejectsSegmentsObjectWithUnknownProperty()
        {
            Assert.Throws<JsonSerializationException>(() =>
                JsonConvert.DeserializeObject<StripeContext>(@"{""Segments"":[""acct_A""],""Other"":1}"));
        }

        [Fact]
        public void STJ_RejectsSegmentsObjectWithUnknownProperty()
        {
            Assert.Throws<STJ.JsonException>(() =>
                STJ.JsonSerializer.Deserialize<StripeContext>(@"{""Segments"":[""acct_A""],""Other"":1}"));
        }

        [Fact]
        public void Newtonsoft_EventNotificationRoundTripKeepsContext()
        {
            var notification = EventNotification.FromJson(NotificationPayload, new StripeClient("sk_test_123"));
            var json = JsonConvert.SerializeObject(notification);

            Assert.Contains(@"""context"":""acct_A/acct_B""", json);
            var roundTripped = JsonConvert.DeserializeObject<EventNotification>(json);
            Assert.IsType<V1BillingMeterErrorReportTriggeredEventNotification>(roundTripped);
            Assert.Equal(StripeContext.Parse("acct_A/acct_B"), roundTripped.Context);
        }

        [Fact]
        public void STJ_EventNotificationRoundTripKeepsContext()
        {
            var notification = EventNotification.FromJson(NotificationPayload, new StripeClient("sk_test_123"));
            var json = STJ.JsonSerializer.Serialize(notification, notification.GetType());

            Assert.Contains(@"""context"":""acct_A/acct_B""", json);
            var roundTripped = STJ.JsonSerializer.Deserialize<EventNotification>(json);
            Assert.IsType<V1BillingMeterErrorReportTriggeredEventNotification>(roundTripped);
            Assert.Equal(StripeContext.Parse("acct_A/acct_B"), roundTripped.Context);
        }

        [Fact]
        public void STJ_ReadsWireContextString()
        {
            var notification = STJ.JsonSerializer.Deserialize<EventNotification>(NotificationPayload);
            Assert.Equal(StripeContext.Parse("acct_A/acct_B"), notification.Context);
        }
    }
}
