namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class UsageRecordTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.usage_record.json");
            var usageRecord = Mapper<UsageRecord>.MapFromJson(json);

            Assert.NotNull(usageRecord);
            Assert.NotNull(usageRecord.Id);
            Assert.Equal("usage_record", usageRecord.Object);
        }
    }
}
