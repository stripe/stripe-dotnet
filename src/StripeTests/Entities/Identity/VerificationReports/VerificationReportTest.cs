namespace StripeTests.Identity
{
    using Newtonsoft.Json;
    using Stripe.Identity;
    using Xunit;

    public class VerificationReportTest : BaseStripeTest
    {
        public VerificationReportTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/identity/verification_reports/vr_123");
            var verificationReport = JsonConvert.DeserializeObject<VerificationReport>(json);
            Assert.NotNull(verificationReport);
            Assert.IsType<VerificationReport>(verificationReport);
            Assert.NotNull(verificationReport.Id);
            Assert.Equal("identity.verification_report", verificationReport.Object);
        }
    }
}
