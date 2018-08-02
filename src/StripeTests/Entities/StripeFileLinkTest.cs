namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeFileLinkTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/file_links/link_123");
            var fileLink = Mapper<StripeFileLink>.MapFromJson(json);
            Assert.NotNull(fileLink);
            Assert.IsType<StripeFileLink>(fileLink);
            Assert.NotNull(fileLink.Id);
            Assert.Equal("file_link", fileLink.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "file",
            };

            string json = GetFixture("/v1/file_links/link_123", expansions);
            var fileLink = Mapper<StripeFileLink>.MapFromJson(json);
            Assert.NotNull(fileLink);
            Assert.IsType<StripeFileLink>(fileLink);
            Assert.NotNull(fileLink.Id);
            Assert.Equal("file_link", fileLink.Object);

            Assert.NotNull(fileLink.File);
            Assert.Equal("file", fileLink.File.Object);
        }
    }
}
