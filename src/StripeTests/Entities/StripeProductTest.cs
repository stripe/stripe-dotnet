namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeProductTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/products/prod_123");
            var product = Mapper<StripeProduct>.MapFromJson(json);
            Assert.NotNull(product);
            Assert.IsType<StripeProduct>(product);
            Assert.NotNull(product.Id);
            Assert.Equal("product", product.Object);
        }
    }
}
