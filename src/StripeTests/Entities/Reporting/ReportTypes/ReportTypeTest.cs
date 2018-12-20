namespace StripeTests.Reporting
{
    using Newtonsoft.Json;
    using Stripe.Reporting;
    using Xunit;

    public class ReportTypeTest : BaseStripeTest
    {
        public ReportTypeTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/reporting/report_types/activity.summary.1");
            var reportType = JsonConvert.DeserializeObject<ReportType>(json);
            Assert.NotNull(reportType);
            Assert.IsType<ReportType>(reportType);
            Assert.NotNull(reportType.Id);
            Assert.Equal("reporting.report_type", reportType.Object);
        }
    }
}
