namespace StripeTests
{
    using System.Text.Json;
    using Stripe;
    using Xunit;

    public class BaseOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeAndDeserializeExpandAndExtraParams()
        {
            var options = new BaseOptions();
            options.AddExpand("expand_me");
            options.AddExtraParam("foo", "String!");
            options.AddExtraParam("bar", 234L);

            var json = JsonSerializer.Serialize(options);
            var deserialized = JsonSerializer.Deserialize<BaseOptions>(json);

            Assert.Equal(options.Expand, deserialized.Expand);
            Assert.True(options.ExtraParams.Count == deserialized.ExtraParams.Count);

            // STJ deserializes extension data values as JsonElement, so compare
            // by converting both sides to strings for type-agnostic comparison.
            foreach (var kvp in deserialized.ExtraParams)
            {
                Assert.Equal(
                    options.ExtraParams[kvp.Key].ToString(),
                    kvp.Value is JsonElement el ? el.ToString() : kvp.Value.ToString());
            }
        }
    }
}
