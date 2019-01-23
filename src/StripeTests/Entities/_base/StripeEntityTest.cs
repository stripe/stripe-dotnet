namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeEntityTest
    {
        [Fact]
        public void FromJsonAuto()
        {
            var json = "{\"id\": \"ch_123\", \"object\": \"charge\"}";

            var o = StripeEntity.FromJson(json);

            Assert.NotNull(o);
            Assert.IsType<Charge>(o);
            Assert.Equal("ch_123", ((Charge)o).Id);
        }

        [Fact]
        public void FromJsonAutoUnknownObject()
        {
            var json = "{\"id\": \"ch_123\", \"object\": \"foo\"}";

            var o = StripeEntity.FromJson(json);

            Assert.Null(o);
        }

        [Fact]
        public void FromJsonAutoNoObject()
        {
            var json = "{\"id\": \"ch_123\"}";

            var o = StripeEntity.FromJson(json);

            Assert.Null(o);
        }

        [Fact]
        public void FromJsonOnType()
        {
            var json = "{\"integer\": 234, \"string\": \"String!\"}";

            var o = TestEntity.FromJson(json);

            Assert.NotNull(o);
            Assert.Equal(234, o.Integer);
            Assert.Equal("String!", o.String);
        }

        [Fact]
        public void FromJsonGeneric()
        {
            var json = "{\"integer\": 234, \"string\": \"String!\"}";

            var o = StripeEntity.FromJson<TestEntity>(json);

            Assert.NotNull(o);
            Assert.Equal(234, o.Integer);
            Assert.Equal("String!", o.String);
        }

        [Fact]
        public void ToJson()
        {
            var o = new TestEntity
            {
                Integer = 234,
                String = "String!",
            };

            var json = o.ToJson().Replace("\r\n", "\n");

            var expectedJson = "{\n  \"integer\": 234,\n  \"string\": \"String!\"\n}";
            Assert.Equal(expectedJson, json);
        }

        private class TestEntity : StripeEntity<TestEntity>
        {
            [JsonProperty("integer")]
            public int Integer { get; set; }

            [JsonProperty("string")]
            public string String { get; set; }
        }
    }
}
