namespace StripeTests.Identity
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe.Identity;
    using Xunit;

    public class VerificationReportServiceTest : BaseStripeTest
    {
        private const string VerificationReportId = "vr_123";

        private readonly VerificationReportService service;
        private readonly VerificationReportListOptions listOptions;

        public VerificationReportServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new VerificationReportService(this.StripeClient);

            this.listOptions = new VerificationReportListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Get()
        {
            var verificationReport = this.service.Get(VerificationReportId);
            this.AssertRequest(HttpMethod.Get, "/v1/identity/verification_reports/vr_123");
            Assert.NotNull(verificationReport);
        }

        [Fact]
        public async Task GetAsync()
        {
            var verificationReport = await this.service.GetAsync(VerificationReportId);
            this.AssertRequest(HttpMethod.Get, "/v1/identity/verification_reports/vr_123");
            Assert.NotNull(verificationReport);
        }

        [Fact]
        public void List()
        {
            var verificationReports = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/identity/verification_reports");
            Assert.NotNull(verificationReports);
        }

        [Fact]
        public async Task ListAsync()
        {
            var verificationReports = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/identity/verification_reports");
            Assert.NotNull(verificationReports);
        }
    }
}
