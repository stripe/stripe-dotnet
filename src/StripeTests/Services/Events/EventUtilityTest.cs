namespace StripeTests
{
    using Stripe;
    using Xunit;

    public class EventUtilityTest : BaseStripeTest
    {
        private readonly long eventTimestamp;
        private readonly string signature;
        private readonly string json;
        private readonly string secret;

        public EventUtilityTest()
            : base()
        {
            // If you make changes to the JSON fixture you need to re-calculate the signature
            // To do this run the following command:
            //   (echo -n "1533204620." && cat src/StripeTests/Resources/event_test_signature.json) | openssl sha256 -hmac "webhook_secret"
            this.eventTimestamp = 1533204620;
            this.secret = "webhook_secret";
            this.signature = $"t={this.eventTimestamp},v1=2220f87ef101a04665f11cdf770523143f875572008577fa0f20882ddb9cc3c7,v0=63f3a72374a733066c4be69ed7f8e5ac85c22c9f0a6a612ab9a025a9e4ee7eef";
            this.json = GetResourceAsString("event_test_signature.json");
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
            evt.ApiVersion = StripeConfiguration.ApiVersion;
            var serialized = evt.ToJson();

            evt = EventUtility.ParseEvent(serialized);
            Assert.Equal(StripeConfiguration.ApiVersion, evt.ApiVersion);
        }

        [Fact]
        public void AcceptsNewApiVersionInExpectedReleaseTrain()
        {
            var evt = Event.FromJson(this.json);
            var expectedReleaseTrain = StripeConfiguration.ApiVersion.Split('.')[1];

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
    }
}
