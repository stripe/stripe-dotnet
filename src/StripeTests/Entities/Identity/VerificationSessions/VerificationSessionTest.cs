namespace StripeTests.Identity
{
    using Newtonsoft.Json;
    using Stripe.Identity;
    using Xunit;

    public class VerificationSessionTest : BaseStripeTest
    {
        public VerificationSessionTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/identity/verification_sessions/vs_123");
            var verificationSession = JsonConvert.DeserializeObject<VerificationSession>(json);
            Assert.NotNull(verificationSession);
            Assert.IsType<VerificationSession>(verificationSession);
            Assert.NotNull(verificationSession.Id);
            Assert.Equal("identity.verification_session", verificationSession.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "cardholder",
            };

            string json = this.GetFixture("/v1/identity/verification_sessions/vs_123", expansions);
            var verificationSession = JsonConvert.DeserializeObject<VerificationSession>(json);
            Assert.NotNull(verificationSession);
            Assert.IsType<VerificationSession>(verificationSession);
            Assert.NotNull(verificationSession.Id);
            Assert.Equal("identity.verification_session", verificationSession.Object);
        }
    }
}
