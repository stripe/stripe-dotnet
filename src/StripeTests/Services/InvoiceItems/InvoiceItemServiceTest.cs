namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class InvoiceItemServiceTest : BaseStripeTest
    {
        private const string InvoiceItemId = "ii_123";

        private readonly InvoiceItemService service;
        private readonly InvoiceItemCreateOptions createOptions;
        private readonly InvoiceItemUpdateOptions updateOptions;
        private readonly InvoiceItemListOptions listOptions;

        public InvoiceItemServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new InvoiceItemService(this.StripeClient);

            this.createOptions = new InvoiceItemCreateOptions
            {
                Amount = 123,
                Currency = "usd",
                Customer = "cus_123",
            };

            this.updateOptions = new InvoiceItemUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new InvoiceItemListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var invoiceItem = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoiceitems");
            Assert.NotNull(invoiceItem);
            Assert.Equal("invoiceitem", invoiceItem.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var invoiceItem = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoiceitems");
            Assert.NotNull(invoiceItem);
            Assert.Equal("invoiceitem", invoiceItem.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(InvoiceItemId);
            this.AssertRequest(HttpMethod.Delete, "/v1/invoiceitems/ii_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(InvoiceItemId);
            this.AssertRequest(HttpMethod.Delete, "/v1/invoiceitems/ii_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var invoiceItem = this.service.Get(InvoiceItemId);
            this.AssertRequest(HttpMethod.Get, "/v1/invoiceitems/ii_123");
            Assert.NotNull(invoiceItem);
            Assert.Equal("invoiceitem", invoiceItem.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var invoiceItem = await this.service.GetAsync(InvoiceItemId);
            this.AssertRequest(HttpMethod.Get, "/v1/invoiceitems/ii_123");
            Assert.NotNull(invoiceItem);
            Assert.Equal("invoiceitem", invoiceItem.Object);
        }

        [Fact]
        public void List()
        {
            var invoiceItems = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/invoiceitems");
            Assert.NotNull(invoiceItems);
            Assert.Equal("list", invoiceItems.Object);
            Assert.Single(invoiceItems.Data);
            Assert.Equal("invoiceitem", invoiceItems.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var invoiceItems = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/invoiceitems");
            Assert.NotNull(invoiceItems);
            Assert.Equal("list", invoiceItems.Object);
            Assert.Single(invoiceItems.Data);
            Assert.Equal("invoiceitem", invoiceItems.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var invoiceItem = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(invoiceItem);
            Assert.Equal("invoiceitem", invoiceItem.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var invoiceItem = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(invoiceItem);
            Assert.Equal("invoiceitem", invoiceItem.Object);
        }

        [Fact]
        public void Update()
        {
            var invoiceItem = this.service.Update(InvoiceItemId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoiceitems/ii_123");
            Assert.NotNull(invoiceItem);
            Assert.Equal("invoiceitem", invoiceItem.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var invoiceItem = await this.service.UpdateAsync(InvoiceItemId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoiceitems/ii_123");
            Assert.NotNull(invoiceItem);
            Assert.Equal("invoiceitem", invoiceItem.Object);
        }
    }
}
