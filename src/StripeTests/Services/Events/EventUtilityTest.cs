namespace StripeTests
{
    using Stripe;

    using Xunit;

    public class EventUtilityTest : BaseStripeTest
    {
        private const long DefaultTolerance = 300;
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
            this.json = GetResourceAsString("event_test_signature.json");

            var computedHash = DefaultSignatureValidator.ComputeSignature(this.secret, this.eventTimestamp.ToString(), this.json);

            this.signature = $"t={this.eventTimestamp},v1={computedHash},v0=63f3a72374a733066c4be69ed7f8e5ac85c22c9f0a6a612ab9a025a9e4ee7eef";
        }

        [Fact]
        public void ConstructEvent()
        {
            var fakeCurrentTimestamp = this.eventTimestamp + 100;
            var evt = EventUtility.ConstructEvent(this.json, this.signature, this.secret, DefaultTolerance, fakeCurrentTimestamp, false);

            Assert.NotNull(evt);
            Assert.Equal("acct_123", evt.Account);
            Assert.Equal("req_123", evt.Request.Id);
            Assert.Equal("idempotency-key-123", evt.Request.IdempotencyKey);
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
