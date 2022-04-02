namespace StripeTests
{
    using Stripe;

    using Xunit;

    public class DefaultSignatureValidatorTests : BaseStripeTest
    {
        private const long DefaultTolerance = 300;

        private readonly long eventTimestamp;
        private readonly string signature;
        private readonly string json;
        private readonly string secret;

        public DefaultSignatureValidatorTests()
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
        public void CanValidateWhenAllGood()
        {
            var currentTimestamp = this.eventTimestamp + 100;

            var sut = new DefaultSignatureValidator(this.secret);

            sut.Validate(this.json, this.signature, DefaultTolerance, currentTimestamp);

            Assert.True(true, "Should reach here without error");
        }

        [Fact]
        public void RejectOutdatedTimestamp()
        {
            var fakeCurrentTimestamp = this.eventTimestamp + DefaultTolerance + 100;

            var sut = new DefaultSignatureValidator(this.secret);

            var exception = Assert.Throws<StripeException>(() =>
                sut.Validate(this.json, this.signature, DefaultTolerance, fakeCurrentTimestamp));

            Assert.Equal("The webhook cannot be processed because the current timestamp is outside of the allowed tolerance.", exception.Message);
        }

        [Fact]
        public void RejectIncorrectSignature()
        {
            var sut = new DefaultSignatureValidator(this.secret);

            // This throws an error because the original JSON message is modified
            var exception = Assert.Throws<StripeException>(() =>
                sut.Validate(this.json + "this_changes_the_json", this.signature, DefaultTolerance, this.eventTimestamp));

            Assert.Equal("The signature for the webhook is not present in the Stripe-Signature header.", exception.Message);
        }

        [Fact]
        public void RejectSecretWithUnicode()
        {
            var sut = new DefaultSignatureValidator(this.secret + "\ud802");
            var exception = Assert.Throws<StripeException>(() =>
                sut.Validate(this.json, this.signature, DefaultTolerance, this.eventTimestamp));

            Assert.Equal("The webhook cannot be processed because the signature cannot be safely calculated.", exception.Message);
        }
    }
}