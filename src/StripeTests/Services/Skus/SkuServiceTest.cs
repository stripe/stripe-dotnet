namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class SkuServiceTest : BaseStripeTest
    {
        private const string SkuId = "sku_123";

        private readonly SkuService service;
        private readonly SkuCreateOptions createOptions;
        private readonly SkuUpdateOptions updateOptions;
        private readonly SkuListOptions listOptions;

        public SkuServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new SkuService(this.StripeClient);

            this.createOptions = new SkuCreateOptions
            {
                Attributes = new Dictionary<string, string>
                {
                    { "attr1", "value1" },
                    { "attr2", "value2" },
                },
                Currency = "usd",
                Inventory = new InventoryOptions
                {
                    Quantity = 100,
                    Type = "finite",
                },
                PackageDimensions = new PackageDimensionOptions
                {
                    Height = 100,
                    Length = 100,
                    Weight = 100,
                    Width = 100,
                },
                Price = 1234,
                Product = "prod_123",
            };

            this.updateOptions = new SkuUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new SkuListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var sku = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/skus");
            Assert.NotNull(sku);
            Assert.Equal("sku", sku.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var sku = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/skus");
            Assert.NotNull(sku);
            Assert.Equal("sku", sku.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(SkuId);
            this.AssertRequest(HttpMethod.Delete, "/v1/skus/sku_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(SkuId);
            this.AssertRequest(HttpMethod.Delete, "/v1/skus/sku_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var sku = this.service.Get(SkuId);
            this.AssertRequest(HttpMethod.Get, "/v1/skus/sku_123");
            Assert.NotNull(sku);
            Assert.Equal("sku", sku.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var sku = await this.service.GetAsync(SkuId);
            this.AssertRequest(HttpMethod.Get, "/v1/skus/sku_123");
            Assert.NotNull(sku);
            Assert.Equal("sku", sku.Object);
        }

        [Fact]
        public void List()
        {
            var skus = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/skus");
            Assert.NotNull(skus);
            Assert.Equal("list", skus.Object);
            Assert.Single(skus.Data);
            Assert.Equal("sku", skus.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var skus = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/skus");
            Assert.NotNull(skus);
            Assert.Equal("list", skus.Object);
            Assert.Single(skus.Data);
            Assert.Equal("sku", skus.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var sku = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(sku);
            Assert.Equal("sku", sku.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var sku = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(sku);
            Assert.Equal("sku", sku.Object);
        }

        [Fact]
        public void Update()
        {
            var sku = this.service.Update(SkuId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/skus/sku_123");
            Assert.NotNull(sku);
            Assert.Equal("sku", sku.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var sku = await this.service.UpdateAsync(SkuId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/skus/sku_123");
            Assert.NotNull(sku);
            Assert.Equal("sku", sku.Object);
        }
    }
}
