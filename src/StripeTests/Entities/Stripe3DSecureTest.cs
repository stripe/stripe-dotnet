namespace StripeTests
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class Stripe3DSecureTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/3d_secure/tdsrc_123");
            var resource = Mapper<Stripe3DSecure>.MapFromJson(json);
            Assert.NotNull(resource);
            Assert.IsType<Stripe3DSecure>(resource);
            Assert.NotNull(resource.Id);
            Assert.Equal("three_d_secure", resource.Object);
        }
    }
}
