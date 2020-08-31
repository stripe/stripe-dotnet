namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class RefundServiceTest : BaseStripeTest
    {
        private const string RefundId = "re_123";

        private readonly RefundService service;
        private readonly RefundCreateOptions createOptions;
        private readonly RefundUpdateOptions updateOptions;
        private readonly RefundListOptions listOptions;

        public RefundServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new RefundService(this.StripeClient);

            this.createOptions = new RefundCreateOptions
            {
                Amount = 123,
                Charge = "ch_123",
            };

            this.updateOptions = new RefundUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new RefundListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var refund = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/refunds");
            Assert.NotNull(refund);
            Assert.Equal("refund", refund.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var refund = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/refunds");
            Assert.NotNull(refund);
            Assert.Equal("refund", refund.Object);
        }

        [Fact]
        public void Get()
        {
            var refund = this.service.Get(RefundId);
            this.AssertRequest(HttpMethod.Get, "/v1/refunds/re_123");
            Assert.NotNull(refund);
            Assert.Equal("refund", refund.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var refund = await this.service.GetAsync(RefundId);
            this.AssertRequest(HttpMethod.Get, "/v1/refunds/re_123");
            Assert.NotNull(refund);
            Assert.Equal("refund", refund.Object);
        }

        [Fact]
        public void List()
        {
            var refunds = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/refunds");
            Assert.NotNull(refunds);
            Assert.Equal("list", refunds.Object);
            Assert.Single(refunds.Data);
            Assert.Equal("refund", refunds.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var refunds = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/refunds");
            Assert.NotNull(refunds);
            Assert.Equal("list", refunds.Object);
            Assert.Single(refunds.Data);
            Assert.Equal("refund", refunds.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var refund = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(refund);
            Assert.Equal("refund", refund.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var refund = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(refund);
            Assert.Equal("refund", refund.Object);
        }

        [Fact]
        public void Update()
        {
            var refund = this.service.Update(RefundId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/refunds/re_123");
            Assert.NotNull(refund);
            Assert.Equal("refund", refund.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var refund = await this.service.UpdateAsync(RefundId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/refunds/re_123");
            Assert.NotNull(refund);
            Assert.Equal("refund", refund.Object);
        }
    }
}
