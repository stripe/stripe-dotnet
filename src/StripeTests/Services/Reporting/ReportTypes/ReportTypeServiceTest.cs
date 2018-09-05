namespace StripeTests.Reporting
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe.Reporting;
    using Xunit;

    public class ReportTypeServiceTest : BaseStripeTest
    {
        private const string ReportTypeId = "activity.summary.1";

        private ReportTypeService service;
        private ReportTypeListOptions listOptions;

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
            Assert.NotNull(reportType);
        }

        [Fact]
        public async Task GetAsync()
        {
            var reportType = await this.service.GetAsync(ReportTypeId);
            Assert.NotNull(reportType);
        }

        [Fact]
        public void List()
        {
            var reportTypes = this.service.List(this.listOptions);
            Assert.NotNull(reportTypes);
        }

        [Fact]
        public async Task ListAsync()
        {
            var reportTypes = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(reportTypes);
        }
    }
}
