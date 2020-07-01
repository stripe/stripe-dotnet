namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class SubscriptionScheduleServiceTest : BaseStripeTest
    {
        private const string ScheduleId = "sub_sched_123";

        private readonly SubscriptionScheduleService service;
        private readonly SubscriptionScheduleCancelOptions cancelOptions;
        private readonly SubscriptionScheduleCreateOptions createOptions;
        private readonly SubscriptionScheduleListOptions listOptions;
        private readonly SubscriptionScheduleReleaseOptions releaseOptions;
        private readonly SubscriptionScheduleUpdateOptions updateOptions;

        public SubscriptionScheduleServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new SubscriptionScheduleService(this.StripeClient);

            this.cancelOptions = new SubscriptionScheduleCancelOptions
            {
                InvoiceNow = true,
                Prorate = true,
            };

            this.createOptions = new SubscriptionScheduleCreateOptions
            {
                Customer = "cus_123",
                StartDate = SubscriptionScheduleStartDate.Now,
            };

            this.releaseOptions = new SubscriptionScheduleReleaseOptions
            {
                PreserveCancelDate = true,
            };

            this.updateOptions = new SubscriptionScheduleUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new SubscriptionScheduleListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Cancel()
        {
            var subscription = this.service.Cancel(ScheduleId, this.cancelOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_schedules/sub_sched_123/cancel");
            Assert.NotNull(subscription);
            Assert.Equal("subscription_schedule", subscription.Object);
        }

        [Fact]
        public async Task CancelAsync()
        {
            var subscription = await this.service.CancelAsync(ScheduleId, this.cancelOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_schedules/sub_sched_123/cancel");
            Assert.NotNull(subscription);
            Assert.Equal("subscription_schedule", subscription.Object);
        }

        [Fact]
        public void Create()
        {
            var subscription = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_schedules");
            Assert.NotNull(subscription);
            Assert.Equal("subscription_schedule", subscription.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var subscription = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_schedules");
            Assert.NotNull(subscription);
            Assert.Equal("subscription_schedule", subscription.Object);
        }

        [Fact]
        public void Get()
        {
            var subscription = this.service.Get(ScheduleId);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_schedules/sub_sched_123");
            Assert.NotNull(subscription);
            Assert.Equal("subscription_schedule", subscription.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var subscription = await this.service.GetAsync(ScheduleId);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_schedules/sub_sched_123");
            Assert.NotNull(subscription);
            Assert.Equal("subscription_schedule", subscription.Object);
        }

        [Fact]
        public void List()
        {
            var subscriptions = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_schedules");
            Assert.NotNull(subscriptions);
            Assert.Equal("list", subscriptions.Object);
            Assert.Single(subscriptions.Data);
            Assert.Equal("subscription_schedule", subscriptions.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var subscriptions = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_schedules");
            Assert.NotNull(subscriptions);
            Assert.Equal("list", subscriptions.Object);
            Assert.Single(subscriptions.Data);
            Assert.Equal("subscription_schedule", subscriptions.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var subscription = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(subscription);
            Assert.Equal("subscription_schedule", subscription.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var subscription = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(subscription);
            Assert.Equal("subscription_schedule", subscription.Object);
        }

        [Fact]
        public void Release()
        {
            var subscription = this.service.Release(ScheduleId, this.releaseOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_schedules/sub_sched_123/release");
            Assert.NotNull(subscription);
            Assert.Equal("subscription_schedule", subscription.Object);
        }

        [Fact]
        public async Task ReleaseAsync()
        {
            var subscription = await this.service.ReleaseAsync(ScheduleId, this.releaseOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_schedules/sub_sched_123/release");
            Assert.NotNull(subscription);
            Assert.Equal("subscription_schedule", subscription.Object);
        }

        [Fact]
        public void Update()
        {
            var subscription = this.service.Update(ScheduleId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_schedules/sub_sched_123");
            Assert.NotNull(subscription);
            Assert.Equal("subscription_schedule", subscription.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var subscription = await this.service.UpdateAsync(ScheduleId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_schedules/sub_sched_123");
            Assert.NotNull(subscription);
            Assert.Equal("subscription_schedule", subscription.Object);
        }
    }
}
