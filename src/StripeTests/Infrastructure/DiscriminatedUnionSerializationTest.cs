namespace StripeTests
{
    using System.IO;
    using System.Text.Json;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
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
        private static readonly System.Text.Json.JsonSerializerOptions StjOptions = new System.Text.Json.JsonSerializerOptions();

        private static readonly JsonSerializerSettings NewtonsoftSettings = new JsonSerializerSettings();

        [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
        private interface ITestColorOptions : INestedOptions
        {
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

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void StandaloneUnion_DeserializeRgb(bool stj)
        {
            var json = "{\"color\":{\"model\":\"rgb\",\"rgb\":{\"r\":255,\"g\":128,\"b\":0}},\"name\":\"sunset\"}";
            var obj = Deserialize<TestColorContainer>(json, stj);

            var rgb = Assert.IsType<TestRgbColorEntity>(obj.Color);
            Assert.Equal("rgb", rgb.Model);
            Assert.Equal(255, rgb.Rgb.R);
            Assert.Equal(128, rgb.Rgb.G);
            Assert.Equal(0, rgb.Rgb.B);
            Assert.Equal("sunset", obj.Name);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void StandaloneUnion_DeserializeHsl(bool stj)
        {
            var json = "{\"color\":{\"model\":\"hsl\",\"hsl\":{\"h\":30,\"s\":100,\"l\":50}},\"name\":\"orange\"}";
            var obj = Deserialize<TestColorContainer>(json, stj);

            var hsl = Assert.IsType<TestHslColorEntity>(obj.Color);
            Assert.Equal("hsl", hsl.Model);
            Assert.Equal(30, hsl.Hsl.H);
            Assert.Equal(100, hsl.Hsl.S);
            Assert.Equal(50, hsl.Hsl.L);
            Assert.Equal("orange", obj.Name);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void StandaloneUnion_UnknownInsideResource(bool stj)
        {
            var obj = Deserialize<TestColorContainer>("{\"name\":\"example\",\"color\":{\"model\":\"future_variant\"}}", stj);

            Assert.Equal("example", obj.Name);
            Assert.Equal("future_variant", Assert.IsType<TestColorEntity>(obj.Color).Model);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void StandaloneUnion_UnknownRoot(bool stj)
        {
            var color = Deserialize<TestColorEntity>("{\"model\":\"future_variant\"}", stj);

            Assert.Equal("future_variant", Assert.IsType<TestColorEntity>(color).Model);
            var roundTrip = Deserialize<TestColorEntity>(Serialize(color, stj), stj);
            Assert.Equal("future_variant", Assert.IsType<TestColorEntity>(roundTrip).Model);
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

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void StandaloneUnion_RoundTripWithReusedSettings(bool stj)
        {
            var known = "{\"model\":\"rgb\",\"rgb\":{\"r\":255,\"g\":128,\"b\":0,\"amount\":\"12.50\",\"created\":1234567890}}";
            var unknown = "{\"model\":\"future_variant\",\"unsupported\":{\"value\":42}}";

            foreach (var input in new[] { known, unknown, known, unknown })
            {
                var color = Deserialize<TestColorEntity>(input, stj);
                if (stj)
                {
                    Assert.Equal(color.Model, color.RawJsonElement.Value.GetProperty("model").GetString());
                }
                else
                {
                    Assert.Equal(color.Model, color.RawJObject["model"].Value<string>());
                }

                var json = Serialize(color, stj);
                var roundTrip = Deserialize<TestColorEntity>(json, stj);
                if (input == known)
                {
                    var rgb = Assert.IsType<TestRgbColorEntity>(roundTrip).Rgb;
                    Assert.Equal(255, rgb.R);
                    Assert.Equal(128, rgb.G);
                    Assert.Equal(0, rgb.B);
                    Assert.Equal(12.50m, rgb.Amount);
                    Assert.Equal(new System.DateTime(2009, 2, 13, 23, 31, 30, System.DateTimeKind.Utc), rgb.Created);
                    using (var doc = JsonDocument.Parse(json))
                    {
                        Assert.Equal(255, doc.RootElement.GetProperty("rgb").GetProperty("r").GetInt64());
                        Assert.Equal("12.50", doc.RootElement.GetProperty("rgb").GetProperty("amount").GetString());
                        Assert.Equal(1234567890, doc.RootElement.GetProperty("rgb").GetProperty("created").GetInt64());
                    }
                }
                else
                {
                    Assert.Equal("future_variant", Assert.IsType<TestColorEntity>(roundTrip).Model);
                    Assert.DoesNotContain("unsupported", json);
                    if (stj)
                    {
                        Assert.Equal(42, color.RawJsonElement.Value.GetProperty("unsupported").GetProperty("value").GetInt32());
                    }
                    else
                    {
                        Assert.Equal(42, color.RawJObject["unsupported"]["value"].Value<int>());
                    }
                }
            }
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void StandaloneUnion_NestedUnknown(bool stj)
        {
            var json = "{\"model\":\"rgb\",\"rgb\":{\"r\":255,\"nested\":{\"model\":\"future_variant\"}}}";
            var color = Deserialize<TestColorEntity>(json, stj);
            var nested = Assert.IsType<TestRgbColorEntity>(color).Rgb.Nested;

            Assert.Equal("future_variant", Assert.IsType<TestColorEntity>(nested).Model);
            var roundTrip = Deserialize<TestColorEntity>(Serialize(color, stj), stj);
            Assert.Equal("future_variant", Assert.IsType<TestColorEntity>(Assert.IsType<TestRgbColorEntity>(roundTrip).Rgb.Nested).Model);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void StandaloneUnion_MixedArray(bool stj)
        {
            var json = "[{\"model\":\"rgb\",\"rgb\":{\"r\":255}},{\"model\":\"future_variant\"},null]";
            var colors = Deserialize<TestColorEntity[]>(json, stj);
            var roundTrip = Deserialize<TestColorEntity[]>(Serialize(colors, stj), stj);

            Assert.Equal(3, roundTrip.Length);
            Assert.Equal(255, Assert.IsType<TestRgbColorEntity>(roundTrip[0]).Rgb.R);
            Assert.Equal("future_variant", Assert.IsType<TestColorEntity>(roundTrip[1]).Model);
            Assert.Null(roundTrip[2]);
        }

        [Theory]
        [InlineData(false, "{}")]
        [InlineData(true, "{}")]
        [InlineData(false, "{\"color\":null}")]
        [InlineData(true, "{\"color\":null}")]
        public void StandaloneUnion_OptionalNull(bool stj, string json)
        {
            var container = Deserialize<TestColorContainer>(json, stj);
            Assert.Null(container.Color);
            using (var doc = JsonDocument.Parse(Serialize(container, stj)))
            {
                Assert.Equal(JsonValueKind.Null, doc.RootElement.GetProperty("color").ValueKind);
            }

            var ignored = stj
                ? System.Text.Json.JsonSerializer.Serialize(container, new JsonSerializerOptions { DefaultIgnoreCondition = STJS.JsonIgnoreCondition.WhenWritingNull })
                : JsonConvert.SerializeObject(container, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            Assert.DoesNotContain("color", ignored);
        }

        private static T Deserialize<T>(string json, bool stj)
        {
            return stj
                ? System.Text.Json.JsonSerializer.Deserialize<T>(json, StjOptions)
                : JsonConvert.DeserializeObject<T>(json, NewtonsoftSettings);
        }

        private static string Serialize<T>(T value, bool stj)
        {
            return stj
                ? System.Text.Json.JsonSerializer.Serialize(value, StjOptions)
                : JsonConvert.SerializeObject(value, NewtonsoftSettings);
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

        [StripeDiscriminatedUnion("model")]
        [StripeUnionVariant(typeof(TestRgbColorEntity), "rgb")]
        [StripeUnionVariant(typeof(TestHslColorEntity), "hsl")]
        [JsonConverter(typeof(DiscriminatedUnionConverter))]
        [STJS.JsonConverter(typeof(STJDiscriminatedUnionConverterFactory))]
        private class TestColorEntity : StripeEntity<TestColorEntity>
        {
            [JsonProperty("model")]
            [STJS.JsonPropertyName("model")]
            public string Model { get; set; }
        }

        [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
        private class TestRgbColorEntity : TestColorEntity
        {
            [JsonProperty("rgb")]
            [STJS.JsonPropertyName("rgb")]
            public TestRgbPayload Rgb { get; set; }
        }

        [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
        private class TestHslColorEntity : TestColorEntity
        {
            [JsonProperty("hsl")]
            [STJS.JsonPropertyName("hsl")]
            public TestHslPayload Hsl { get; set; }
        }

        [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
        private class TestRgbPayload : StripeEntity<TestRgbPayload>
        {
            [JsonProperty("r")]
            [STJS.JsonPropertyName("r")]
            public long R { get; set; }

            [JsonProperty("g")]
            [STJS.JsonPropertyName("g")]
            public long G { get; set; }

            [JsonProperty("b")]
            [STJS.JsonPropertyName("b")]
            public long B { get; set; }

            [JsonProperty("nested")]
            [STJS.JsonPropertyName("nested")]
            public TestColorEntity Nested { get; set; }

            [JsonProperty("amount")]
            [JsonConverter(typeof(DecimalStringConverter))]
            [STJS.JsonPropertyName("amount")]
            [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
            public decimal Amount { get; set; }

            [JsonProperty("created")]
            [JsonConverter(typeof(UnixDateTimeConverter))]
            [STJS.JsonPropertyName("created")]
            [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
            public System.DateTime Created { get; set; } = new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc);
        }

        [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
        private class TestHslPayload : StripeEntity<TestHslPayload>
        {
            [JsonProperty("h")]
            [STJS.JsonPropertyName("h")]
            public long H { get; set; }

            [JsonProperty("s")]
            [STJS.JsonPropertyName("s")]
            public long S { get; set; }

            [JsonProperty("l")]
            [STJS.JsonPropertyName("l")]
            public long L { get; set; }
        }

        [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
        private class TestColorContainer : StripeEntity<TestColorContainer>
        {
            [JsonProperty("color")]
            [STJS.JsonPropertyName("color")]
            public TestColorEntity Color { get; set; }

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
