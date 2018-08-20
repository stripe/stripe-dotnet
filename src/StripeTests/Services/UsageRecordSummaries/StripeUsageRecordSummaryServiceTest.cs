namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class StripeUsageRecordSummaryServiceTest : BaseStripeTest
    {
        private StripeUsageRecordSummaryService service;
        private StripeUsageRecordSummaryListOptions listOptions;

        public StripeUsageRecordSummaryServiceTest()
        {
            this.service = new StripeUsageRecordSummaryService();

            this.listOptions = new StripeUsageRecordSummaryListOptions();
        }

        [Fact]
        public void List()
        {
            var summaries = this.service.List("si_123", this.listOptions);
            Assert.NotNull(summaries);
            Assert.Equal("list", summaries.Object);
            Assert.Single(summaries.Data);
            Assert.Equal("usage_record_summary", summaries.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var summaries = await this.service.ListAsync("si_123", this.listOptions);
            Assert.NotNull(summaries);
            Assert.Equal("list", summaries.Object);
            Assert.Single(summaries.Data);
            Assert.Equal("usage_record_summary", summaries.Data[0].Object);
        }
    }
}
