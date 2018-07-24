namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class StripeTransferReversalServiceTest : BaseStripeTest
    {
        private const string TransferId = "tr_123";
        private const string TransferReversalId = "trr_123";

        private StripeTransferReversalService service;
        private StripeTransferReversalCreateOptions createOptions;
        private StripeTransferReversalUpdateOptions updateOptions;
        private StripeTransferReversalListOptions listOptions;

        public StripeTransferReversalServiceTest()
        {
            this.service = new StripeTransferReversalService();

            this.createOptions = new StripeTransferReversalCreateOptions()
            {
                Amount = 123,
            };

            this.updateOptions = new StripeTransferReversalUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new StripeTransferReversalListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var transferReversal = this.service.Create(TransferId, this.createOptions);
            Assert.NotNull(transferReversal);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var transferReversal = await this.service.CreateAsync(TransferId, this.createOptions);
            Assert.NotNull(transferReversal);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }

        [Fact]
        public void Get()
        {
            var transferReversal = this.service.Get(TransferId, TransferReversalId);
            Assert.NotNull(transferReversal);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var transferReversal = await this.service.GetAsync(TransferId, TransferReversalId);
            Assert.NotNull(transferReversal);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }

        [Fact]
        public void List()
        {
            var transfers = this.service.List(TransferId, this.listOptions);
            Assert.NotNull(transfers);
            Assert.Equal("list", transfers.Object);
            Assert.Single(transfers.Data);
            Assert.Equal("transfer_reversal", transfers.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var transfers = await this.service.ListAsync(TransferId, this.listOptions);
            Assert.NotNull(transfers);
            Assert.Equal("list", transfers.Object);
            Assert.Single(transfers.Data);
            Assert.Equal("transfer_reversal", transfers.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var transferReversal = this.service.Update(TransferId, TransferReversalId, this.updateOptions);
            Assert.NotNull(transferReversal);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var transferReversal = await this.service.UpdateAsync(TransferId, TransferReversalId, this.updateOptions);
            Assert.NotNull(transferReversal);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }
    }
}
