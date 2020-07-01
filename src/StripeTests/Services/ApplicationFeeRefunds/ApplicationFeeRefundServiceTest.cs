namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class ApplicationFeeRefundServiceTest : BaseStripeTest
    {
        private const string ApplicationFeeId = "fee_123";
        private const string ApplicationFeeRefundId = "fr_123";

        private readonly ApplicationFeeRefundService service;
        private readonly ApplicationFeeRefundCreateOptions createOptions;
        private readonly ApplicationFeeRefundUpdateOptions updateOptions;
        private readonly ApplicationFeeRefundListOptions listOptions;

        public ApplicationFeeRefundServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new ApplicationFeeRefundService(this.StripeClient);

            this.createOptions = new ApplicationFeeRefundCreateOptions
            {
                Amount = 123,
            };

            this.updateOptions = new ApplicationFeeRefundUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new ApplicationFeeRefundListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var applicationFeeRefund = this.service.Create(
                ApplicationFeeId,
                this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/application_fees/fee_123/refunds");
            Assert.NotNull(applicationFeeRefund);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var applicationFeeRefund = await this.service.CreateAsync(
                ApplicationFeeId,
                this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/application_fees/fee_123/refunds");
            Assert.NotNull(applicationFeeRefund);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }

        [Fact]
        public void Get()
        {
            var applicationFeeRefund = this.service.Get(ApplicationFeeId, ApplicationFeeRefundId);
            this.AssertRequest(HttpMethod.Get, "/v1/application_fees/fee_123/refunds/fr_123");
            Assert.NotNull(applicationFeeRefund);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var applicationFeeRefund = await this.service.GetAsync(ApplicationFeeId, ApplicationFeeRefundId);
            this.AssertRequest(HttpMethod.Get, "/v1/application_fees/fee_123/refunds/fr_123");
            Assert.NotNull(applicationFeeRefund);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }

        [Fact]
        public void List()
        {
            var applicationFeeRefunds = this.service.List(ApplicationFeeId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/application_fees/fee_123/refunds");
            Assert.NotNull(applicationFeeRefunds);
            Assert.Equal("list", applicationFeeRefunds.Object);
            Assert.Single(applicationFeeRefunds.Data);
            Assert.Equal("fee_refund", applicationFeeRefunds.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var applicationFeeRefunds = await this.service.ListAsync(ApplicationFeeId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/application_fees/fee_123/refunds");
            Assert.NotNull(applicationFeeRefunds);
            Assert.Equal("list", applicationFeeRefunds.Object);
            Assert.Single(applicationFeeRefunds.Data);
            Assert.Equal("fee_refund", applicationFeeRefunds.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var applicationFeeRefund = this.service.ListAutoPaging(ApplicationFeeId, this.listOptions).First();
            Assert.NotNull(applicationFeeRefund);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var applicationFeeRefund = await this.service.ListAutoPagingAsync(ApplicationFeeId, this.listOptions).FirstAsync();
            Assert.NotNull(applicationFeeRefund);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }

        [Fact]
        public void Update()
        {
            var applicationFeeRefund = this.service.Update(
                ApplicationFeeId,
                ApplicationFeeRefundId,
                this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/application_fees/fee_123/refunds/fr_123");
            Assert.NotNull(applicationFeeRefund);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var applicationFeeRefund = await this.service.UpdateAsync(
                ApplicationFeeId,
                ApplicationFeeRefundId,
                this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/application_fees/fee_123/refunds/fr_123");
            Assert.NotNull(applicationFeeRefund);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }
    }
}
