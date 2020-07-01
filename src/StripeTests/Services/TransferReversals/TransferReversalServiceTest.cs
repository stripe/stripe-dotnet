namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
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

        public TransferReversalServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new TransferReversalService(this.StripeClient);

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
            var transferReversals = this.service.List(TransferId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/transfers/tr_123/reversals");
            Assert.NotNull(transferReversals);
            Assert.Equal("list", transferReversals.Object);
            Assert.Single(transferReversals.Data);
            Assert.Equal("transfer_reversal", transferReversals.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var transferReversals = await this.service.ListAsync(TransferId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/transfers/tr_123/reversals");
            Assert.NotNull(transferReversals);
            Assert.Equal("list", transferReversals.Object);
            Assert.Single(transferReversals.Data);
            Assert.Equal("transfer_reversal", transferReversals.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var transferReversal = this.service.ListAutoPaging(TransferId, this.listOptions).First();
            Assert.NotNull(transferReversal);
            Assert.Equal("transfer_reversal", transferReversal.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var transferReversal = await this.service.ListAutoPagingAsync(TransferId, this.listOptions).FirstAsync();
            Assert.NotNull(transferReversal);
            Assert.Equal("transfer_reversal", transferReversal.Object);
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
