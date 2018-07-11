namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class StripeFileUploadServiceTest : BaseStripeTest
    {
        private const string FileUploadId = "file_123";
        private const string FileName = "StripeTests.Resources.file_upload_logo.png";

        private Stream stream;
        private StripeFileUploadService service;
        private StripeFileUploadListOptions listOptions;

        public StripeFileUploadServiceTest()
        {
            this.service = new StripeFileUploadService();

            this.stream = typeof(StripeFileUploadServiceTest).GetTypeInfo().Assembly.GetManifestResourceStream(FileName);

            this.listOptions = new StripeFileUploadListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var fileUpload = this.service.Create(FileName, this.stream, StripeFilePurpose.BusinessLogo);
            Assert.NotNull(fileUpload);
            Assert.Equal("file_upload", fileUpload.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var fileUpload = await this.service.CreateAsync(FileName, this.stream, StripeFilePurpose.BusinessLogo);
            Assert.NotNull(fileUpload);
            Assert.Equal("file_upload", fileUpload.Object);
        }

        [Fact]
        public void Get()
        {
            var fileUpload = this.service.Get(FileUploadId);
            Assert.NotNull(fileUpload);
            Assert.Equal("file_upload", fileUpload.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var fileUpload = await this.service.GetAsync(FileUploadId);
            Assert.NotNull(fileUpload);
            Assert.Equal("file_upload", fileUpload.Object);
        }

        [Fact]
        public void List()
        {
            var fileUploads = this.service.List(this.listOptions);
            Assert.NotNull(fileUploads);
            Assert.Equal("list", fileUploads.Object);
            Assert.Single(fileUploads.Data);
            Assert.Equal("file_upload", fileUploads.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var fileUploads = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(fileUploads);
            Assert.Equal("list", fileUploads.Object);
            Assert.Single(fileUploads.Data);
            Assert.Equal("file_upload", fileUploads.Data[0].Object);
        }
    }
}
