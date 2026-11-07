namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class DiscriminatedUnionConverterTest : BaseStripeTest
    {
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            Converters = { new DiscriminatedUnionConverter() },
        };

        [StripeDiscriminatedUnion("model")]
        private interface IAbstractColor
        {
        }

        [Fact]
        public void DeserializeFirstVariant()
        {
            var json = "{\"color\": {\"model\": \"rgb\", \"r\": 255, \"g\": 128, \"b\": 0}}";
            var obj = JsonConvert.DeserializeObject<TestContainer>(json, Settings);

            var rgb = Assert.IsType<TestRgbColor>(obj.Color);
            Assert.Equal("rgb", rgb.Model);
            Assert.Equal(255, rgb.R);
            Assert.Equal(128, rgb.G);
            Assert.Equal(0, rgb.B);
        }

        [Fact]
        public void DeserializeSecondVariant()
        {
            var json = "{\"color\": {\"model\": \"hsv\", \"h\": 120, \"s\": 100, \"v\": 50}}";
            var obj = JsonConvert.DeserializeObject<TestContainer>(json, Settings);

            var hsv = Assert.IsType<TestHsvColor>(obj.Color);
            Assert.Equal("hsv", hsv.Model);
            Assert.Equal(120, hsv.H);
            Assert.Equal(100, hsv.S);
            Assert.Equal(50, hsv.V);
        }

        [Fact]
        public void DeserializeNull()
        {
            var json = "{\"color\": null}";
            var obj = JsonConvert.DeserializeObject<TestContainer>(json, Settings);

            Assert.Null(obj.Color);
        }

        [Fact]
        public void DeserializeUnknownDiscriminator()
        {
            var obj = JsonConvert.DeserializeObject<TestContainer>("{\"color\":{\"model\":\"future_variant\"}}", Settings);

            Assert.Equal("future_variant", Assert.IsType<TestColor>(obj.Color).Model);
            var roundTrip = JsonConvert.DeserializeObject<TestContainer>(JsonConvert.SerializeObject(obj, Settings), Settings);
            Assert.Equal("future_variant", Assert.IsType<TestColor>(roundTrip.Color).Model);
        }

        [Theory]
        [InlineData("null")]
        [InlineData("42")]
        [InlineData("true")]
        public void DeserializeInvalidDiscriminatorThrows(string discriminator)
        {
            var json = "{\"model\":" + discriminator + "}";
            Assert.Throws<JsonSerializationException>(() => JsonConvert.DeserializeObject<TestColor>(json, Settings));
        }

        [Theory]
        [InlineData(typeof(IAbstractColor))]
        [InlineData(typeof(AbstractColor))]
        [InlineData(typeof(NoDefaultConstructorColor))]
        public void UnknownNonInstantiableTargetThrows(System.Type type)
        {
            var exception = Assert.Throws<JsonSerializationException>(() =>
                JsonConvert.DeserializeObject("{\"model\":\"future_variant\"}", type, Settings));
            Assert.Contains(type.Name, exception.Message);
            Assert.Contains("Fallback requires a concrete type with a public parameterless constructor", exception.Message);
        }

        [Fact]
        public void DeserializeMissingDiscriminatorThrows()
        {
            var json = "{\"color\": {\"r\": 255}}";

            var exception = Assert.Throws<JsonSerializationException>(() =>
                JsonConvert.DeserializeObject<TestContainer>(json, Settings));

            Assert.Contains("missing the discriminator property 'model'", exception.Message);
        }

        [Fact]
        public void SerializeFirstVariant()
        {
            var obj = new TestContainer
            {
                Color = new TestRgbColor { Model = "rgb", R = 255, G = 128, B = 0 },
            };

            var json = JsonConvert.SerializeObject(obj, Settings);
            Assert.Contains("\"model\":\"rgb\"", json);
            Assert.Contains("\"r\":255", json);
            Assert.Contains("\"g\":128", json);
            Assert.Contains("\"b\":0", json);
        }

        [Fact]
        public void SerializeNull()
        {
            var obj = new TestContainer { Color = null };

            var json = JsonConvert.SerializeObject(obj, Settings);
            Assert.Contains("\"color\":null", json);
        }

        [Fact]
        public void RoundTripPreservesData()
        {
            var original = new TestContainer
            {
                Color = new TestHsvColor { Model = "hsv", H = 240, S = 80, V = 90 },
            };

            var json = JsonConvert.SerializeObject(original, Settings);
            var deserialized = JsonConvert.DeserializeObject<TestContainer>(json, Settings);

            var hsv = Assert.IsType<TestHsvColor>(deserialized.Color);
            Assert.Equal("hsv", hsv.Model);
            Assert.Equal(240, hsv.H);
            Assert.Equal(80, hsv.S);
            Assert.Equal(90, hsv.V);
        }

        [StripeDiscriminatedUnion("model")]
        private abstract class AbstractColor
        {
        }

        [StripeDiscriminatedUnion("model")]
        private class NoDefaultConstructorColor
        {
            public NoDefaultConstructorColor(string model)
            {
            }
        }

        [StripeDiscriminatedUnion("model")]
        [StripeUnionVariant(typeof(TestRgbColor), "rgb")]
        [StripeUnionVariant(typeof(TestHsvColor), "hsv")]
        private class TestColor
        {
            [JsonProperty("model")]
            public string Model { get; set; }
        }

        private class TestRgbColor : TestColor
        {
            [JsonProperty("r")]
            public long R { get; set; }

            [JsonProperty("g")]
            public long G { get; set; }

            [JsonProperty("b")]
            public long B { get; set; }
        }

        private class TestHsvColor : TestColor
        {
            [JsonProperty("h")]
            public long H { get; set; }

            [JsonProperty("s")]
            public long S { get; set; }

            [JsonProperty("v")]
            public long V { get; set; }
        }

        private class TestContainer
        {
            [JsonProperty("color")]
            public TestColor Color { get; set; }
        }
    }
}
