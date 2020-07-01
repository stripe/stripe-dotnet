namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class DisputeServiceTest : BaseStripeTest
    {
        private const string DisputeId = "dp_123";

        private readonly DisputeService service;
        private readonly DisputeUpdateOptions updateOptions;
        private readonly DisputeListOptions listOptions;

        public DisputeServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new DisputeService(this.StripeClient);

            this.updateOptions = new DisputeUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new DisputeListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Close()
        {
            var dispute = this.service.Close(DisputeId);
            this.AssertRequest(HttpMethod.Post, "/v1/disputes/dp_123/close");
            Assert.NotNull(dispute);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public async Task CloseAsync()
        {
            var dispute = await this.service.CloseAsync(DisputeId);
            this.AssertRequest(HttpMethod.Post, "/v1/disputes/dp_123/close");
            Assert.NotNull(dispute);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public void Get()
        {
            var dispute = this.service.Get(DisputeId);
            this.AssertRequest(HttpMethod.Get, "/v1/disputes/dp_123");
            Assert.NotNull(dispute);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var dispute = await this.service.GetAsync(DisputeId);
            this.AssertRequest(HttpMethod.Get, "/v1/disputes/dp_123");
            Assert.NotNull(dispute);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public void List()
        {
            var disputes = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/disputes");
            Assert.NotNull(disputes);
            Assert.Equal("list", disputes.Object);
            Assert.Single(disputes.Data);
            Assert.Equal("dispute", disputes.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var disputes = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/disputes");
            Assert.NotNull(disputes);
            Assert.Equal("list", disputes.Object);
            Assert.Single(disputes.Data);
            Assert.Equal("dispute", disputes.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var dispute = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(dispute);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var dispute = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(dispute);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public void Update()
        {
            var dispute = this.service.Update(DisputeId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/disputes/dp_123");
            Assert.NotNull(dispute);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var dispute = await this.service.UpdateAsync(DisputeId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/disputes/dp_123");
            Assert.NotNull(dispute);
            Assert.Equal("dispute", dispute.Object);
        }
    }
}
