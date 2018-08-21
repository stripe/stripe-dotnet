namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class FileUploadTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/files/file_123");
            var fileUpload = Mapper<FileUpload>.MapFromJson(json);
            Assert.NotNull(fileUpload);
            Assert.IsType<FileUpload>(fileUpload);
            Assert.NotNull(fileUpload.Id);
            Assert.Equal("file_upload", fileUpload.Object);
        }
    }
}
