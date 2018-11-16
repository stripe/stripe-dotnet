namespace StripeTests.Sigma
{
    using Newtonsoft.Json;
    using Stripe.Sigma;
    using Xunit;

    public class ScheduledQueryRunTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/sigma/scheduled_query_runs/sqr_123");
            var run = JsonConvert.DeserializeObject<ScheduledQueryRun>(json);
            Assert.NotNull(run);
            Assert.IsType<ScheduledQueryRun>(run);
            Assert.NotNull(run.Id);
            Assert.Equal("scheduled_query_run", run.Object);

            Assert.NotNull(run.File);
            Assert.Equal("file", run.File.Object);
        }
    }
}
