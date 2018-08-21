namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class ProductTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/products/prod_123");
            var product = Mapper<Product>.MapFromJson(json);
            Assert.NotNull(product);
            Assert.IsType<Product>(product);
            Assert.NotNull(product.Id);
            Assert.Equal("product", product.Object);
        }
    }
}
