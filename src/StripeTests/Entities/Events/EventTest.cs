namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class EventTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.events.event_plan.json");
            var evt = Mapper<Event>.MapFromJson(json);
            Assert.NotNull(evt);
            Assert.IsType<Event>(evt);
            Assert.NotNull(evt.Id);
            Assert.Equal("event", evt.Object);

            Assert.NotNull(evt.Data);
            Assert.NotNull(evt.Data.Object);
            Assert.IsType<Plan>(evt.Data.Object);
        }

        [Fact]
        public void DeserializePreviousAttributes()
        {
            var json = GetResourceAsString("api_fixtures.events.customer_updated.json");
            var evt = Mapper<Event>.MapFromJson(json);
            Assert.NotNull(evt);
            Assert.IsType<Event>(evt);
            Assert.NotNull(evt.Id);
            Assert.Equal("event", evt.Object);

            Assert.NotNull(evt.Data);
            Assert.NotNull(evt.Data.PreviousAttributes);
            Assert.NotNull(evt.Data.PreviousAttributes.metadata);
            Assert.NotNull(evt.Data.PreviousAttributes.metadata["foo"]);
            Assert.Equal("bar", (string)evt.Data.PreviousAttributes.metadata["foo"]);
        }

        [Fact]
        public void DeserializeWithJsonConvert()
        {
            var json = GetResourceAsString("api_fixtures.events.event_plan.json");
            var evt = JsonConvert.DeserializeObject<Event>(json);
            Assert.NotNull(evt);
            Assert.IsType<Event>(evt);
            Assert.NotNull(evt.Id);
            Assert.Equal("event", evt.Object);

            Assert.NotNull(evt.Data);
            Assert.NotNull(evt.Data.Object);
            Assert.IsType<Plan>(evt.Data.Object);
        }
    }
}
