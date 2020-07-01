namespace StripeTests.Terminal
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Stripe.Terminal;
    using Xunit;

    public class ReaderServiceTest : BaseStripeTest
    {
        private const string ReaderId = "ds_123";

        private readonly ReaderService service;
        private readonly ReaderCreateOptions createOptions;
        private readonly ReaderListOptions listOptions;
        private readonly ReaderUpdateOptions updateOptions;

        public ReaderServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new ReaderService(this.StripeClient);

            this.createOptions = new ReaderCreateOptions
            {
                Label = "my_reader",
                Location = "loc_123",
                RegistrationCode = "a-b-c",
            };

            this.listOptions = new ReaderListOptions
            {
                Location = "loc_123",
            };

            this.updateOptions = new ReaderUpdateOptions
            {
                Label = "my_reader_update",
            };
        }

        [Fact]
        public void Create()
        {
            var reader = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/readers");
            Assert.NotNull(reader);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var reader = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/readers");
            Assert.NotNull(reader);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(ReaderId);
            this.AssertRequest(HttpMethod.Delete, "/v1/terminal/readers/ds_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(ReaderId);
            this.AssertRequest(HttpMethod.Delete, "/v1/terminal/readers/ds_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var reader = this.service.Get(ReaderId);
            this.AssertRequest(HttpMethod.Get, "/v1/terminal/readers/ds_123");
            Assert.NotNull(reader);
        }

        [Fact]
        public async Task GetAsync()
        {
            var reader = await this.service.GetAsync(ReaderId);
            this.AssertRequest(HttpMethod.Get, "/v1/terminal/readers/ds_123");
            Assert.NotNull(reader);
        }

        [Fact]
        public void List()
        {
            var readers = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/terminal/readers");
            Assert.NotNull(readers);
        }

        [Fact]
        public async Task ListAsync()
        {
            var readers = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/terminal/readers");
            Assert.NotNull(readers);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var reader = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(reader);
            Assert.Equal("terminal.reader", reader.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var reader = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(reader);
            Assert.Equal("terminal.reader", reader.Object);
        }

        [Fact]
        public void Update()
        {
            var reader = this.service.Update(ReaderId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/readers/ds_123");
            Assert.NotNull(reader);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var reader = await this.service.UpdateAsync(ReaderId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/terminal/readers/ds_123");
            Assert.NotNull(reader);
        }
    }
}
