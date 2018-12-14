namespace StripeTests
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class TransferReversalServiceTest : BaseStripeTest
    {
        private const string TransferId = "tr_123";
        private const string TransferReversalId = "trr_123";

        private readonly TransferReversalService service;
        private readonly TransferReversalCreateOptions createOptions;
        private readonly TransferReversalUpdateOptions updateOptions;
        private readonly TransferReversalListOptions listOptions;

        public TransferReversalServiceTest()
        {
            this.service = new TransferReversalService();

            this.createOptions = new TransferReversalCreateOptions
            {
                Amount = 123,
            };

            this.updateOptions = new TransferReversalUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new TransferReversalListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var transferReversal = this.service.Create(TransferId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/transfers/tr_123/reversals");
            Assert.NotNull(transferReversal);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var transferReversal = await this.service.CreateAsync(TransferId, this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/transfers/tr_123/reversals");
            Assert.NotNull(transferReversal);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }

        [Fact]
        public void Get()
        {
            var transferReversal = this.service.Get(TransferId, TransferReversalId);
            this.AssertRequest(HttpMethod.Get, "/v1/transfers/tr_123/reversals/trr_123");
            Assert.NotNull(transferReversal);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var transferReversal = await this.service.GetAsync(TransferId, TransferReversalId);
            this.AssertRequest(HttpMethod.Get, "/v1/transfers/tr_123/reversals/trr_123");
            Assert.NotNull(transferReversal);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }

        [Fact]
        public void List()
        {
            var transfers = this.service.List(TransferId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/transfers/tr_123/reversals");
            Assert.NotNull(transfers);
            Assert.Equal("list", transfers.Object);
            Assert.Single(transfers.Data);
            Assert.Equal("transfer_reversal", transfers.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var transfers = await this.service.ListAsync(TransferId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/transfers/tr_123/reversals");
            Assert.NotNull(transfers);
            Assert.Equal("list", transfers.Object);
            Assert.Single(transfers.Data);
            Assert.Equal("transfer_reversal", transfers.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var transferReversal = this.service.Update(TransferId, TransferReversalId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/transfers/tr_123/reversals/trr_123");
            Assert.NotNull(transferReversal);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var transferReversal = await this.service.UpdateAsync(TransferId, TransferReversalId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/transfers/tr_123/reversals/trr_123");
            Assert.NotNull(transferReversal);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }
    }
}
