namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class SubscriptionItemServiceTest : BaseStripeTest
    {
        private const string SubscriptionItemId = "si_123";

        private SubscriptionItemService service;
        private SubscriptionItemCreateOptions createOptions;
        private SubscriptionItemUpdateOptions updateOptions;
        private SubscriptionItemListOptions listOptions;

        public SubscriptionItemServiceTest()
        {
            this.service = new SubscriptionItemService();

            this.createOptions = new SubscriptionItemCreateOptions()
            {
                PlanId = "plan_123",
                Quantity = 1,
                SubscriptionId = "sub_123",
            };

            this.updateOptions = new SubscriptionItemUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new SubscriptionItemListOptions()
            {
                Limit = 1,
                SubscriptionId = "sub_123",
            };
        }

        [Fact]
        public void Create()
        {
            var subscriptionItem = this.service.Create(this.createOptions);
            Assert.NotNull(subscriptionItem);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var subscriptionItem = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(subscriptionItem);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(SubscriptionItemId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(SubscriptionItemId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var subscriptionItem = this.service.Get(SubscriptionItemId);
            Assert.NotNull(subscriptionItem);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var subscriptionItem = await this.service.GetAsync(SubscriptionItemId);
            Assert.NotNull(subscriptionItem);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }

        [Fact]
        public void List()
        {
            var subscriptionItems = this.service.List(this.listOptions);
            Assert.NotNull(subscriptionItems);
            Assert.Equal("list", subscriptionItems.Object);
            Assert.Single(subscriptionItems.Data);
            Assert.Equal("subscription_item", subscriptionItems.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var subscriptionItems = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(subscriptionItems);
            Assert.Equal("list", subscriptionItems.Object);
            Assert.Single(subscriptionItems.Data);
            Assert.Equal("subscription_item", subscriptionItems.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var subscriptionItem = this.service.Update(SubscriptionItemId, this.updateOptions);
            Assert.NotNull(subscriptionItem);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var subscriptionItem = await this.service.UpdateAsync(SubscriptionItemId, this.updateOptions);
            Assert.NotNull(subscriptionItem);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }
    }
}
