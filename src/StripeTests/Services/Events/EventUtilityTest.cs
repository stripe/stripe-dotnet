namespace StripeTests
{
    using System;
    using System.Text.Json;
    using Stripe;
    using Xunit;

    [Collection(nameof(TestsThatModifyApiVersion))]
    public class EventUtilityTest : BaseStripeTest
    {
        private readonly long eventTimestamp;
        private readonly string signature;
        private readonly string json;
        private readonly string secret;
        private readonly StripeClient stripeClient;

        public EventUtilityTest()
            : base()
        {
            this.stripeClient = this.StripeClient as StripeClient;

            // If you make changes to the JSON fixture you need to re-calculate the signature
            // To do this run the following command:
            //   (echo -n "1533204620." && cat src/StripeTests/Resources/event_test_signature.json) | openssl sha256 -hmac "webhook_secret"
            this.eventTimestamp = 1533204620;
            this.secret = "webhook_secret";
            this.signature = $"t={this.eventTimestamp},v1=2220f87ef101a04665f11cdf770523143f875572008577fa0f20882ddb9cc3c7,v0=63f3a72374a733066c4be69ed7f8e5ac85c22c9f0a6a612ab9a025a9e4ee7eef";
            this.json = GetResourceAsString("event_test_signature.json").Replace("\r\n", "\n");
        }

        [Fact]
        public void ConstructEvent()
        {
            var tolerance = 300;
            var fakeCurrentTimestamp = this.eventTimestamp + 100;
            var evt = EventUtility.ConstructEvent(this.json, this.signature, this.secret, tolerance, fakeCurrentTimestamp, throwOnApiVersionMismatch: false);

            Assert.NotNull(evt);
            Assert.Equal("acct_123", evt.Account);
            Assert.Equal("req_123", evt.Request.Id);
            Assert.Equal("idempotency-key-123", evt.Request.IdempotencyKey);
        }

        [Fact]
        public void RejectOutdatedTimestamp()
        {
            var tolerance = 300;
            var fakeCurrentTimestamp = this.eventTimestamp + tolerance + 100;

            var exception = Assert.Throws<StripeException>(() =>
                EventUtility.ConstructEvent(this.json, this.signature, this.secret, tolerance, fakeCurrentTimestamp));

            Assert.Equal("The webhook cannot be processed because the current timestamp is outside of the allowed tolerance.", exception.Message);
        }

        [Fact]
        public void RejectIncorrectSignature()
        {
            // This throws an error because the original JSON message is modified
            var exception = Assert.Throws<StripeException>(() =>
                EventUtility.ConstructEvent(this.json + "this_changes_the_json", this.signature, this.secret));

            Assert.Equal(
                "The expected signature was not found in the Stripe-Signature header. " +
                "Make sure you're using the correct webhook secret (whsec_) and confirm the incoming request came from Stripe.",
                exception.Message);
        }

        [Fact]
        public void RejectSecretWithUnicode()
        {
            var exception = Assert.Throws<StripeException>(() =>
                EventUtility.ConstructEvent(this.json, this.signature, this.secret + "\ud802"));

            Assert.Equal("The webhook cannot be processed because the signature cannot be safely calculated.", exception.Message);
        }

        [Fact]
        public void RejectMessageWithUnicode()
        {
            var exception = Assert.Throws<StripeException>(() =>
                EventUtility.ConstructEvent(this.json + "\ud802", this.signature, this.secret));

            Assert.Equal("The webhook cannot be processed because the signature cannot be safely calculated.", exception.Message);
        }

        [Fact]
        public void AcceptsExpectedApiVersion()
        {
            var evt = Event.FromJson(this.json);
            evt.ApiVersion = ApiVersion.Current;
            var serialized = evt.ToJson();

            evt = EventUtility.ParseEvent(serialized);
            Assert.Equal(ApiVersion.Current, evt.ApiVersion);
        }

        [Fact]
        public void AcceptsNewApiVersionInExpectedReleaseTrain()
        {
            var evt = Event.FromJson(this.json);
            var expectedReleaseTrain = ApiVersion.Current.Split('.')[1];

            // this test only makes sense on GA versions- the exact version for preview versions doesn't
            // work this way and we can't mock private methods from this test class.
            if (expectedReleaseTrain == "preview")
            {
                return;
            }

            evt.ApiVersion = "2999-10-10." + expectedReleaseTrain;
            var serialized = evt.ToJson();

            evt = EventUtility.ParseEvent(serialized);
            Assert.EndsWith($".{expectedReleaseTrain}", evt.ApiVersion);
        }

        [Fact]
        public void ThrowsOnLegacyApiVersionMismatch()
        {
            var exception = Assert.Throws<StripeException>(() =>
                EventUtility.ParseEvent(this.json));

            Assert.Contains("Received event with API version 2017-05-25", exception.Message);
        }

        [Fact]
        public void ThrowsOnReleaseTrainMismatch()
        {
            var evt = Event.FromJson(this.json);
            evt.ApiVersion = "2999-10-10.the_larch";
            var serialized = evt.ToJson();

            var exception = Assert.Throws<StripeException>(() =>
                EventUtility.ParseEvent(serialized));

            Assert.Contains("Received event with API version 2999-10-10.the_larch", exception.Message);
        }

        [Fact]
        public void CanDisableThrowOnApiVersionMismatch()
        {
            var evt = EventUtility.ParseEvent(this.json, false);
            Assert.Equal("2017-05-25", evt.ApiVersion);
        }

        [Theory]
        [InlineData("t=,v1=2220f87ef101a04665f11cdf770523143f875572008577fa0f20882ddb9cc3c7,v0=63f3a72374a733066c4be69ed7f8e5ac85c22c9f0a6a612ab9a025a9e4ee7eef")]
        [InlineData("t,v1=,v0=")]
        [InlineData("t,v1=,v0")]
        [InlineData("t,v1=,")]
        [InlineData("t,,")]
        [InlineData(",,")]
        [InlineData("t")]
        public void ValidateSignatureHandlesIncorrectHeaderValues(string headerValue)
        {
            Assert.Throws<StripeException>(() =>
                EventUtility.ValidateSignature("{}", headerValue, string.Empty));
        }

        [Fact]
        public void ValidateSignature_ValidSignatureDoesNotThrow()
        {
            var tolerance = 300;
            var fakeCurrentTimestamp = this.eventTimestamp + 100;

            // Should not throw
            EventUtility.ValidateSignature(this.json, this.signature, this.secret, tolerance, fakeCurrentTimestamp);
        }

        [Fact]
        public void ValidateSignature_InvalidSignatureThrows()
        {
            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var header = EventUtility.GenerateSignatureHeader("{}", "correct_secret", timestamp);

            var exception = Assert.Throws<StripeException>(() =>
                EventUtility.ValidateSignature("{}", header, "wrong_secret", EventUtility.DefaultTimeTolerance, timestamp));

            Assert.Equal(
                "The expected signature was not found in the Stripe-Signature header. " +
                "Make sure you're using the correct webhook secret (whsec_) and confirm the incoming request came from Stripe.",
                exception.Message);
        }

        [Fact]
        public void RejectV2PayloadInParseEvent()
        {
            var v2Payload = @"{
                ""id"": ""evt_234"",
                ""object"": ""v2.core.event"",
                ""type"": ""v1.billing.meter.error_report_triggered"",
                ""created"": ""2022-02-15T00:27:45.330Z"",
                ""livemode"": true
            }";

            var exception = Assert.Throws<ArgumentException>(() =>
                EventUtility.ParseEvent(v2Payload, throwOnApiVersionMismatch: false));

            Assert.Contains("EventNotification", exception.Message);
        }

        [Fact]
        public void RejectV2PayloadInConstructEvent()
        {
            var v2Payload = @"{
                ""id"": ""evt_234"",
                ""object"": ""v2.core.event"",
                ""type"": ""v1.billing.meter.error_report_triggered"",
                ""created"": ""2022-02-15T00:27:45.330Z"",
                ""livemode"": true
            }";

            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var sigHeader = EventUtility.GenerateSignatureHeader(v2Payload, this.secret, timestamp);

            var exception = Assert.Throws<ArgumentException>(() =>
                EventUtility.ConstructEvent(v2Payload, sigHeader, this.secret, throwOnApiVersionMismatch: false));

            Assert.Contains("EventNotification", exception.Message);
        }

        [Fact]
        public void GenerateSignatureHeader_ProducesCorrectFormat()
        {
            var payload = "{}";
            var secret = "test_secret";
            var timestamp = 1700000000L;

            var header = EventUtility.GenerateSignatureHeader(payload, secret, timestamp);

            // Format must be t=<timestamp>,v1=<hex>
            Assert.StartsWith($"t={timestamp},v1=", header);
            var parts = header.Split(',');
            Assert.Equal(2, parts.Length);
            var v1Part = parts[1];
            Assert.StartsWith("v1=", v1Part);
            var hex = v1Part.Substring(3);
            Assert.Equal(64, hex.Length);
            Assert.Matches("^[0-9a-f]+$", hex);
        }

        [Fact]
        public void GenerateSignatureHeader_PassesValidateSignature()
        {
            var payload = "{}";
            var secret = "test_secret";
            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            var header = EventUtility.GenerateSignatureHeader(payload, secret, timestamp);

            // ValidateSignature should not throw
            EventUtility.ValidateSignature(payload, header, secret, EventUtility.DefaultTimeTolerance, timestamp);
        }

        [Theory]
        [InlineData("2024-2-31.acacia", "1999-03-31", false)]
        [InlineData("2024-2-31.acacia", "2025-03-31.basil", false)]
        [InlineData("2024-04-31.basil", "2025-03-31.basil", true)]
        [InlineData("2024-01-01.preview", "2025-03-31.basil", false)]
        [InlineData("2024-01-01.preview", "2025-03-31.preview", false)]
        [InlineData("2024-01-01.preview", "2024-01-01.preview", true)]
        public void CompatibleAPIVersions(string sdkApiVersion, string eventApiVersion, bool expected)
        {
            Assert.Equal(EventUtility.IsCompatibleApiVersion(sdkApiVersion, eventApiVersion), expected);
        }

        [Fact]
        public void ConstructEvent_ThrowsOnInvalidJson()
        {
            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var invalidJson = "this is not valid json";
            var sigHeader = EventUtility.GenerateSignatureHeader(invalidJson, this.secret, timestamp);

            Assert.ThrowsAny<Exception>(() =>
                EventUtility.ConstructEvent(invalidJson, sigHeader, this.secret, EventUtility.DefaultTimeTolerance, timestamp, throwOnApiVersionMismatch: false));
        }

        [Fact]
        public void ValidateSignature_MultipleSignatures_AtLeastOneValid_ShouldPass()
        {
            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var payload = "{}";
            var validHeader = EventUtility.GenerateSignatureHeader(payload, this.secret, timestamp);

            // Append an extra v1 signature that is invalid alongside the valid one.
            var multiSigHeader = validHeader + ",v1=deadbeefdeadbeefdeadbeefdeadbeefdeadbeefdeadbeefdeadbeefdeadbeef";

            // Should not throw — at least one v1 signature matches.
            EventUtility.ValidateSignature(payload, multiSigHeader, this.secret, EventUtility.DefaultTimeTolerance, timestamp);
        }

        [Fact]
        public void ValidateSignature_OldTimestampWithLargeTolerance_ShouldPass()
        {
            // Use a timestamp from the past (year 2018).
            var oldTimestamp = 1533204620L;
            var payload = "{}";
            var sigHeader = EventUtility.GenerateSignatureHeader(payload, this.secret, oldTimestamp);

            // Passing a very large tolerance means the age check never triggers.
            EventUtility.ValidateSignature(payload, sigHeader, this.secret, long.MaxValue, DateTimeOffset.UtcNow.ToUnixTimeSeconds());
        }

        [Fact]
        public void ValidateSignature_NoV1Signatures_ShouldThrow()
        {
            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var payload = "{}";

            // Construct a header that only contains a v0 signature — no v1 entries.
            var v0Sig = EventUtility.ComputeSignature(this.secret, timestamp.ToString(), payload);
            var v0OnlyHeader = $"t={timestamp},v0={v0Sig}";

            var exception = Assert.Throws<StripeException>(() =>
                EventUtility.ValidateSignature(payload, v0OnlyHeader, this.secret, EventUtility.DefaultTimeTolerance, timestamp));

            Assert.Equal(
                "The expected signature was not found in the Stripe-Signature header. " +
                "Make sure you're using the correct webhook secret (whsec_) and confirm the incoming request came from Stripe.",
                exception.Message);
        }

        [Fact]
        public void ParseEventNotification_ValidV2Payload_ReturnsNotification()
        {
            var v2Payload = @"{
                ""id"": ""evt_234"",
                ""object"": ""v2.core.event"",
                ""type"": ""v1.billing.meter.error_report_triggered"",
                ""created"": ""2022-02-15T00:27:45.330Z"",
                ""livemode"": true
            }";

            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var sigHeader = EventUtility.GenerateSignatureHeader(v2Payload, this.secret, timestamp);

            var notification = this.stripeClient.ParseEventNotification(
                v2Payload,
                sigHeader,
                this.secret,
                long.MaxValue);

            Assert.NotNull(notification);
            Assert.Equal("evt_234", notification.Id);
            Assert.Equal("v1.billing.meter.error_report_triggered", notification.Type);
            Assert.True(notification.Livemode);
        }

        [Fact]
        public void ParseEventNotification_RejectsV1Payload_SuggestsConstructEvent()
        {
            var v1Payload = @"{
                ""id"": ""evt_123"",
                ""object"": ""event"",
                ""type"": ""customer.created"",
                ""api_version"": ""2017-05-25"",
                ""created"": 1533204620,
                ""livemode"": false
            }";

            var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var sigHeader = EventUtility.GenerateSignatureHeader(v1Payload, this.secret, timestamp);

            var exception = Assert.Throws<ArgumentException>(() =>
                this.stripeClient.ParseEventNotification(
                    v1Payload,
                    sigHeader,
                    this.secret,
                    long.MaxValue));

            Assert.Contains("ConstructEvent", exception.Message);
        }

        [Fact]
        public void ParseEventNotification_BadSignature_Throws()
        {
            var v2Payload = @"{
                ""id"": ""evt_234"",
                ""object"": ""v2.core.event"",
                ""type"": ""v1.billing.meter.error_report_triggered"",
                ""created"": ""2022-02-15T00:27:45.330Z"",
                ""livemode"": true
            }";

            var exception = Assert.Throws<StripeException>(() =>
                this.stripeClient.ParseEventNotification(
                    v2Payload,
                    "t=1234,v1=invalidsignature",
                    this.secret));

            Assert.Equal(
                "The expected signature was not found in the Stripe-Signature header. " +
                "Make sure you're using the correct webhook secret (whsec_) and confirm the incoming request came from Stripe.",
                exception.Message);
        }
    }
}
