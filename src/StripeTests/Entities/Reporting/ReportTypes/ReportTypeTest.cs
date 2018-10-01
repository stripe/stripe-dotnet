namespace StripeTests.Reporting
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Reporting;
    using Xunit;

    public class ReportTypeTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/reporting/report_types/activity.summary.1");
            var reportType = Mapper<ReportType>.MapFromJson(json);
            Assert.NotNull(reportType);
            Assert.IsType<ReportType>(reportType);
            Assert.NotNull(reportType.Id);
            Assert.Equal("reporting.report_type", reportType.Object);
        }
    }
}
