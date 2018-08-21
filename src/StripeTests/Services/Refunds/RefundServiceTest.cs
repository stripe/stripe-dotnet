namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class RefundServiceTest : BaseStripeTest
    {
        private const string ChargeId = "ch_123";
        private const string RefundId = "re_123";

        private RefundService service;
        private RefundCreateOptions createOptions;
        private RefundUpdateOptions updateOptions;
        private RefundListOptions listOptions;

        public RefundServiceTest()
        {
            this.service = new RefundService();

            this.createOptions = new RefundCreateOptions()
            {
                Amount = 123,
            };

            this.updateOptions = new RefundUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new RefundListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var refund = this.service.Create(ChargeId, this.createOptions);
            Assert.NotNull(refund);
            Assert.Equal("refund", refund.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var refund = await this.service.CreateAsync(ChargeId, this.createOptions);
            Assert.NotNull(refund);
            Assert.Equal("refund", refund.Object);
        }

        [Fact]
        public void Get()
        {
            var refund = this.service.Get(RefundId);
            Assert.NotNull(refund);
            Assert.Equal("refund", refund.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var refund = await this.service.GetAsync(RefundId);
            Assert.NotNull(refund);
            Assert.Equal("refund", refund.Object);
        }

        [Fact]
        public void List()
        {
            var refunds = this.service.List(this.listOptions);
            Assert.NotNull(refunds);
            Assert.Equal("list", refunds.Object);
            Assert.Single(refunds.Data);
            Assert.Equal("refund", refunds.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var refunds = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(refunds);
            Assert.Equal("list", refunds.Object);
            Assert.Single(refunds.Data);
            Assert.Equal("refund", refunds.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var refund = this.service.Update(RefundId, this.updateOptions);
            Assert.NotNull(refund);
            Assert.Equal("refund", refund.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var refund = await this.service.UpdateAsync(RefundId, this.updateOptions);
            Assert.NotNull(refund);
            Assert.Equal("refund", refund.Object);
        }
    }
}
