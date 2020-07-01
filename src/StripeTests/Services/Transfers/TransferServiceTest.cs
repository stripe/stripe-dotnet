namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class TransferServiceTest : BaseStripeTest
    {
        private const string TransferId = "tr_123";

        private readonly TransferService service;
        private readonly TransferCreateOptions createOptions;
        private readonly TransferUpdateOptions updateOptions;
        private readonly TransferListOptions listOptions;

        public TransferServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new TransferService(this.StripeClient);

            this.createOptions = new TransferCreateOptions
            {
                Amount = 123,
                Currency = "usd",
                Destination = "acct_123",
            };

            this.updateOptions = new TransferUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new TransferListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var transfer = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/transfers");
            Assert.NotNull(transfer);
            Assert.Equal("transfer", transfer.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var transfer = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/transfers");
            Assert.NotNull(transfer);
            Assert.Equal("transfer", transfer.Object);
        }

        [Fact]
        public void Get()
        {
            var transfer = this.service.Get(TransferId);
            this.AssertRequest(HttpMethod.Get, "/v1/transfers/tr_123");
            Assert.NotNull(transfer);
            Assert.Equal("transfer", transfer.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var transfer = await this.service.GetAsync(TransferId);
            this.AssertRequest(HttpMethod.Get, "/v1/transfers/tr_123");
            Assert.NotNull(transfer);
            Assert.Equal("transfer", transfer.Object);
        }

        [Fact]
        public void List()
        {
            var transfers = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/transfers");
            Assert.NotNull(transfers);
            Assert.Equal("list", transfers.Object);
            Assert.Single(transfers.Data);
            Assert.Equal("transfer", transfers.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var transfers = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/transfers");
            Assert.NotNull(transfers);
            Assert.Equal("list", transfers.Object);
            Assert.Single(transfers.Data);
            Assert.Equal("transfer", transfers.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var transfer = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(transfer);
            Assert.Equal("transfer", transfer.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var transfer = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(transfer);
            Assert.Equal("transfer", transfer.Object);
        }

        [Fact]
        public void Update()
        {
            var transfer = this.service.Update(TransferId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/transfers/tr_123");
            Assert.NotNull(transfer);
            Assert.Equal("transfer", transfer.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var transfer = await this.service.UpdateAsync(TransferId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/transfers/tr_123");
            Assert.NotNull(transfer);
            Assert.Equal("transfer", transfer.Object);
        }
    }
}
