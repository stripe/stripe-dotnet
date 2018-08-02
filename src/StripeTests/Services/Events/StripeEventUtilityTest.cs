namespace StripeTests
{
    using Stripe;
    using Xunit;

    public class StripeEventUtilityTest : BaseStripeTest
    {
        private int timestamp;
        private string signature;
        private string json;
        private string secret;

        public StripeEventUtilityTest()
        {
            this.timestamp = 1493329224;
            this.secret = "whsec_H68eTX02a4bCbiQOOoSAsIytOvuWZrQC";
            this.signature = $"t={this.timestamp},v1=dca14f723dfa3bf47a310c3d6c3aff8bdb2534263d051dd2613ece097b8bdea4,v0=63f3a72374a733066c4be69ed7f8e5ac85c22c9f0a6a612ab9a025a9e4ee7eef";
            this.json = GetResourceAsString("event_test_signature.json");
        }

        [Fact]
        public void ConstructEvent()
        {
            // A timestamp within the default tolerance of 300 seconds
            int timestamp = this.timestamp + 120;

            var evt = StripeEventUtility.ConstructEvent(this.json, this.signature, this.secret, timestamp);

            Assert.NotNull(evt);
            Assert.Equal("req_FAKE", evt.Request.Id);
            Assert.Equal("placeholder", evt.Request.IdempotencyKey);
            Assert.Equal("acct_CONNECT", evt.Account);
        }

        [Fact]
        public void RejectOutdatedTimestamp()
        {
            // This throws an error because the tolerance is higher than allowed
            var exception = Assert.Throws<StripeException>(() =>
                StripeEventUtility.ConstructEvent(this.json, this.signature, this.secret));

            Assert.Equal("The webhook cannot be processed because the current timestamp is outside of the allowed tolerance.", exception.Message);
        }

        [Fact]
        public void RejectIncorrectSignature()
        {
            // This throws an error because the original JSON message is modified
            var exception = Assert.Throws<StripeException>(() =>
                StripeEventUtility.ConstructEvent(this.json + "this_changes_the_json", this.signature, this.secret));

            Assert.Equal("The signature for the webhook is not present in the Stripe-Signature header.", exception.Message);
        }

        [Fact]
        public void RejectSecretWithUnicode()
        {
            var exception = Assert.Throws<StripeException>(() =>
                StripeEventUtility.ConstructEvent(this.json, this.signature, this.secret + "\ud802"));

            Assert.Equal("The webhook cannot be processed because the signature cannot be safely calculated.", exception.Message);
        }

        [Fact]
        public void RejectMessageWithUnicode()
        {
            var exception = Assert.Throws<StripeException>(() =>
                StripeEventUtility.ConstructEvent(this.json + "\ud802", this.signature, this.secret));

            Assert.Equal("The webhook cannot be processed because the signature cannot be safely calculated.", exception.Message);
        }
    }
}
