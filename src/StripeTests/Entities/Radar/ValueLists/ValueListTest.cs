namespace StripeTests.Radar
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Radar;
    using Xunit;

    public class ValueListTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/radar/value_lists/rsl_123");
            var valueList = Mapper<ValueList>.MapFromJson(json);
            Assert.NotNull(valueList);
            Assert.IsType<ValueList>(valueList);
            Assert.NotNull(valueList.Id);
            Assert.Equal("radar.value_list", valueList.Object);
        }
    }
}
