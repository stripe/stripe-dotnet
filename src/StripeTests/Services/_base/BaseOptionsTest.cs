namespace StripeTests
{
    using System.Linq;
    using Newtonsoft.Json;
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

            var json = JsonConvert.SerializeObject(options);
            var deserialized = JsonConvert.DeserializeObject<BaseOptions>(json);

            Assert.Equal(options.Expand, deserialized.Expand);
            Assert.True(options.ExtraParams.Count == deserialized.ExtraParams.Count);
            Assert.All(
                deserialized.ExtraParams,
                kvp => Assert.Equal(options.ExtraParams[kvp.Key], deserialized.ExtraParams[kvp.Key]));
        }
    }
}
