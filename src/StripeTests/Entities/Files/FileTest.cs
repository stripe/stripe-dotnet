namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class FileTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/files/file_123");
            var file = JsonConvert.DeserializeObject<File>(json);
            Assert.NotNull(file);
            Assert.IsType<File>(file);
            Assert.NotNull(file.Id);
            Assert.Equal("file", file.Object);
        }
    }
}
