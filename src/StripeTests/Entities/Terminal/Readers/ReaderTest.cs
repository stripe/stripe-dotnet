namespace StripeTests.Terminal
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Terminal;
    using Xunit;

    public class ReaderTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/terminal/readers/ds_123");
            var reader = Mapper<Reader>.MapFromJson(json);
            Assert.NotNull(reader);
            Assert.IsType<Reader>(reader);
            Assert.NotNull(reader.Id);
            Assert.Equal("terminal.reader", reader.Object);
        }
    }
}
