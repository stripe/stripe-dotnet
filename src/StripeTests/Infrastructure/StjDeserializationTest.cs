#if NET6_0_OR_GREATER
namespace StripeTests
{
    using System;
    using System.Text.Json;
    using System.Xml;
    using Stripe;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class StjDeserializationTest : BaseStripeTest
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

        [Fact(Skip="System.Text.JSON Deserialization does not work correctly currently for handling non-nullable null values")]
        public void Serialize()
        {
            var json = GetResourceAsString("api_fixtures.customer_with_expansions.json");
            var customer = JsonSerializer.Deserialize<Customer>(json);
            var serialized = JsonSerializer.Serialize(customer);
            var reserialized = JsonSerializer.Serialize(
                JsonSerializer.Deserialize<Customer>(serialized));
            Assert.Equal(serialized, reserialized);
        }
    }
}
#endif