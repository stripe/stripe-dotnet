namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class StripeSubscriptionServiceTest : BaseStripeTest
    {
        private const string SubscriptionId = "sub_123";

        private StripeSubscriptionService service;
        private StripeSubscriptionCancelOptions cancelOptions;
        private StripeSubscriptionCreateOptions createOptions;
        private StripeSubscriptionUpdateOptions updateOptions;
        private StripeSubscriptionListOptions listOptions;

        public StripeSubscriptionServiceTest()
        {
            this.service = new StripeSubscriptionService();

            this.cancelOptions = new StripeSubscriptionCancelOptions
            {
            };

            this.createOptions = new StripeSubscriptionCreateOptions()
            {
                CustomerId = "cus_123",
                Items = new List<StripeSubscriptionItemOption>
                {
                    new StripeSubscriptionItemOption
                    {
                        PlanId = "plan_123",
                        Quantity = 2
                    },
                    new StripeSubscriptionItemOption
                    {
                        PlanId = "plan_124",
                        Quantity = 3
                    },
                },
            };

            this.updateOptions = new StripeSubscriptionUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new StripeSubscriptionListOptions()
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
