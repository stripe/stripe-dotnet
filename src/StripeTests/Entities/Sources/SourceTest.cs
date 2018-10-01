namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class SourceTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/sources/src_123");
            var source = Mapper<Source>.MapFromJson(json);
            Assert.NotNull(source);
            Assert.IsType<Source>(source);
            Assert.NotNull(source.Id);
            Assert.Equal("source", source.Object);
        }
    }
}
