namespace StripeTests.Reporting
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Reporting;
    using Xunit;

    public class ReportRunTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/reporting/report_runs/frr_123");
            var reportRun = Mapper<ReportRun>.MapFromJson(json);
            Assert.NotNull(reportRun);
            Assert.IsType<ReportRun>(reportRun);
            Assert.NotNull(reportRun.Id);
            Assert.Equal("reporting.report_run", reportRun.Object);
        }
    }
}
