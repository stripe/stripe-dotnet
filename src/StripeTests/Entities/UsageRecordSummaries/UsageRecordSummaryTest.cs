namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class UsageRecordSummaryTest : BaseStripeTest
    {
        public UsageRecordSummaryTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/subscription_items/si_123/usage_record_summaries");
            var summaries = JsonConvert.DeserializeObject<StripeList<UsageRecordSummary>>(json);
            Assert.NotNull(summaries);

            var summary = summaries.Data[0];
            Assert.NotNull(summary);
            Assert.IsType<UsageRecordSummary>(summary);
            Assert.NotNull(summary.Id);
            Assert.Equal("usage_record_summary", summary.Object);
        }
    }
}
