namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class SubscriptionServiceTest : BaseStripeTest
    {
        private const string SubscriptionId = "sub_123";

        private readonly SubscriptionService service;
        private readonly SubscriptionCancelOptions cancelOptions;
        private readonly SubscriptionCreateOptions createOptions;
        private readonly SubscriptionUpdateOptions updateOptions;
        private readonly SubscriptionListOptions listOptions;

        public SubscriptionServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new SubscriptionService(this.StripeClient);

            this.cancelOptions = new SubscriptionCancelOptions
            {
                InvoiceNow = true,
                Prorate = true,
            };

            this.createOptions = new SubscriptionCreateOptions
            {
                Customer = "cus_123",
                Items = new List<SubscriptionItemOptions>
                {
                    new SubscriptionItemOptions
                    {
                        Price = "price_123",
                        Quantity = 2,
                    },
                    new SubscriptionItemOptions
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
                        Quantity = 3,
                    },
                },
            };

            this.updateOptions = new SubscriptionUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new SubscriptionListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Cancel()
        {
            var subscription = this.service.Cancel(SubscriptionId, this.cancelOptions);
            this.AssertRequest(HttpMethod.Delete, "/v1/subscriptions/sub_123");
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public async Task CancelAsync()
        {
            var subscription = await this.service.CancelAsync(SubscriptionId, this.cancelOptions);
            this.AssertRequest(HttpMethod.Delete, "/v1/subscriptions/sub_123");
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public void Create()
        {
            var subscription = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscriptions");
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var subscription = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscriptions");
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public void Get()
        {
            var subscription = this.service.Get(SubscriptionId);
            this.AssertRequest(HttpMethod.Get, "/v1/subscriptions/sub_123");
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var subscription = await this.service.GetAsync(SubscriptionId);
            this.AssertRequest(HttpMethod.Get, "/v1/subscriptions/sub_123");
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public void List()
        {
            var subscriptions = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/subscriptions");
            Assert.NotNull(subscriptions);
            Assert.Equal("list", subscriptions.Object);
            Assert.Single(subscriptions.Data);
            Assert.Equal("subscription", subscriptions.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var subscriptions = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/subscriptions");
            Assert.NotNull(subscriptions);
            Assert.Equal("list", subscriptions.Object);
            Assert.Single(subscriptions.Data);
            Assert.Equal("subscription", subscriptions.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var subscription = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var subscription = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public void Update()
        {
            var subscription = this.service.Update(SubscriptionId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscriptions/sub_123");
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var subscription = await this.service.UpdateAsync(SubscriptionId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/subscriptions/sub_123");
            Assert.NotNull(subscription);
            Assert.Equal("subscription", subscription.Object);
        }
    }
}
