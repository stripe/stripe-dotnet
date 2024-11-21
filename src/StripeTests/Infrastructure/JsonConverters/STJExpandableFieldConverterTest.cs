#if NET6_0_OR_GREATER
namespace StripeTests
{
    using System.IO;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class STJExpandableFieldConverterTest : BaseStripeTest
    {
        [Fact]
        public void DeserializeNotExpanded()
        {
            var json = "{\n  \"nested\": \"id_not_expanded\"\n}";
            var obj = JsonSerializer.Deserialize<TestTopLevelObject>(json);

            Assert.Equal("id_not_expanded", obj.NestedId);
            Assert.Null(obj.Nested);
        }

        [Fact]
        public void DeserializeExpanded()
        {
            var json = "{\n  \"nested\": {\n    \"id\": \"id_expanded\",\n    \"bar\": 42\n  }\n}";
            var obj = JsonSerializer.Deserialize<TestTopLevelObject>(json);

            Assert.Equal("id_expanded", obj.NestedId);
            Assert.NotNull(obj.Nested);
            Assert.Equal("id_expanded", obj.Nested.Id);
            Assert.Equal(42, obj.Nested.Bar);
        }

        [Fact]
        public void DeserializeNull()
        {
            var json = "{\n  \"nested\": null\n}";
            var obj = JsonSerializer.Deserialize<TestTopLevelObject>(json);

            Assert.Null(obj.NestedId);
            Assert.Null(obj.Nested);
        }

        [Fact]
        public void SerializeNotExpanded()
        {
            var obj = new TestTopLevelObject
            {
                InternalNested = new ExpandableField<TestNestedObject>
                {
                    Id = "id_not_expanded",
                    ExpandedObject = null,
                },
            };

            var expected = "{\"nested\":\"id_not_expanded\"}";
            var actual = JsonSerializer.Serialize(obj);
            Assert.Equal(expected, actual);

            var indentedExpected = "{\n  \"nested\": \"id_not_expanded\"\n}";
            var options = new JsonSerializerOptions { WriteIndented = true };
            var indentedActual = JsonSerializer.Serialize(obj, options);
            Assert.Equal(indentedExpected, indentedActual);
        }

        [Fact]
        public void SerializeExpanded()
        {
            var nested = new TestNestedObject
            {
                Id = "id_expanded",
                Bar = 42,
            };
            var obj = new TestTopLevelObject
            {
                InternalNested = new ExpandableField<TestNestedObject>
                {
                    Id = nested.Id,
                    ExpandedObject = nested,
                },
            };

            var expected =
                "{\"nested\":{\"id\":\"id_expanded\",\"bar\":42}}";
            var actual = JsonSerializer.Serialize(obj);
            Assert.Equal(expected, actual);

            var indentedExpected =
                "{\n  \"nested\": {\n    \"id\": \"id_expanded\",\n    \"bar\": 42\n  }\n}";
            var options = new JsonSerializerOptions { WriteIndented = true };
            var indentedActual = JsonSerializer.Serialize(obj, options);
            Assert.Equal(indentedExpected, indentedActual);
        }

        [Fact]
        public void SerializeNull()
        {
            var obj = new TestTopLevelObject
            {
                InternalNested = new ExpandableField<TestNestedObject>
                {
                    Id = null,
                    ExpandedObject = null,
                },
            };

            var expected = "{\"nested\":null}";
            var actual = JsonSerializer.Serialize(obj);
            Assert.Equal(expected, actual);

            var indentedExpected = "{\n  \"nested\": null\n}";
            var options = new JsonSerializerOptions { WriteIndented = true };
            var indentedActual = JsonSerializer.Serialize(obj, options);
            Assert.Equal(indentedExpected, indentedActual);
        }

        private class TestNestedObject : StripeEntity<TestNestedObject>, IHasId
        {
            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("bar")]
            public int Bar { get; set; }
        }

        private class TestTopLevelObject : StripeEntity<TestTopLevelObject>
        {
            [JsonIgnore]
            public string NestedId => this.InternalNested.Id;

            [JsonIgnore]
            public TestNestedObject Nested => this.InternalNested.ExpandedObject;

            [JsonPropertyName("nested")]
            [JsonInclude]
            [JsonConverter(typeof(STJExpandableFieldConverter<TestNestedObject>))]
            internal ExpandableField<TestNestedObject> InternalNested { get; set; }
        }
    }
}
#endif
