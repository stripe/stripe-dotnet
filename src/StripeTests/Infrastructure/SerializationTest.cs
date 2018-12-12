namespace StripeTests
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Stripe.Infrastructure;
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

            var reloaded = JsonConvert.DeserializeObject<TestObjectDateTime>(JsonConvert.SerializeObject(obj));
            Assert.Equal(reloaded.Date, obj.Date);
        }

        [Fact]
        public void HandleNull()
        {
            var obj = new TestObjectDateTime
            {
                Date = null
            };

            var reloaded = JsonConvert.DeserializeObject<TestObjectDateTime>(JsonConvert.SerializeObject(obj));
            Assert.Null(reloaded.Date);
        }
    }
}
