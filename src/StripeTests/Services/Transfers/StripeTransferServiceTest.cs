namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class StripeTransferServiceTest : BaseStripeTest
    {
        private const string TransferId = "tr_123";

        private StripeTransferService service;
        private StripeTransferCreateOptions createOptions;
        private StripeTransferUpdateOptions updateOptions;
        private StripeTransferListOptions listOptions;

        public StripeTransferServiceTest()
        {
            this.service = new StripeTransferService();

            this.createOptions = new StripeTransferCreateOptions()
            {
                Amount = 123,
                Currency = "usd",
                Destination = "acct_123",
            };

            this.updateOptions = new StripeTransferUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new StripeTransferListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var transfer = this.service.Create(this.createOptions);
            Assert.NotNull(transfer);
            Assert.Equal("transfer", transfer.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var transfer = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(transfer);
            Assert.Equal("transfer", transfer.Object);
        }

        [Fact]
        public void Get()
        {
            var transfer = this.service.Get(TransferId);
            Assert.NotNull(transfer);
            Assert.Equal("transfer", transfer.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var transfer = await this.service.GetAsync(TransferId);
            Assert.NotNull(transfer);
            Assert.Equal("transfer", transfer.Object);
        }

        [Fact]
        public void List()
        {
            var transfers = this.service.List(this.listOptions);
            Assert.NotNull(transfers);
            Assert.Equal("list", transfers.Object);
            Assert.Single(transfers.Data);
            Assert.Equal("transfer", transfers.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var transfers = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(transfers);
            Assert.Equal("list", transfers.Object);
            Assert.Single(transfers.Data);
            Assert.Equal("transfer", transfers.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var transfer = this.service.Update(TransferId, this.updateOptions);
            Assert.NotNull(transfer);
            Assert.Equal("transfer", transfer.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var transfer = await this.service.UpdateAsync(TransferId, this.updateOptions);
            Assert.NotNull(transfer);
            Assert.Equal("transfer", transfer.Object);
        }
    }
}
