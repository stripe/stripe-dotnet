namespace StripeTests.Identity
{
    using System.Text.Json;
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
            var verificationReport = JsonSerializer.Deserialize<VerificationReport>(json);
            Assert.NotNull(verificationReport);
            Assert.IsType<VerificationReport>(verificationReport);
            Assert.NotNull(verificationReport.Id);
            Assert.Equal("identity.verification_report", verificationReport.Object);
        }
    }
}
