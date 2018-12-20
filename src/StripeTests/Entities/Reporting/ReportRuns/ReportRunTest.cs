namespace StripeTests.Reporting
{
    using Newtonsoft.Json;
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
            var reportRun = JsonConvert.DeserializeObject<ReportRun>(json);
            Assert.NotNull(reportRun);
            Assert.IsType<ReportRun>(reportRun);
            Assert.NotNull(reportRun.Id);
            Assert.Equal("reporting.report_run", reportRun.Object);
        }
    }
}
