namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class EventTest : BaseStripeTest
    {
        public EventTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.events.event_plan.json");
            var evt = JsonConvert.DeserializeObject<Event>(json);
            Assert.NotNull(evt);
            Assert.IsType<Event>(evt);
            Assert.NotNull(evt.Id);
            Assert.Equal("event", evt.Object);
            Assert.Equal("req_123", evt.Request.Id);
            Assert.Equal("key-123", evt.Request.IdempotencyKey);

            Assert.NotNull(evt.Data);

            Assert.NotNull(evt.Data.Object);
            Assert.IsType<Plan>(evt.Data.Object);

            Assert.NotNull(evt.Data.RawObject);
            Assert.Equal("plan", (string)evt.Data.RawObject["object"]);
        }

        [Fact]
        public void DeserializePreviousAttributes()
        {
            var json = GetResourceAsString("api_fixtures.events.customer_updated.json");
            var evt = JsonConvert.DeserializeObject<Event>(json);
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
        public void DeserializeRequestString()
        {
            var json = GetResourceAsString("api_fixtures.events.event_pre_2017-05-25.json");
            var evt = JsonConvert.DeserializeObject<Event>(json);
            Assert.NotNull(evt);
            Assert.IsType<Event>(evt);
            Assert.NotNull(evt.Id);
            Assert.Equal("event", evt.Object);
            Assert.Equal("req_123", evt.Request.Id);
            Assert.Null(evt.Request.IdempotencyKey);
        }

        [Fact]
        public void DeserializeUnknownObject()
        {
            var json = GetResourceAsString("api_fixtures.events.event_unknown_object.json");
            var evt = JsonConvert.DeserializeObject<Event>(json);
            Assert.NotNull(evt);
            Assert.IsType<Event>(evt);
            Assert.NotNull(evt.Id);
            Assert.Equal("event", evt.Object);

            Assert.NotNull(evt.Data);

            Assert.Null(evt.Data.Object);

            Assert.NotNull(evt.Data.RawObject);
            Assert.Equal("foo", (string)evt.Data.RawObject["object"]);
            Assert.Equal("Hello", (string)evt.Data.RawObject["string"]);
            Assert.Equal(42, (long)evt.Data.RawObject["integer"]);
        }
    }
}
