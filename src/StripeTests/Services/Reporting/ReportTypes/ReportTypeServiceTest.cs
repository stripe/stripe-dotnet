namespace StripeTests.Reporting
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe.Reporting;
    using Xunit;

    public class ReportTypeServiceTest : BaseStripeTest
    {
        private const string ReportTypeId = "activity.summary.1";

        private readonly ReportTypeService service;
        private readonly ReportTypeListOptions listOptions;

        public ReportTypeServiceTest()
        {
            this.service = new ReportTypeService();

            this.listOptions = new ReportTypeListOptions
            {
            };
        }

        [Fact]
        public void Get()
        {
            var reportType = this.service.Get(ReportTypeId);
            this.AssertRequest(HttpMethod.Get, "/v1/reporting/report_types/activity.summary.1");
            Assert.NotNull(reportType);
        }

        [Fact]
        public async Task GetAsync()
        {
            var reportType = await this.service.GetAsync(ReportTypeId);
            this.AssertRequest(HttpMethod.Get, "/v1/reporting/report_types/activity.summary.1");
            Assert.NotNull(reportType);
        }

        [Fact]
        public void List()
        {
            var reportTypes = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/reporting/report_types");
            Assert.NotNull(reportTypes);
        }

        [Fact]
        public async Task ListAsync()
        {
            var reportTypes = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/reporting/report_types");
            Assert.NotNull(reportTypes);
        }
    }
}
