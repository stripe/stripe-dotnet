namespace StripeTests
{
    using Newtonsoft.Json;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class EnumDeserializationTest : BaseStripeTest
    {
        [Fact]
        public void EnumDecodeValueWithEnumMember()
        {
            var json = "{\"enum\": \"test_one\"}";
            TestOptions obj = JsonConvert.DeserializeObject<TestOptions>(json);

            Assert.NotNull(obj);
            Assert.Equal(TestOptions.TestEnum.TestOne, obj.Enum);
        }

        [Fact]
        public void EnumDecodeValueWithoutEnumMember()
        {
            var json = "{\"enum\": \"TestTwo\"}";
            TestOptions obj = JsonConvert.DeserializeObject<TestOptions>(json);

            Assert.NotNull(obj);
            Assert.Equal(TestOptions.TestEnum.TestTwo, obj.Enum);
        }

        [Fact]
        public void DecodingShouldThrowIfValueNotDeclaredInEnum()
        {
            var json = "{\"enum\": \"unknown_value\"}";

            var exception = Assert.Throws<Newtonsoft.Json.JsonSerializationException>(() =>
                JsonConvert.DeserializeObject<TestOptions>(json));

            Assert.Contains("Error converting value \"unknown_value\"", exception.Message);
        }
    }
}
