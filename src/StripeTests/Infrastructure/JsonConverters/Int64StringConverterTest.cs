namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    using STJS = System.Text.Json.Serialization;

    public class Int64StringConverterTest : BaseStripeTest
    {
        [Fact]
        public void DeserializeString()
        {
            var json = "{\n  \"divide_by\": \"123\"\n}";
            var obj = JsonConvert.DeserializeObject<TestObject>(json);

            Assert.Equal(123L, obj.DivideBy);
        }

        [Fact]
        public void DeserializeInteger()
        {
            var json = "{\n  \"divide_by\": 123\n}";
            var obj = JsonConvert.DeserializeObject<TestObject>(json);

            Assert.Equal(123L, obj.DivideBy);
        }

        [Fact]
        public void SerializeLongAsString()
        {
            var obj = new TestObject
            {
                DivideBy = 123L,
            };

            var expected = "{\n  \"divide_by\": \"123\"\n}";
            Assert.Equal(expected, obj.ToJson().Replace("\r\n", "\n"));
        }

        [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
        private class TestObject : StripeEntity<TestObject>
        {
            [JsonProperty("divide_by")]
            [JsonConverter(typeof(Int64StringConverter))]
            [STJS.JsonPropertyName("divide_by")]
            [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
            internal long DivideBy { get; set; }
        }
    }
}
