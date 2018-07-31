namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeScheduledQueryRunTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/sigma/scheduled_query_runs/sqr_123");
            var run = Mapper<StripeScheduledQueryRun>.MapFromJson(json);
            Assert.NotNull(run);
            Assert.IsType<StripeScheduledQueryRun>(run);
            Assert.NotNull(run.Id);
            Assert.Equal("scheduled_query_run", run.Object);

            Assert.NotNull(run.File);
            Assert.Equal("file", run.File.Object);
        }
    }
}
