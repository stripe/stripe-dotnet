namespace StripeTests.Infrastructure.JsonConverters
{
    using System;
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class UnixDateTimeConverterTest
    {
        [Fact]
        public void Deserialize_UnixEpochSeconds()
        {
            var json = @"{ ""created-date"": 1625097600 }"; // Represents July 1, 2021
            var obj = JsonConvert.DeserializeObject<TestObject>(json);
            Assert.Equal(new DateTime(2021, 7, 1, 0, 0, 0, DateTimeKind.Utc), obj.CreatedDate);
        }

        [Fact]
        public void Deserialize_UnixEpochMilliSeconds()
        {
            var json = @"{ ""created-date"": 1625097600000 }"; // Represents July 1, 2021
            var obj = JsonConvert.DeserializeObject<TestObject>(json);
            Assert.Equal(new DateTime(2021, 7, 1, 0, 0, 0, DateTimeKind.Utc), obj.CreatedDate);
        }

        private class TestObject : StripeEntity<TestObject>
        {
            [JsonProperty("created-date")]
            [JsonConverter(typeof(UnixDateTimeConverter))]
            internal DateTime CreatedDate { get; set; }
        }
    }
}
