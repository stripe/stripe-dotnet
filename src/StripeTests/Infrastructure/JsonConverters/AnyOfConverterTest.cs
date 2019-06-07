namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class AnyOfConverterTest : BaseStripeTest
    {
        [Fact]
        public void DeserializeFirstType()
        {
            var json = "{\n  \"any_of\": \"String!\"\n}";
            var obj = JsonConvert.DeserializeObject<TestObject>(json);

            Assert.NotNull(obj.AnyOf);
            Assert.Equal("String!", obj.AnyOf);
        }

        [Fact]
        public void DeserializeSecondType()
        {
            var json = "{\n  \"any_of\": {\n    \"id\": \"id_123\",\n    \"bar\": 42\n  }\n}";
            var obj = JsonConvert.DeserializeObject<TestObject>(json);

            Assert.NotNull(obj.AnyOf);
            Assert.Equal("id_123", ((TestSubObject)obj.AnyOf).Id);
            Assert.Equal(42, ((TestSubObject)obj.AnyOf).Bar);
        }

        [Fact]
        public void DeserializeNull()
        {
            var json = "{\n  \"any_of\": null\n}";
            var obj = JsonConvert.DeserializeObject<TestObject>(json);

            Assert.Null(obj.AnyOf);
        }

        [Fact]
        public void DeserializeUnexpectedType()
        {
            var json = "{\n  \"any_of\": []\n}";

            var exception = Assert.Throws<JsonSerializationException>(() =>
                JsonConvert.DeserializeObject<TestObject>(json));

            Assert.Contains(
                "Cannot deserialize the current JSON object into any of the expected types",
                exception.Message);
        }

        [Fact]
        public void SerializeFirstType()
        {
            var obj = new TestObject
            {
                AnyOf = "String!",
            };

            var expected = "{\n  \"any_of\": \"String!\"\n}";
            Assert.Equal(expected, obj.ToJson().Replace("\r\n", "\n"));
        }

        [Fact]
        public void SerializeSecondType()
        {
            var obj = new TestObject
            {
                AnyOf = new TestSubObject
                {
                    Id = "id_123",
                    Bar = 42,
                }
            };

            var expected =
                "{\n  \"any_of\": {\n    \"id\": \"id_123\",\n    \"bar\": 42\n  }\n}";
            Assert.Equal(expected, obj.ToJson().Replace("\r\n", "\n"));
        }

        [Fact]
        public void SerializeNull()
        {
            var obj = new TestObject
            {
                AnyOf = null,
            };

            var expected = "{\n  \"any_of\": null\n}";
            Assert.Equal(expected, obj.ToJson().Replace("\r\n", "\n"));
        }

        private class TestSubObject : StripeEntity<TestSubObject>, IHasId
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("bar")]
            public int Bar { get; set; }
        }

        private class TestObject : StripeEntity<TestObject>
        {
            [JsonProperty("any_of")]
            [JsonConverter(typeof(AnyOfConverter))]
            internal AnyOf<string, TestSubObject> AnyOf { get; set; }
        }
    }
}
