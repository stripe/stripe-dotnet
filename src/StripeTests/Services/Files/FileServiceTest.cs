namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Reflection;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class FileServiceTest : BaseStripeTest
    {
        private const string FileId = "file_123";
        private const string FileName = "StripeTests.Resources.file_upload_logo.png";

        private readonly FileService service;
        private readonly FileCreateOptions createOptions;
        private readonly FileListOptions listOptions;

        public FileServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new FileService(this.StripeClient);

            this.createOptions = new FileCreateOptions
            {
                File = typeof(FileServiceTest).GetTypeInfo().Assembly.GetManifestResourceStream(FileName),
                FileLinkData = new FileLinkDataOptions
                {
                    Create = true,
                    Metadata = new Dictionary<string, string>
                    {
                        { "key", "value" },
                    },
                },
                Purpose = FilePurpose.BusinessLogo,
            };

            this.listOptions = new FileListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var file = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/files");
            Assert.NotNull(file);
            Assert.Equal("file", file.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var file = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/files");
            Assert.NotNull(file);
            Assert.Equal("file", file.Object);
        }

        [Fact]
        public void Get()
        {
            var file = this.service.Get(FileId);
            this.AssertRequest(HttpMethod.Get, "/v1/files/file_123");
            Assert.NotNull(file);
            Assert.Equal("file", file.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var file = await this.service.GetAsync(FileId);
            this.AssertRequest(HttpMethod.Get, "/v1/files/file_123");
            Assert.NotNull(file);
            Assert.Equal("file", file.Object);
        }

        [Fact]
        public void List()
        {
            var files = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/files");
            Assert.NotNull(files);
            Assert.Equal("list", files.Object);
            Assert.Single(files.Data);
            Assert.Equal("file", files.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var files = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/files");
            Assert.NotNull(files);
            Assert.Equal("list", files.Object);
            Assert.Single(files.Data);
            Assert.Equal("file", files.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var file = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(file);
            Assert.Equal("file", file.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var file = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(file);
            Assert.Equal("file", file.Object);
        }
    }
}
