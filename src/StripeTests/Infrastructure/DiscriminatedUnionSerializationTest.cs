namespace StripeTests
{
    using System.IO;
    using System.Text.Json;
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Tests that discriminated unions serialize correctly on the request side
    /// (options to wire) and deserialize correctly on the response side
    /// (wire to entity). These test fixtures mirror what codegen will produce.
    /// </summary>
    public class DiscriminatedUnionSerializationTest : BaseStripeTest
    {
        private static readonly System.Text.Json.JsonSerializerOptions StjOptions = new System.Text.Json.JsonSerializerOptions
        {
            Converters = { new STJDiscriminatedUnionConverterFactory() },
        };

        [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
        private interface ITestColorOptions : INestedOptions
        {
        }

        [StripeDiscriminatedUnion("model")]
        [StripeUnionVariant(typeof(TestRgbColorEntity), "rgb")]
        [StripeUnionVariant(typeof(TestHsvColorEntity), "hsv")]
        [JsonConverter(typeof(DiscriminatedUnionConverter))]
        [STJS.JsonConverter(typeof(STJDiscriminatedUnionConverterFactory))]
        private interface ITestColorEntity
        {
            string Model { get; }
        }

        [Fact]
        public async void StandaloneUnion_V1FormEncoding_RgbVariant()
        {
            var options = new TestStandaloneUnionOptions
            {
                Color = new TestRgbColorOptions { R = 255, G = 128, B = 0 },
                Name = "sunset",
            };

            var content = ContentEncoder.CreateHttpContent(options, ApiMode.V1);
            var stream = await content.ReadAsStreamAsync();
            var result = new StreamReader(stream).ReadToEnd();

            Assert.Contains("color[model]=rgb", result);
            Assert.Contains("color[r]=255", result);
            Assert.Contains("color[g]=128", result);
            Assert.Contains("color[b]=0", result);
            Assert.Contains("name=sunset", result);
        }

        [Fact]
        public async void StandaloneUnion_V1FormEncoding_HsvVariant()
        {
            var options = new TestStandaloneUnionOptions
            {
                Color = new TestHsvColorOptions { H = 30, S = 100, V = 100 },
                Name = "orange",
            };

            var content = ContentEncoder.CreateHttpContent(options, ApiMode.V1);
            var stream = await content.ReadAsStreamAsync();
            var result = new StreamReader(stream).ReadToEnd();

            Assert.Contains("color[model]=hsv", result);
            Assert.Contains("color[h]=30", result);
            Assert.Contains("color[s]=100", result);
            Assert.Contains("color[v]=100", result);
            Assert.Contains("name=orange", result);
        }

        [Fact]
        public async void InlineUnion_V1FormEncoding_CardVariant()
        {
            var options = new TestInlineUnionOptions
            {
                Type = "card",
                Card = new TestInlineUnionCardOptions
                {
                    Number = "4242424242424242",
                    ExpMonth = 12,
                },
            };

            var content = ContentEncoder.CreateHttpContent(options, ApiMode.V1);
            var stream = await content.ReadAsStreamAsync();
            var result = new StreamReader(stream).ReadToEnd();

            Assert.Contains("type=card", result);
            Assert.Contains("card[number]=4242424242424242", result);
            Assert.Contains("card[exp_month]=12", result);
            Assert.DoesNotContain("bank", result);
        }

        [Fact]
        public async void InlineUnion_V1FormEncoding_BankVariant()
        {
            var options = new TestInlineUnionOptions
            {
                Type = "bank",
                Bank = new TestInlineUnionBankOptions
                {
                    RoutingNumber = "110000000",
                    AccountNumber = "000123456789",
                },
            };

            var content = ContentEncoder.CreateHttpContent(options, ApiMode.V1);
            var stream = await content.ReadAsStreamAsync();
            var result = new StreamReader(stream).ReadToEnd();

            Assert.Contains("type=bank", result);
            Assert.Contains("bank[routing_number]=110000000", result);
            Assert.Contains("bank[account_number]=000123456789", result);
            Assert.DoesNotContain("card", result);
        }

        [Fact]
        public async void StandaloneUnion_V2JsonEncoding_RgbVariant()
        {
            var options = new TestStandaloneUnionOptions
            {
                Color = new TestRgbColorOptions { R = 255, G = 128, B = 0 },
                Name = "sunset",
            };

            var content = ContentEncoder.CreateHttpContent(options, ApiMode.V2);
            var stream = await content.ReadAsStreamAsync();
            var result = new StreamReader(stream).ReadToEnd();

            var doc = JsonDocument.Parse(result);
            var root = doc.RootElement;

            Assert.Equal("sunset", root.GetProperty("name").GetString());

            var color = root.GetProperty("color");
            Assert.Equal("rgb", color.GetProperty("model").GetString());
            Assert.Equal(255, color.GetProperty("r").GetInt64());
            Assert.Equal(128, color.GetProperty("g").GetInt64());
            Assert.Equal(0, color.GetProperty("b").GetInt64());
        }

        [Fact]
        public async void StandaloneUnion_V2JsonEncoding_HsvVariant()
        {
            var options = new TestStandaloneUnionOptions
            {
                Color = new TestHsvColorOptions { H = 30, S = 100, V = 100 },
                Name = "orange",
            };

            var content = ContentEncoder.CreateHttpContent(options, ApiMode.V2);
            var stream = await content.ReadAsStreamAsync();
            var result = new StreamReader(stream).ReadToEnd();

            var doc = JsonDocument.Parse(result);
            var root = doc.RootElement;

            Assert.Equal("orange", root.GetProperty("name").GetString());

            var color = root.GetProperty("color");
            Assert.Equal("hsv", color.GetProperty("model").GetString());
            Assert.Equal(30, color.GetProperty("h").GetInt64());
            Assert.Equal(100, color.GetProperty("s").GetInt64());
            Assert.Equal(100, color.GetProperty("v").GetInt64());
        }

        [Fact]
        public async void InlineUnion_V2JsonEncoding_CardVariant()
        {
            var options = new TestInlineUnionOptions
            {
                Type = "card",
                Card = new TestInlineUnionCardOptions
                {
                    Number = "4242424242424242",
                    ExpMonth = 12,
                },
            };

            var content = ContentEncoder.CreateHttpContent(options, ApiMode.V2);
            var stream = await content.ReadAsStreamAsync();
            var result = new StreamReader(stream).ReadToEnd();

            var doc = JsonDocument.Parse(result);
            var root = doc.RootElement;

            Assert.Equal("card", root.GetProperty("type").GetString());

            var card = root.GetProperty("card");
            Assert.Equal("4242424242424242", card.GetProperty("number").GetString());
            Assert.Equal(12, card.GetProperty("exp_month").GetInt64());

            Assert.False(root.TryGetProperty("bank", out _));
        }

        [Fact]
        public void StandaloneUnion_Newtonsoft_DeserializeRgb()
        {
            var json = "{\"color\": {\"model\": \"rgb\", \"r\": 255, \"g\": 128, \"b\": 0}, \"name\": \"sunset\"}";
            var obj = JsonConvert.DeserializeObject<TestColorContainer>(json);

            Assert.NotNull(obj.Color);
            Assert.IsType<TestRgbColorEntity>(obj.Color);
            var rgb = (TestRgbColorEntity)obj.Color;
            Assert.Equal("rgb", rgb.Model);
            Assert.Equal(255, rgb.R);
            Assert.Equal(128, rgb.G);
            Assert.Equal(0, rgb.B);
            Assert.Equal("sunset", obj.Name);
        }

        [Fact]
        public void StandaloneUnion_Newtonsoft_DeserializeHsv()
        {
            var json = "{\"color\": {\"model\": \"hsv\", \"h\": 30, \"s\": 100, \"v\": 100}, \"name\": \"orange\"}";
            var obj = JsonConvert.DeserializeObject<TestColorContainer>(json);

            Assert.NotNull(obj.Color);
            Assert.IsType<TestHsvColorEntity>(obj.Color);
            var hsv = (TestHsvColorEntity)obj.Color;
            Assert.Equal("hsv", hsv.Model);
            Assert.Equal(30, hsv.H);
            Assert.Equal(100, hsv.S);
            Assert.Equal(100, hsv.V);
            Assert.Equal("orange", obj.Name);
        }

        [Fact]
        public void InlineUnion_Newtonsoft_DeserializeCard()
        {
            var json = "{\"type\": \"card\", \"card\": {\"number\": \"4242\", \"exp_month\": 12}}";
            var obj = JsonConvert.DeserializeObject<TestInlineUnionEntity>(json);

            Assert.Equal("card", obj.Type);
            Assert.NotNull(obj.Card);
            Assert.Equal("4242", obj.Card.Number);
            Assert.Equal(12, obj.Card.ExpMonth);
            Assert.Null(obj.Bank);
        }

        [Fact]
        public void InlineUnion_Newtonsoft_DeserializeBank()
        {
            var json = "{\"type\": \"bank\", \"bank\": {\"routing_number\": \"110000000\", \"account_number\": \"000123456789\"}}";
            var obj = JsonConvert.DeserializeObject<TestInlineUnionEntity>(json);

            Assert.Equal("bank", obj.Type);
            Assert.Null(obj.Card);
            Assert.NotNull(obj.Bank);
            Assert.Equal("110000000", obj.Bank.RoutingNumber);
            Assert.Equal("000123456789", obj.Bank.AccountNumber);
        }

        [Fact]
        public void StandaloneUnion_STJ_DeserializeRgb()
        {
            var json = "{\"color\": {\"model\": \"rgb\", \"r\": 255, \"g\": 128, \"b\": 0}, \"name\": \"sunset\"}";
            var obj = System.Text.Json.JsonSerializer.Deserialize<TestColorContainer>(json, StjOptions);

            Assert.NotNull(obj.Color);
            Assert.IsType<TestRgbColorEntity>(obj.Color);
            var rgb = (TestRgbColorEntity)obj.Color;
            Assert.Equal("rgb", rgb.Model);
            Assert.Equal(255, rgb.R);
            Assert.Equal(128, rgb.G);
            Assert.Equal(0, rgb.B);
            Assert.Equal("sunset", obj.Name);
        }

        [Fact]
        public void StandaloneUnion_STJ_DeserializeHsv()
        {
            var json = "{\"color\": {\"model\": \"hsv\", \"h\": 30, \"s\": 100, \"v\": 100}, \"name\": \"orange\"}";
            var obj = System.Text.Json.JsonSerializer.Deserialize<TestColorContainer>(json, StjOptions);

            Assert.NotNull(obj.Color);
            Assert.IsType<TestHsvColorEntity>(obj.Color);
            var hsv = (TestHsvColorEntity)obj.Color;
            Assert.Equal("hsv", hsv.Model);
            Assert.Equal(30, hsv.H);
            Assert.Equal(100, hsv.S);
            Assert.Equal(100, hsv.V);
            Assert.Equal("orange", obj.Name);
        }

        [Fact]
        public void InlineUnion_STJ_DeserializeCard()
        {
            var json = "{\"type\": \"card\", \"card\": {\"number\": \"4242\", \"exp_month\": 12}}";
            var obj = System.Text.Json.JsonSerializer.Deserialize<TestInlineUnionEntity>(json, StjOptions);

            Assert.Equal("card", obj.Type);
            Assert.NotNull(obj.Card);
            Assert.Equal("4242", obj.Card.Number);
            Assert.Equal(12, obj.Card.ExpMonth);
            Assert.Null(obj.Bank);
        }

        [Fact]
        public void StandaloneUnion_Newtonsoft_RoundTrip()
        {
            var original = new TestColorContainer
            {
                Color = new TestRgbColorEntity { Model = "rgb", R = 10, G = 20, B = 30 },
                Name = "test",
            };

            var json = JsonConvert.SerializeObject(original);
            var deserialized = JsonConvert.DeserializeObject<TestColorContainer>(json);

            Assert.IsType<TestRgbColorEntity>(deserialized.Color);
            var rgb = (TestRgbColorEntity)deserialized.Color;
            Assert.Equal("rgb", rgb.Model);
            Assert.Equal(10, rgb.R);
            Assert.Equal(20, rgb.G);
            Assert.Equal(30, rgb.B);
            Assert.Equal("test", deserialized.Name);
        }

        [Fact]
        public void StandaloneUnion_STJ_RoundTrip()
        {
            var original = new TestColorContainer
            {
                Color = new TestRgbColorEntity { Model = "rgb", R = 10, G = 20, B = 30 },
                Name = "test",
            };

            var json = System.Text.Json.JsonSerializer.Serialize(original, StjOptions);
            var deserialized = System.Text.Json.JsonSerializer.Deserialize<TestColorContainer>(json, StjOptions);

            Assert.IsType<TestRgbColorEntity>(deserialized.Color);
            var rgb = (TestRgbColorEntity)deserialized.Color;
            Assert.Equal("rgb", rgb.Model);
            Assert.Equal(10, rgb.R);
            Assert.Equal(20, rgb.G);
            Assert.Equal(30, rgb.B);
            Assert.Equal("test", deserialized.Name);
        }

        [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
        private class TestRgbColorOptions : ITestColorOptions
        {
            [JsonProperty("model")]
            [STJS.JsonPropertyName("model")]
            public string Model => "rgb";

            [JsonProperty("r")]
            [STJS.JsonPropertyName("r")]
            public long? R { get; set; }

            [JsonProperty("g")]
            [STJS.JsonPropertyName("g")]
            public long? G { get; set; }

            [JsonProperty("b")]
            [STJS.JsonPropertyName("b")]
            public long? B { get; set; }
        }

        [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
        private class TestHsvColorOptions : ITestColorOptions
        {
            [JsonProperty("model")]
            [STJS.JsonPropertyName("model")]
            public string Model => "hsv";

            [JsonProperty("h")]
            [STJS.JsonPropertyName("h")]
            public long? H { get; set; }

            [JsonProperty("s")]
            [STJS.JsonPropertyName("s")]
            public long? S { get; set; }

            [JsonProperty("v")]
            [STJS.JsonPropertyName("v")]
            public long? V { get; set; }
        }

        [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
        private class TestStandaloneUnionOptions : BaseOptions
        {
            [JsonProperty("color")]
            [STJS.JsonPropertyName("color")]
            public ITestColorOptions Color { get; set; }

            [JsonProperty("name")]
            [STJS.JsonPropertyName("name")]
            public string Name { get; set; }
        }

        [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
        private class TestInlineUnionCardOptions : INestedOptions
        {
            [JsonProperty("number")]
            [STJS.JsonPropertyName("number")]
            public string Number { get; set; }

            [JsonProperty("exp_month")]
            [STJS.JsonPropertyName("exp_month")]
            public long? ExpMonth { get; set; }
        }

        [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
        private class TestInlineUnionBankOptions : INestedOptions
        {
            [JsonProperty("routing_number")]
            [STJS.JsonPropertyName("routing_number")]
            public string RoutingNumber { get; set; }

            [JsonProperty("account_number")]
            [STJS.JsonPropertyName("account_number")]
            public string AccountNumber { get; set; }
        }

        [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
        private class TestInlineUnionOptions : BaseOptions
        {
            [JsonProperty("type")]
            [STJS.JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonProperty("card")]
            [STJS.JsonPropertyName("card")]
            public TestInlineUnionCardOptions Card { get; set; }

            [JsonProperty("bank")]
            [STJS.JsonPropertyName("bank")]
            public TestInlineUnionBankOptions Bank { get; set; }
        }

        private class TestRgbColorEntity : StripeEntity<TestRgbColorEntity>, ITestColorEntity
        {
            [JsonProperty("model")]
            [STJS.JsonPropertyName("model")]
            public string Model { get; set; }

            [JsonProperty("r")]
            [STJS.JsonPropertyName("r")]
            public long R { get; set; }

            [JsonProperty("g")]
            [STJS.JsonPropertyName("g")]
            public long G { get; set; }

            [JsonProperty("b")]
            [STJS.JsonPropertyName("b")]
            public long B { get; set; }
        }

        private class TestHsvColorEntity : StripeEntity<TestHsvColorEntity>, ITestColorEntity
        {
            [JsonProperty("model")]
            [STJS.JsonPropertyName("model")]
            public string Model { get; set; }

            [JsonProperty("h")]
            [STJS.JsonPropertyName("h")]
            public long H { get; set; }

            [JsonProperty("s")]
            [STJS.JsonPropertyName("s")]
            public long S { get; set; }

            [JsonProperty("v")]
            [STJS.JsonPropertyName("v")]
            public long V { get; set; }
        }

        private class TestColorContainer : StripeEntity<TestColorContainer>
        {
            [JsonProperty("color")]
            [STJS.JsonPropertyName("color")]
            public ITestColorEntity Color { get; set; }

            [JsonProperty("name")]
            [STJS.JsonPropertyName("name")]
            public string Name { get; set; }
        }

        private class TestInlineCardEntity : StripeEntity<TestInlineCardEntity>
        {
            [JsonProperty("number")]
            [STJS.JsonPropertyName("number")]
            public string Number { get; set; }

            [JsonProperty("exp_month")]
            [STJS.JsonPropertyName("exp_month")]
            public long ExpMonth { get; set; }
        }

        private class TestInlineBankEntity : StripeEntity<TestInlineBankEntity>
        {
            [JsonProperty("routing_number")]
            [STJS.JsonPropertyName("routing_number")]
            public string RoutingNumber { get; set; }

            [JsonProperty("account_number")]
            [STJS.JsonPropertyName("account_number")]
            public string AccountNumber { get; set; }
        }

        private class TestInlineUnionEntity : StripeEntity<TestInlineUnionEntity>
        {
            [JsonProperty("type")]
            [STJS.JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonProperty("card")]
            [STJS.JsonPropertyName("card")]
            public TestInlineCardEntity Card { get; set; }

            [JsonProperty("bank")]
            [STJS.JsonPropertyName("bank")]
            public TestInlineBankEntity Bank { get; set; }
        }
    }
}
