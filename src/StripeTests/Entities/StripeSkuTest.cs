namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class SkuTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/skus/sku_123");
            var sku = Mapper<Sku>.MapFromJson(json);
            Assert.NotNull(sku);
            Assert.IsType<Sku>(sku);
            Assert.NotNull(sku.Id);
            Assert.Equal("sku", sku.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "product",
            };

            string json = GetFixture("/v1/skus/sku_123", expansions);
            var sku = Mapper<Sku>.MapFromJson(json);
            Assert.NotNull(sku);
            Assert.IsType<Sku>(sku);
            Assert.NotNull(sku.Id);
            Assert.Equal("sku", sku.Object);

            Assert.NotNull(sku.Product);
            Assert.Equal("product", sku.Product.Object);
        }
    }
}
