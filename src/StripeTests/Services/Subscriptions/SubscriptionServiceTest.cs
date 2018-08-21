namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class SubscriptionServiceTest : BaseStripeTest
    {
        private const string SubscriptionId = "sub_123";

        private SubscriptionService service;
        private SubscriptionCancelOptions cancelOptions;
        private SubscriptionCreateOptions createOptions;
        private SubscriptionUpdateOptions updateOptions;
        private SubscriptionListOptions listOptions;

        public SubscriptionServiceTest()
        {
            this.service = new SubscriptionService();

            this.cancelOptions = new SubscriptionCancelOptions
            {
            };

            this.createOptions = new SubscriptionCreateOptions()
            {
                CustomerId = "cus_123",
                Items = new List<SubscriptionItemOption>
                {
                    new SubscriptionItemOption
                    {
                        PlanId = "plan_123",
                        Quantity = 2
                    },
                    new SubscriptionItemOption
                    {
                        PlanId = "plan_124",
                        Quantity = 3
                    },
                },
            };

            this.updateOptions = new SubscriptionUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new SubscriptionListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Cancel()
        {
            var subscription = this.service.Cancel(SubscriptionId, this.cancelOptions);
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public async Task CancelAsync()
        {
            var subscription = await this.service.CancelAsync(SubscriptionId, this.cancelOptions);
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public void Create()
        {
            var subscription = this.service.Create(this.createOptions);
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var subscription = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public void Get()
        {
            var subscription = this.service.Get(SubscriptionId);
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var subscription = await this.service.GetAsync(SubscriptionId);
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public void List()
        {
            var subscriptions = this.service.List(this.listOptions);
            Assert.NotNull(subscriptions);
            Assert.Equal("list", subscriptions.Object);
            Assert.Single(subscriptions.Data);
            Assert.Equal("subscription", subscriptions.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var subscriptions = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(subscriptions);
            Assert.Equal("list", subscriptions.Object);
            Assert.Single(subscriptions.Data);
            Assert.Equal("subscription", subscriptions.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var subscription = this.service.Update(SubscriptionId, this.updateOptions);
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var subscription = await this.service.UpdateAsync(SubscriptionId, this.updateOptions);
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }
    }
}
