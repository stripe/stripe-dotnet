namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class StringInt64ConverterTest : BaseStripeTest
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

        private class TestObject : StripeEntity<TestObject>
        {
            [JsonProperty("divide_by")]
            [JsonConverter(typeof(StringInt64Converter))]
            internal long DivideBy { get; set; }
        }
    }
}
