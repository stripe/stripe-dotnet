namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class UsageRecordSummaryServiceTest : BaseStripeTest
    {
        private readonly UsageRecordSummaryService service;
        private readonly UsageRecordSummaryListOptions listOptions;

        public UsageRecordSummaryServiceTest()
        {
            this.service = new UsageRecordSummaryService();

            this.listOptions = new UsageRecordSummaryListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void List()
        {
            var summaries = this.service.List("si_123", this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_items/si_123/usage_record_summaries");
            Assert.NotNull(summaries);
            Assert.Equal("list", summaries.Object);
            Assert.Single(summaries.Data);
            Assert.Equal("usage_record_summary", summaries.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var summaries = await this.service.ListAsync("si_123", this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_items/si_123/usage_record_summaries");
            Assert.NotNull(summaries);
            Assert.Equal("list", summaries.Object);
            Assert.Single(summaries.Data);
            Assert.Equal("usage_record_summary", summaries.Data[0].Object);
        }
    }
}
