namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class StripeSkuServiceTest : BaseStripeTest
    {
        private const string SkuId = "prod_123";

        private StripeSkuService service;
        private StripeSkuCreateOptions createOptions;
        private StripeSkuUpdateOptions updateOptions;
        private StripeSkuListOptions listOptions;

        public StripeSkuServiceTest()
        {
            this.service = new StripeSkuService();

            this.createOptions = new StripeSkuCreateOptions()
            {
                Attributes = new Dictionary<string, string>
                {
                    { "attr1", "value1" },
                    { "attr2", "value2" },
                },
                Currency = "usd",
                Inventory = new StripeInventoryOptions
                {
                    Quantity = 100,
                    Type = "finite",
                },
                PackageDimensions = new StripePackageDimensionOptions
                {
                    Height = 100,
                    Length = 100,
                    Weight = 100,
                    Width = 100,
                },
                Price = 1234,
                Product = "prod_123",
            };

            this.updateOptions = new StripeSkuUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new StripeSkuListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var sku = this.service.Create(this.createOptions);
            Assert.NotNull(sku);
            Assert.Equal("sku", sku.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var sku = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(sku);
            Assert.Equal("sku", sku.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(SkuId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(SkuId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var sku = this.service.Get(SkuId);
            Assert.NotNull(sku);
            Assert.Equal("sku", sku.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var sku = await this.service.GetAsync(SkuId);
            Assert.NotNull(sku);
            Assert.Equal("sku", sku.Object);
        }

        [Fact]
        public void List()
        {
            var skus = this.service.List(this.listOptions);
            Assert.NotNull(skus);
            Assert.Equal("list", skus.Object);
            Assert.Single(skus.Data);
            Assert.Equal("sku", skus.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var skus = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(skus);
            Assert.Equal("list", skus.Object);
            Assert.Single(skus.Data);
            Assert.Equal("sku", skus.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var sku = this.service.Update(SkuId, this.updateOptions);
            Assert.NotNull(sku);
            Assert.Equal("sku", sku.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var sku = await this.service.UpdateAsync(SkuId, this.updateOptions);
            Assert.NotNull(sku);
            Assert.Equal("sku", sku.Object);
        }
    }
}
