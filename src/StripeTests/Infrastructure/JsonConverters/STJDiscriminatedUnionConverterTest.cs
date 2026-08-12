namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class STJDiscriminatedUnionConverterTest : BaseStripeTest
    {
        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions
        {
            Converters = { new STJDiscriminatedUnionConverterFactory() },
        };

        [Fact]
        public void DeserializeFirstVariant()
        {
            var json = "{\"color\": {\"model\": \"rgb\", \"r\": 255, \"g\": 128, \"b\": 0}}";
            var obj = JsonSerializer.Deserialize<TestContainer>(json, Options);

            Assert.NotNull(obj.Color);
            Assert.IsType<TestRgbColor>(obj.Color);
            var rgb = (TestRgbColor)obj.Color;
            Assert.Equal("rgb", rgb.Model);
            Assert.Equal(255, rgb.R);
            Assert.Equal(128, rgb.G);
            Assert.Equal(0, rgb.B);
        }

        [Fact]
        public void DeserializeSecondVariant()
        {
            var json = "{\"color\": {\"model\": \"hsv\", \"h\": 120, \"s\": 100, \"v\": 50}}";
            var obj = JsonSerializer.Deserialize<TestContainer>(json, Options);

            Assert.NotNull(obj.Color);
            Assert.IsType<TestHsvColor>(obj.Color);
            var hsv = (TestHsvColor)obj.Color;
            Assert.Equal("hsv", hsv.Model);
            Assert.Equal(120, hsv.H);
            Assert.Equal(100, hsv.S);
            Assert.Equal(50, hsv.V);
        }

        [Fact]
        public void DeserializeNull()
        {
            var json = "{\"color\": null}";
            var obj = JsonSerializer.Deserialize<TestContainer>(json, Options);

            Assert.Null(obj.Color);
        }

        [Fact]
        public void DeserializeUnknownDiscriminatorThrows()
        {
            var json = "{\"color\": {\"model\": \"cmyk\", \"c\": 1}}";

            var exception = Assert.Throws<JsonException>(() =>
                JsonSerializer.Deserialize<TestContainer>(json, Options));

            Assert.Contains("Unknown discriminator value 'cmyk'", exception.Message);
        }

        [Fact]
        public void DeserializeMissingDiscriminatorThrows()
        {
            var json = "{\"color\": {\"r\": 255}}";

            var exception = Assert.Throws<JsonException>(() =>
                JsonSerializer.Deserialize<TestContainer>(json, Options));

            Assert.Contains("missing the discriminator property 'model'", exception.Message);
        }

        [Fact]
        public void SerializeFirstVariant()
        {
            var obj = new TestContainer
            {
                Color = new TestRgbColor { Model = "rgb", R = 255, G = 128, B = 0 },
            };

            var json = JsonSerializer.Serialize(obj, Options);
            Assert.Contains("\"model\":\"rgb\"", json);
            Assert.Contains("\"r\":255", json);
            Assert.Contains("\"g\":128", json);
            Assert.Contains("\"b\":0", json);
        }

        [Fact]
        public void SerializeNull()
        {
            var obj = new TestContainer { Color = null };

            var json = JsonSerializer.Serialize(obj, Options);
            Assert.Contains("\"color\":null", json);
        }

        [Fact]
        public void RoundTripPreservesData()
        {
            var original = new TestContainer
            {
                Color = new TestHsvColor { Model = "hsv", H = 240, S = 80, V = 90 },
            };

            var json = JsonSerializer.Serialize(original, Options);
            var deserialized = JsonSerializer.Deserialize<TestContainer>(json, Options);

            Assert.IsType<TestHsvColor>(deserialized.Color);
            var hsv = (TestHsvColor)deserialized.Color;
            Assert.Equal("hsv", hsv.Model);
            Assert.Equal(240, hsv.H);
            Assert.Equal(80, hsv.S);
            Assert.Equal(90, hsv.V);
        }

        [StripeDiscriminatedUnion("model")]
        [StripeUnionVariant(typeof(TestRgbColor), "rgb")]
        [StripeUnionVariant(typeof(TestHsvColor), "hsv")]
        [JsonConverter(typeof(STJDiscriminatedUnionConverterFactory))]
        private class TestColor
        {
            [JsonPropertyName("model")]
            public string Model { get; set; }
        }

        private class TestRgbColor : TestColor
        {
            [JsonPropertyName("r")]
            public long R { get; set; }

            [JsonPropertyName("g")]
            public long G { get; set; }

            [JsonPropertyName("b")]
            public long B { get; set; }
        }

        private class TestHsvColor : TestColor
        {
            [JsonPropertyName("h")]
            public long H { get; set; }

            [JsonPropertyName("s")]
            public long S { get; set; }

            [JsonPropertyName("v")]
            public long V { get; set; }
        }

        private class TestContainer
        {
            [JsonPropertyName("color")]
            public TestColor Color { get; set; }
        }
    }
}
