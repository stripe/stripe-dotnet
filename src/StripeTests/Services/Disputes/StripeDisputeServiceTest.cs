namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class StripeDisputeServiceTest : BaseStripeTest
    {
        private const string DisputeId = "dp_123";

        private StripeDisputeService service;
        private StripeDisputeUpdateOptions updateOptions;
        private StripeDisputeListOptions listOptions;

        public StripeDisputeServiceTest()
        {
            this.service = new StripeDisputeService();

            this.updateOptions = new StripeDisputeUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new StripeDisputeListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Close()
        {
            var dispute = this.service.Close(DisputeId);
            Assert.NotNull(dispute);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public async Task CloseAsync()
        {
            var dispute = await this.service.CloseAsync(DisputeId);
            Assert.NotNull(dispute);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public void Get()
        {
            var dispute = this.service.Get(DisputeId);
            Assert.NotNull(dispute);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var dispute = await this.service.GetAsync(DisputeId);
            Assert.NotNull(dispute);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public void List()
        {
            var disputes = this.service.List(this.listOptions);
            Assert.NotNull(disputes);
            Assert.Equal("list", disputes.Object);
            Assert.Single(disputes.Data);
            Assert.Equal("dispute", disputes.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var disputes = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(disputes);
            Assert.Equal("list", disputes.Object);
            Assert.Single(disputes.Data);
            Assert.Equal("dispute", disputes.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var dispute = this.service.Update(DisputeId, this.updateOptions);
            Assert.NotNull(dispute);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var dispute = await this.service.UpdateAsync(DisputeId, this.updateOptions);
            Assert.NotNull(dispute);
            Assert.Equal("dispute", dispute.Object);
        }
    }
}
