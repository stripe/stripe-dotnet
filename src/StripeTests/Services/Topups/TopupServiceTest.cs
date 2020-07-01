namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class TopupServiceTest : BaseStripeTest
    {
        private const string TopupId = "tu_123";

        private readonly TopupService service;
        private readonly TopupCreateOptions createOptions;
        private readonly TopupUpdateOptions updateOptions;
        private readonly TopupListOptions listOptions;

        public TopupServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new TopupService(this.StripeClient);

            this.createOptions = new TopupCreateOptions
            {
                Amount = 123,
                Currency = "usd",
                StatementDescriptor = "descriptor",
            };

            this.updateOptions = new TopupUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new TopupListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Cancel()
        {
            var topup = this.service.Cancel(TopupId);
            this.AssertRequest(HttpMethod.Post, "/v1/topups/tu_123/cancel");
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public async Task CancelAsync()
        {
            var topup = await this.service.CancelAsync(TopupId);
            this.AssertRequest(HttpMethod.Post, "/v1/topups/tu_123/cancel");
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public void Create()
        {
            var topup = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/topups");
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var topup = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/topups");
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public void Get()
        {
            var topup = this.service.Get(TopupId);
            this.AssertRequest(HttpMethod.Get, "/v1/topups/tu_123");
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var topup = await this.service.GetAsync(TopupId);
            this.AssertRequest(HttpMethod.Get, "/v1/topups/tu_123");
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public void List()
        {
            var topups = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/topups");
            Assert.NotNull(topups);
            Assert.Equal("list", topups.Object);
            Assert.Single(topups.Data);
            Assert.Equal("topup", topups.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var topups = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/topups");
            Assert.NotNull(topups);
            Assert.Equal("list", topups.Object);
            Assert.Single(topups.Data);
            Assert.Equal("topup", topups.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var topup = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var topup = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public void Update()
        {
            var topup = this.service.Update(TopupId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/topups/tu_123");
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var topup = await this.service.UpdateAsync(TopupId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/topups/tu_123");
            Assert.NotNull(topup);
            Assert.Equal("topup", topup.Object);
        }
    }
}
