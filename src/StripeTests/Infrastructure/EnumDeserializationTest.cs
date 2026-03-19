namespace StripeTests
{
    using System.Text.Json;
    using Stripe;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class EnumDeserializationTest : BaseStripeTest
    {
        [Fact]
        public void DeserializeKnownValue()
        {
            var json = "{\"enum\": \"test_one\"}";
            TestOptions obj = JsonSerializer.Deserialize<TestOptions>(
                json, StripeConfiguration.SerializerOptions);

            Assert.NotNull(obj);
            Assert.Equal("test_one", obj.Enum);
        }

        [Fact]
        public void DeserializeUnknownValue()
        {
            // Unlike C# enums, string enums accept any value without throwing.
            // This matches the real SDK behavior where the API may return new
            // enum values that the SDK doesn't yet know about.
            var json = "{\"enum\": \"unknown_value\"}";
            TestOptions obj = JsonSerializer.Deserialize<TestOptions>(
                json, StripeConfiguration.SerializerOptions);

            Assert.NotNull(obj);
            Assert.Equal("unknown_value", obj.Enum);
        }

        [Fact]
        public void DeserializeNull()
        {
            var json = "{\"enum\": null}";
            TestOptions obj = JsonSerializer.Deserialize<TestOptions>(
                json, StripeConfiguration.SerializerOptions);

            Assert.NotNull(obj);
            Assert.Null(obj.Enum);
        }
    }
}
