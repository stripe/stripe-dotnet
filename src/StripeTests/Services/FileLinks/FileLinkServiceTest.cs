namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class FileLinkServiceTest : BaseStripeTest
    {
        private const string FileLinkId = "link_123";

        private readonly FileLinkService service;
        private readonly FileLinkCreateOptions createOptions;
        private readonly FileLinkUpdateOptions updateOptions;
        private readonly FileLinkListOptions listOptions;

        public FileLinkServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new FileLinkService(this.StripeClient);

            this.createOptions = new FileLinkCreateOptions
            {
                File = "file_123",
            };

            this.updateOptions = new FileLinkUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new FileLinkListOptions
            {
                File = "file_123",
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var fileLink = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/file_links");
            Assert.NotNull(fileLink);
            Assert.Equal("file_link", fileLink.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var fileLink = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/file_links");
            Assert.NotNull(fileLink);
            Assert.Equal("file_link", fileLink.Object);
        }

        [Fact]
        public void Get()
        {
            var fileLink = this.service.Get(FileLinkId);
            this.AssertRequest(HttpMethod.Get, "/v1/file_links/link_123");
            Assert.NotNull(fileLink);
            Assert.Equal("file_link", fileLink.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var fileLink = await this.service.GetAsync(FileLinkId);
            this.AssertRequest(HttpMethod.Get, "/v1/file_links/link_123");
            Assert.NotNull(fileLink);
            Assert.Equal("file_link", fileLink.Object);
        }

        [Fact]
        public void List()
        {
            var fileLinks = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/file_links");
            Assert.NotNull(fileLinks);
            Assert.Equal("list", fileLinks.Object);
            Assert.Single(fileLinks.Data);
            Assert.Equal("file_link", fileLinks.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var fileLinks = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/file_links");
            Assert.NotNull(fileLinks);
            Assert.Equal("list", fileLinks.Object);
            Assert.Single(fileLinks.Data);
            Assert.Equal("file_link", fileLinks.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var domain = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(domain);
            Assert.Equal("file_link", domain.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var domain = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(domain);
            Assert.Equal("file_link", domain.Object);
        }

        [Fact]
        public void Update()
        {
            var fileLink = this.service.Update(FileLinkId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/file_links/link_123");
            Assert.NotNull(fileLink);
            Assert.Equal("file_link", fileLink.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var fileLink = await this.service.UpdateAsync(FileLinkId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/file_links/link_123");
            Assert.NotNull(fileLink);
            Assert.Equal("file_link", fileLink.Object);
        }
    }
}
