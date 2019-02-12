namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class SubscriptionScheduleRevisionTest : BaseStripeTest
    {
        public SubscriptionScheduleRevisionTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/subscription_schedules/sub_sched_123/revisions/sub_sched_rev_123");
            var scheduleRevision = JsonConvert.DeserializeObject<SubscriptionScheduleRevision>(json);
            Assert.NotNull(scheduleRevision);
            Assert.IsType<SubscriptionScheduleRevision>(scheduleRevision);
            Assert.NotNull(scheduleRevision.Id);
            Assert.Equal("subscription_schedule_revision", scheduleRevision.Object);
        }
    }
}
