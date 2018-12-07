namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class PayoutServiceTest : BaseStripeTest
    {
        private const string PayoutId = "po_123";

        private readonly PayoutService service;
        private readonly PayoutCreateOptions createOptions;
        private readonly PayoutUpdateOptions updateOptions;
        private readonly PayoutListOptions listOptions;

        public PayoutServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new PayoutService();

            this.createOptions = new PayoutCreateOptions
            {
                Amount = 123,
                Currency = "usd",
            };

            this.updateOptions = new PayoutUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new PayoutListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var payout = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/payouts");
            Assert.NotNull(payout);
            Assert.Equal("payout", payout.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var payout = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/payouts");
            Assert.NotNull(payout);
            Assert.Equal("payout", payout.Object);
        }

        [Fact]
        public void Cancel()
        {
            var payout = this.service.Cancel(PayoutId);
            this.AssertRequest(HttpMethod.Post, "/v1/payouts/po_123/cancel");
            Assert.NotNull(payout);
            Assert.Equal("payout", payout.Object);
        }

        [Fact]
        public async Task CancelAsync()
        {
            var payout = await this.service.CancelAsync(PayoutId);
            this.AssertRequest(HttpMethod.Post, "/v1/payouts/po_123/cancel");
            Assert.NotNull(payout);
            Assert.Equal("payout", payout.Object);
        }

        [Fact]
        public void Get()
        {
            var payout = this.service.Get(PayoutId);
            this.AssertRequest(HttpMethod.Get, "/v1/payouts/po_123");
            Assert.NotNull(payout);
            Assert.Equal("payout", payout.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var payout = await this.service.GetAsync(PayoutId);
            this.AssertRequest(HttpMethod.Get, "/v1/payouts/po_123");
            Assert.NotNull(payout);
            Assert.Equal("payout", payout.Object);
        }

        [Fact]
        public void List()
        {
            var payouts = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/payouts");
            Assert.NotNull(payouts);
            Assert.Equal("list", payouts.Object);
            Assert.Single(payouts.Data);
            Assert.Equal("payout", payouts.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var payouts = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/payouts");
            Assert.NotNull(payouts);
            Assert.Equal("list", payouts.Object);
            Assert.Single(payouts.Data);
            Assert.Equal("payout", payouts.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var payouts = this.service.ListAutoPaging(this.listOptions).ToList();
            Assert.NotNull(payouts);
            Assert.Equal("payout", payouts[0].Object);
        }

        [Fact]
        public void Update()
        {
            var payout = this.service.Update(PayoutId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/payouts/po_123");
            Assert.NotNull(payout);
            Assert.Equal("payout", payout.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var payout = await this.service.UpdateAsync(PayoutId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/payouts/po_123");
            Assert.NotNull(payout);
            Assert.Equal("payout", payout.Object);
        }
    }
}
