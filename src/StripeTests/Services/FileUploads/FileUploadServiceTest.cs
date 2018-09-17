namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class FileUploadServiceTest : BaseStripeTest
    {
        private const string FileUploadId = "file_123";
        private const string FileName = "StripeTests.Resources.file_upload_logo.png";

        private FileUploadService service;
        private FileUploadCreateOptions createOptions;
        private FileUploadListOptions listOptions;

        public FileUploadServiceTest()
        {
            this.service = new FileUploadService();

            this.createOptions = new FileUploadCreateOptions()
            {
                File = typeof(FileUploadServiceTest).GetTypeInfo().Assembly.GetManifestResourceStream(FileName),
                Purpose = FilePurpose.BusinessLogo,
            };

            this.listOptions = new FileUploadListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var fileUpload = this.service.Create(createOptions);
            Assert.NotNull(fileUpload);
            Assert.Equal("file_upload", fileUpload.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var fileUpload = await this.service.CreateAsync(createOptions);
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
