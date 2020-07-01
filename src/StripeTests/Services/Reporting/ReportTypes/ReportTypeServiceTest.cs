namespace StripeTests.Reporting
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe.Reporting;
    using Xunit;

    public class ReportTypeServiceTest : BaseStripeTest
    {
        private const string ReportTypeId = "activity.summary.1";

        private readonly ReportTypeService service;
        private readonly ReportTypeListOptions listOptions;

        public ReportTypeServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new ReportTypeService(this.StripeClient);

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

        [Fact]
        public void ListAutoPaging()
        {
            var reportType = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(reportType);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var reportType = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(reportType);
        }
    }
}
