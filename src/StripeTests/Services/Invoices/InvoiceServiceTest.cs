namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class InvoiceServiceTest : BaseStripeTest
    {
        private const string CustomerId = "cus_123";
        private const string InvoiceId = "in_123";

        private InvoiceService service;
        private InvoiceCreateOptions createOptions;
        private InvoiceUpdateOptions updateOptions;
        private InvoicePayOptions payOptions;
        private InvoiceListOptions listOptions;
        private InvoiceListLineItemsOptions listLineItemsOptions;
        private UpcomingInvoiceOptions upcomingOptions;

        public InvoiceServiceTest()
        {
            this.service = new InvoiceService();

            this.createOptions = new InvoiceCreateOptions()
            {
                TaxPercent = 12.5m,
            };

            this.updateOptions = new InvoiceUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.payOptions = new InvoicePayOptions()
            {
                Forgive = true,
                SourceId = "src_123",
            };

            this.listOptions = new InvoiceListOptions()
            {
                Limit = 1,
            };

            this.listLineItemsOptions = new InvoiceListLineItemsOptions()
            {
                Limit = 1,
            };

            this.upcomingOptions = new UpcomingInvoiceOptions()
            {
                SubscriptionId = "sub_123",
            };
        }

        [Fact]
        public void Create()
        {
            var invoice = this.service.Create(CustomerId, this.createOptions);
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var invoice = await this.service.CreateAsync(CustomerId, this.createOptions);
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public void Get()
        {
            var invoice = this.service.Get(InvoiceId);
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var invoice = await this.service.GetAsync(InvoiceId);
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public void List()
        {
            var invoices = this.service.List(this.listOptions);
            Assert.NotNull(invoices);
            Assert.Equal("list", invoices.Object);
            Assert.Single(invoices.Data);
            Assert.Equal("invoice", invoices.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var invoices = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(invoices);
            Assert.Equal("list", invoices.Object);
            Assert.Single(invoices.Data);
            Assert.Equal("invoice", invoices.Data[0].Object);
        }

        [Fact]
        public void ListLineItems()
        {
            var invoices = this.service.ListLineItems(InvoiceId, this.listLineItemsOptions);
            Assert.NotNull(invoices);
            Assert.Equal("list", invoices.Object);
            Assert.Single(invoices.Data);
            Assert.Equal("line_item", invoices.Data[0].Object);
        }

        [Fact]
        public async Task ListLineItemsAsync()
        {
            var invoices = await this.service.ListLineItemsAsync(InvoiceId, this.listLineItemsOptions);
            Assert.NotNull(invoices);
            Assert.Equal("list", invoices.Object);
            Assert.Single(invoices.Data);
            Assert.Equal("line_item", invoices.Data[0].Object);
        }

        [Fact]
        public void ListUpcomingLineItems()
        {
            var invoices = this.service.ListUpcomingLineItems(CustomerId, this.upcomingOptions);
            Assert.NotNull(invoices);
            Assert.Equal("list", invoices.Object);
            Assert.Single(invoices.Data);
            Assert.Equal("line_item", invoices.Data[0].Object);
        }

        [Fact]
        public async Task ListUpcomingLineItemsAsync()
        {
            var invoices = await this.service.ListUpcomingLineItemsAsync(CustomerId, this.upcomingOptions);
            Assert.NotNull(invoices);
            Assert.Equal("list", invoices.Object);
            Assert.Single(invoices.Data);
            Assert.Equal("line_item", invoices.Data[0].Object);
        }

        [Fact]
        public void Pay()
        {
            var invoice = this.service.Pay(InvoiceId, this.payOptions);
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task PayAsync()
        {
            var invoice = await this.service.PayAsync(InvoiceId, this.payOptions);
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public void Upcoming()
        {
            var invoice = this.service.Upcoming(CustomerId, this.upcomingOptions);
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task UpcomingAsync()
        {
            var invoice = await this.service.UpcomingAsync(CustomerId, this.upcomingOptions);
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public void Update()
        {
            var invoice = this.service.Update(InvoiceId, this.updateOptions);
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var invoice = await this.service.UpdateAsync(InvoiceId, this.updateOptions);
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }
    }
}
