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

        public EventUtilityTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.eventTimestamp = 1533204620;
            this.secret = "webhook_secret";
            this.signature = $"t={this.eventTimestamp},v1=f0bdba6d4eacbd8ad8a3bbadd7248e633ec1477f7899c124c51b39405fa36613,v0=63f3a72374a733066c4be69ed7f8e5ac85c22c9f0a6a612ab9a025a9e4ee7eef";
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

            Assert.Equal("The signature for the webhook is not present in the Stripe-Signature header.", exception.Message);
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
            var json = evt.ToJson();

            evt = EventUtility.ParseEvent(json);
            Assert.Equal(StripeConfiguration.ApiVersion, evt.ApiVersion);
        }

        [Fact]
        public void ThrowsOnApiVersionMismatch()
        {
            var exception = Assert.Throws<StripeException>(() =>
                EventUtility.ParseEvent(this.json));

            Assert.Contains("Received event with API version 2017-05-25", exception.Message);
        }

        [Fact]
        public void CanDisableThrowOnApiVersionMismatch()
        {
            var evt = EventUtility.ParseEvent(this.json, false);
            Assert.Equal("2017-05-25", evt.ApiVersion);
        }
    }
}
