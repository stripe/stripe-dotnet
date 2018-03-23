using System;
using FluentAssertions;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class datetime_json_converter
    {
        [Fact]
        public void should_roundtrip_datetimes()
        {
            var obj = new TestObject
            {
                Date = RoundedDate()
            };

            var reloaded = JsonConvert.DeserializeObject<TestObject>(JsonConvert.SerializeObject(obj));
            reloaded.Date.Should().Be(obj.Date);
        }

        [Fact]
        public void should_handle_null()
        {
            var obj = new TestObject
            {
                Date = null
            };

            var reloaded = JsonConvert.DeserializeObject<TestObject>(JsonConvert.SerializeObject(obj));
            reloaded.Date.Should().BeNull();
        }

        private static DateTime RoundedDate()
        {
            var date = DateTime.UtcNow;

            return date.AddTicks( -1 * (date.Ticks % TimeSpan.TicksPerSecond));
        }

        public class TestObject
        {
            [JsonConverter(typeof(StripeDateTimeConverter))]
            public DateTime? Date { get; set; }
        }
    }
}