namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class PriceServiceTest : BaseStripeTest
    {
        private const string PriceId = "price_123";

        private readonly PriceService service;
        private readonly PriceCreateOptions createOptions;
        private readonly PriceCreateOptions createDecimalTierOptions;
        private readonly PriceUpdateOptions updateOptions;
        private readonly PriceListOptions listOptions;

        public PriceServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new PriceService(this.StripeClient);

            this.createOptions = new PriceCreateOptions
            {
                Currency = "usd",
                Nickname = "Price Nickmame",
                ProductData = new PriceProductDataOptions
                {
                    Name = "Product Name",
                },
                Recurring = new PriceRecurringOptions
                {
                    Interval = "day",
                    IntervalCount = 15,
                },
                UnitAmountDecimal = 0.01234567890m, // Ensure decimals work
            };

            this.createDecimalTierOptions = new PriceCreateOptions
            {
                Currency = "usd",
                Nickname = "Price Nickmame",
                ProductData = new PriceProductDataOptions
                {
                    Name = "Product Name",
                },
                Recurring = new PriceRecurringOptions
                {
                    Interval = "day",
                    IntervalCount = 15,
                },
                Tiers = new List<PriceTierOptions>
                {
                    new PriceTierOptions
                    {
                        UnitAmountDecimal = 0.01234567890m,
                        UpTo = 10,
                    },
                    new PriceTierOptions
                    {
                        UnitAmountDecimal = 0.02223m,
                        UpTo = PriceTierUpTo.Inf,
                    },
                },
                TiersMode = "graduated",
            };

            this.updateOptions = new PriceUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new PriceListOptions
            {
                Limit = 1,
                LookupKeys = new List<string>
                {
                    "lookup_1",
                    "lookup_2",
                },
            };
        }

        [Fact]
        public void Create()
        {
            var price = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/prices");
            Assert.NotNull(price);
            Assert.Equal("price", price.Object);
        }

        [Fact]
        public void Create_DecimalTiers()
        {
            var price = this.service.Create(this.createDecimalTierOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/prices");
            Assert.NotNull(price);
            Assert.Equal("price", price.Object);
        }

        [Fact]
        public async Task CreateAsync_DecimalTiers()
        {
            var price = await this.service.CreateAsync(this.createDecimalTierOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/prices");
            Assert.NotNull(price);
            Assert.Equal("price", price.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var price = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/prices");
            Assert.NotNull(price);
            Assert.Equal("price", price.Object);
        }

        [Fact]
        public void Get()
        {
            var price = this.service.Get(PriceId);
            this.AssertRequest(HttpMethod.Get, "/v1/prices/price_123");
            Assert.NotNull(price);
            Assert.Equal("price", price.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var price = await this.service.GetAsync(PriceId);
            this.AssertRequest(HttpMethod.Get, "/v1/prices/price_123");
            Assert.NotNull(price);
            Assert.Equal("price", price.Object);
        }

        [Fact]
        public void List()
        {
            var prices = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/prices");
            Assert.NotNull(prices);
            Assert.Equal("list", prices.Object);
            Assert.Single(prices.Data);
            Assert.Equal("price", prices.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var prices = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/prices");
            Assert.NotNull(prices);
            Assert.Equal("list", prices.Object);
            Assert.Single(prices.Data);
            Assert.Equal("price", prices.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var price = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(price);
            Assert.Equal("price", price.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var price = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(price);
            Assert.Equal("price", price.Object);
        }

        [Fact]
        public void Update()
        {
            var price = this.service.Update(PriceId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/prices/price_123");
            Assert.NotNull(price);
            Assert.Equal("price", price.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var price = await this.service.UpdateAsync(PriceId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/prices/price_123");
            Assert.NotNull(price);
            Assert.Equal("price", price.Object);
        }
    }
}
