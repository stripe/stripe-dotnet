namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class FileServiceTest : BaseStripeTest
    {
        private const string FileId = "file_123";
        private const string FileName = "StripeTests.Resources.file_upload_logo.png";

        private FileService service;
        private FileCreateOptions createOptions;
        private FileListOptions listOptions;

        public FileServiceTest()
        {
            this.service = new FileService();

            this.createOptions = new FileCreateOptions()
            {
                File = typeof(FileServiceTest).GetTypeInfo().Assembly.GetManifestResourceStream(FileName),
                Purpose = FilePurpose.BusinessLogo,
            };

            this.listOptions = new FileListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var file = this.service.Create(this.createOptions);
            Assert.NotNull(file);
            Assert.Equal("file", file.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var file = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(file);
            Assert.Equal("file", file.Object);
        }

        [Fact]
        public void Get()
        {
            var file = this.service.Get(FileId);
            Assert.NotNull(file);
            Assert.Equal("file", file.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var file = await this.service.GetAsync(FileId);
            Assert.NotNull(file);
            Assert.Equal("file", file.Object);
        }

        [Fact]
        public void List()
        {
            var files = this.service.List(this.listOptions);
            Assert.NotNull(files);
            Assert.Equal("list", files.Object);
            Assert.Single(files.Data);
            Assert.Equal("file", files.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var files = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(files);
            Assert.Equal("list", files.Object);
            Assert.Single(files.Data);
            Assert.Equal("file", files.Data[0].Object);
        }
    }
}
