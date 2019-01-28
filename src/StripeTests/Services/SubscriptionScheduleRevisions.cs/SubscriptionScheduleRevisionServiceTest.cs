namespace StripeTests
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class SubscriptionScheduleRevisionServiceTest : BaseStripeTest
    {
        private const string ScheduleId = "sub_sched_123";
        private const string RevisionId = "sub_sched_rev_123";

        private readonly SubscriptionScheduleRevisionService service;
        private readonly SubscriptionScheduleRevisionListOptions listOptions;

        public SubscriptionScheduleRevisionServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new SubscriptionScheduleRevisionService();

            this.listOptions = new SubscriptionScheduleRevisionListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Get()
        {
            var revision = this.service.Get(ScheduleId, RevisionId);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_schedules/sub_sched_123/revisions/sub_sched_rev_123");
            Assert.NotNull(revision);
            Assert.Equal("subscription_schedule_revision", revision.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var revision = await this.service.GetAsync(ScheduleId, RevisionId);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_schedules/sub_sched_123/revisions/sub_sched_rev_123");
            Assert.NotNull(revision);
            Assert.Equal("subscription_schedule_revision", revision.Object);
        }

        [Fact]
        public void List()
        {
            var revisions = this.service.List(ScheduleId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_schedules/sub_sched_123/revisions");
            Assert.NotNull(revisions);
            Assert.Equal("list", revisions.Object);
            Assert.Single(revisions.Data);
            Assert.Equal("subscription_schedule_revision", revisions.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var revisions = await this.service.ListAsync(ScheduleId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_schedules/sub_sched_123/revisions");
            Assert.NotNull(revisions);
            Assert.Equal("list", revisions.Object);
            Assert.Single(revisions.Data);
            Assert.Equal("subscription_schedule_revision", revisions.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var revisions = this.service.ListAutoPaging(ScheduleId, this.listOptions).ToList();
            Assert.NotNull(revisions);
            Assert.Equal("subscription_schedule_revision", revisions[0].Object);
        }
    }
}
