namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class ProductServiceTest : BaseStripeTest
    {
        private const string ProductId = "prod_123";

        private readonly ProductService service;
        private readonly ProductCreateOptions createOptions;
        private readonly ProductUpdateOptions updateOptions;
        private readonly ProductListOptions listOptions;

        public ProductServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new ProductService(this.StripeClient);

            this.createOptions = new ProductCreateOptions
            {
                Attributes = new List<string>
                {
                    "attr1",
                    "attr2",
                },
                Name = "product name",
                PackageDimensions = new PackageDimensionOptions
                {
                    Height = 100,
                    Length = 100,
                    Weight = 100,
                    Width = 100,
                },
                Type = "good",
            };

            this.updateOptions = new ProductUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new ProductListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var product = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/products");
            Assert.NotNull(product);
            Assert.Equal("product", product.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var product = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/products");
            Assert.NotNull(product);
            Assert.Equal("product", product.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(ProductId);
            this.AssertRequest(HttpMethod.Delete, "/v1/products/prod_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(ProductId);
            this.AssertRequest(HttpMethod.Delete, "/v1/products/prod_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var product = this.service.Get(ProductId);
            this.AssertRequest(HttpMethod.Get, "/v1/products/prod_123");
            Assert.NotNull(product);
            Assert.Equal("product", product.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var product = await this.service.GetAsync(ProductId);
            this.AssertRequest(HttpMethod.Get, "/v1/products/prod_123");
            Assert.NotNull(product);
            Assert.Equal("product", product.Object);
        }

        [Fact]
        public void List()
        {
            var products = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/products");
            Assert.NotNull(products);
            Assert.Equal("list", products.Object);
            Assert.Single(products.Data);
            Assert.Equal("product", products.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var products = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/products");
            Assert.NotNull(products);
            Assert.Equal("list", products.Object);
            Assert.Single(products.Data);
            Assert.Equal("product", products.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var product = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(product);
            Assert.Equal("product", product.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var product = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(product);
            Assert.Equal("product", product.Object);
        }

        [Fact]
        public void Update()
        {
            var product = this.service.Update(ProductId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/products/prod_123");
            Assert.NotNull(product);
            Assert.Equal("product", product.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var product = await this.service.UpdateAsync(ProductId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/products/prod_123");
            Assert.NotNull(product);
            Assert.Equal("product", product.Object);
        }
    }
}
