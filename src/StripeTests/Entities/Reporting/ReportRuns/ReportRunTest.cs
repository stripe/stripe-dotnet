namespace StripeTests.Reporting
{
    using System.Text.Json;
    using Stripe.Reporting;
    using Xunit;

    public class ReportRunTest : BaseStripeTest
    {
        public ReportRunTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/reporting/report_runs/frr_123");
            var reportRun = JsonSerializer.Deserialize<ReportRun>(json);
            Assert.NotNull(reportRun);
            Assert.IsType<ReportRun>(reportRun);
            Assert.NotNull(reportRun.Id);
            Assert.Equal("reporting.report_run", reportRun.Object);
        }
    }
}
