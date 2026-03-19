namespace StripeTests
{
    using System;
    using System.Text.Json;
    using Stripe;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class SerializationTest : BaseStripeTest
    {
        [Fact]
        public void RoundtripDatetime()
        {
            var date = DateTime.UtcNow;
            var roundedDate = date.AddTicks(-1 * (date.Ticks % TimeSpan.TicksPerSecond));
            var obj = new TestObjectDateTime
            {
                Date = roundedDate,
            };

            var reloaded = JsonSerializer.Deserialize<TestObjectDateTime>(JsonSerializer.Serialize(obj));
            Assert.Equal(reloaded.Date, obj.Date);
        }

        [Fact]
        public void HandleNull()
        {
            var obj = new TestObjectDateTime
            {
                Date = null,
            };

            var reloaded = JsonSerializer.Deserialize<TestObjectDateTime>(JsonSerializer.Serialize(obj));
            Assert.Null(reloaded.Date);
        }

        [Fact]
        public void Serialize()
        {
            var opts = StripeConfiguration.SerializerOptions;
            var indentedOpts = StripeConfiguration.IndentedSerializerOptions;

            var json = GetResourceAsString("api_fixtures.events.customer_updated.json");
            var evt = JsonSerializer.Deserialize<Event>(json, opts);
            var serialized = JsonSerializer.Serialize(evt, indentedOpts);
            var reserialized = JsonSerializer.Serialize(
                JsonSerializer.Deserialize<Event>(serialized, opts),
                indentedOpts);
            Assert.Equal(serialized, reserialized);

            json = GetResourceAsString("api_fixtures.customer_with_expansions.json");
            var customer = JsonSerializer.Deserialize<Customer>(json, opts);
            serialized = JsonSerializer.Serialize(customer, indentedOpts);
            reserialized = JsonSerializer.Serialize(
                JsonSerializer.Deserialize<Customer>(serialized, opts),
                indentedOpts);
            Assert.Equal(serialized, reserialized);
        }
    }
}
