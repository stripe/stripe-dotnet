namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class FileLinkServiceTest : BaseStripeTest
    {
        private const string FileLinkId = "link_123";

        private FileLinkService service;
        private FileLinkCreateOptions createOptions;
        private FileLinkUpdateOptions updateOptions;
        private FileLinkListOptions listOptions;

        public FileLinkServiceTest()
        {
            this.service = new FileLinkService();

            this.createOptions = new FileLinkCreateOptions()
            {
                FileId = "file_123",
            };

            this.updateOptions = new FileLinkUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new FileLinkListOptions()
            {
                FileId = "file_123",
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var fileLink = this.service.Create(this.createOptions);
            Assert.NotNull(fileLink);
            Assert.Equal("file_link", fileLink.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var fileLink = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(fileLink);
            Assert.Equal("file_link", fileLink.Object);
        }

        [Fact]
        public void Get()
        {
            var fileLink = this.service.Get(FileLinkId);
            Assert.NotNull(fileLink);
            Assert.Equal("file_link", fileLink.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var fileLink = await this.service.GetAsync(FileLinkId);
            Assert.NotNull(fileLink);
            Assert.Equal("file_link", fileLink.Object);
        }

        [Fact]
        public void List()
        {
            var fileLinks = this.service.List(this.listOptions);
            Assert.NotNull(fileLinks);
            Assert.Equal("list", fileLinks.Object);
            Assert.Single(fileLinks.Data);
            Assert.Equal("file_link", fileLinks.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var fileLinks = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(fileLinks);
            Assert.Equal("list", fileLinks.Object);
            Assert.Single(fileLinks.Data);
            Assert.Equal("file_link", fileLinks.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var fileLink = this.service.Update(FileLinkId, this.updateOptions);
            Assert.NotNull(fileLink);
            Assert.Equal("file_link", fileLink.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var fileLink = await this.service.UpdateAsync(FileLinkId, this.updateOptions);
            Assert.NotNull(fileLink);
            Assert.Equal("file_link", fileLink.Object);
        }
    }
}
