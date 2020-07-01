namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class SubscriptionItemServiceTest : BaseStripeTest
    {
        private const string SubscriptionItemId = "si_123";

        private readonly SubscriptionItemService service;
        private readonly SubscriptionItemCreateOptions createOptions;
        private readonly SubscriptionItemDeleteOptions deleteOptions;
        private readonly SubscriptionItemUpdateOptions updateOptions;
        private readonly SubscriptionItemListOptions listOptions;

        public SubscriptionItemServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new SubscriptionItemService(this.StripeClient);

            this.createOptions = new SubscriptionItemCreateOptions
            {
                PriceData = new SubscriptionItemPriceDataOptions
                {
                    Currency = "usd",
                    Product = "prod_123",
                    Recurring = new SubscriptionItemPriceDataRecurringOptions
                    {
                        Interval = "day",
                        IntervalCount = 15,
                    },
                    UnitAmountDecimal = 0.01234567890m, // Ensure decimals work
                },
                Quantity = 1,
                Subscription = "sub_123",
            };

            this.deleteOptions = new SubscriptionItemDeleteOptions
            {
                ClearUsage = true,
            };

            this.updateOptions = new SubscriptionItemUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new SubscriptionItemListOptions
            {
                Limit = 1,
                Subscription = "sub_123",
            };
        }

        [Fact]
        public void Create()
        {
            var subscriptionItem = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_items");
            Assert.NotNull(subscriptionItem);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var subscriptionItem = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_items");
            Assert.NotNull(subscriptionItem);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(SubscriptionItemId, this.deleteOptions);
            this.AssertRequest(HttpMethod.Delete, "/v1/subscription_items/si_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(SubscriptionItemId, this.deleteOptions);
            this.AssertRequest(HttpMethod.Delete, "/v1/subscription_items/si_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var subscriptionItem = this.service.Get(SubscriptionItemId);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_items/si_123");
            Assert.NotNull(subscriptionItem);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var subscriptionItem = await this.service.GetAsync(SubscriptionItemId);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_items/si_123");
            Assert.NotNull(subscriptionItem);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }

        [Fact]
        public void List()
        {
            var subscriptionItems = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_items");
            Assert.NotNull(subscriptionItems);
            Assert.Equal("list", subscriptionItems.Object);
            Assert.Single(subscriptionItems.Data);
            Assert.Equal("subscription_item", subscriptionItems.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var subscriptionItems = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/subscription_items");
            Assert.NotNull(subscriptionItems);
            Assert.Equal("list", subscriptionItems.Object);
            Assert.Single(subscriptionItems.Data);
            Assert.Equal("subscription_item", subscriptionItems.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var subscriptionItem = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(subscriptionItem);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var subscriptionItem = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(subscriptionItem);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }

        [Fact]
        public void Update()
        {
            var subscriptionItem = this.service.Update(SubscriptionItemId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_items/si_123");
            Assert.NotNull(subscriptionItem);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var subscriptionItem = await this.service.UpdateAsync(SubscriptionItemId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscription_items/si_123");
            Assert.NotNull(subscriptionItem);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }
    }
}
