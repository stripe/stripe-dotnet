namespace StripeTests
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class InvoiceServiceTest : BaseStripeTest
    {
        private const string InvoiceId = "in_123";

        private InvoiceService service;
        private InvoiceCreateOptions createOptions;
        private InvoiceUpdateOptions updateOptions;
        private InvoicePayOptions payOptions;
        private InvoiceListOptions listOptions;
        private InvoiceListLineItemsOptions listLineItemsOptions;
        private UpcomingInvoiceOptions upcomingOptions;
        private InvoiceFinalizeOptions finalizeOptions;
        private InvoiceMarkUncollectibleOptions markUncollectibleOptions;
        private InvoiceSendOptions sendOptions;
        private InvoiceVoidOptions voidOptions;

        public InvoiceServiceTest()
        {
            this.service = new InvoiceService();

            this.createOptions = new InvoiceCreateOptions
            {
                CustomerId = "cus_123",
                TaxPercent = 12.5m,
            };

            this.updateOptions = new InvoiceUpdateOptions
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.payOptions = new InvoicePayOptions
            {
                Forgive = true,
                SourceId = "src_123",
            };

            this.listOptions = new InvoiceListOptions
            {
                Limit = 1,
            };

            this.listLineItemsOptions = new InvoiceListLineItemsOptions
            {
                Limit = 1,
            };

            this.upcomingOptions = new UpcomingInvoiceOptions
            {
                CustomerId = "cus_123",
                SubscriptionId = "sub_123",
            };

            this.finalizeOptions = new InvoiceFinalizeOptions
            {
            };

            this.markUncollectibleOptions = new InvoiceMarkUncollectibleOptions
            {
            };

            this.sendOptions = new InvoiceSendOptions
            {
            };

            this.voidOptions = new InvoiceVoidOptions
            {
            };
        }

        [Fact]
        public void Create()
        {
            var invoice = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var invoice = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public void Delete()
        {
            var invoice = this.service.Delete(InvoiceId);
            this.AssertRequest(HttpMethod.Delete, "/v1/invoices/in_123");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var invoice = await this.service.DeleteAsync(InvoiceId);
            this.AssertRequest(HttpMethod.Delete, "/v1/invoices/in_123");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public void FinalizeInvoice()
        {
            var invoice = this.service.FinalizeInvoice(InvoiceId, this.finalizeOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices/in_123/finalize");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task FinalizeInvoiceAsync()
        {
            var invoice = await this.service.FinalizeInvoiceAsync(InvoiceId, this.finalizeOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices/in_123/finalize");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public void Get()
        {
            var invoice = this.service.Get(InvoiceId);
            this.AssertRequest(HttpMethod.Get, "/v1/invoices/in_123");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var invoice = await this.service.GetAsync(InvoiceId);
            this.AssertRequest(HttpMethod.Get, "/v1/invoices/in_123");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public void List()
        {
            var invoices = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/invoices");
            Assert.NotNull(invoices);
            Assert.Equal("list", invoices.Object);
            Assert.Single(invoices.Data);
            Assert.Equal("invoice", invoices.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var invoices = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/invoices");
            Assert.NotNull(invoices);
            Assert.Equal("list", invoices.Object);
            Assert.Single(invoices.Data);
            Assert.Equal("invoice", invoices.Data[0].Object);
        }

        [Fact]
        public void ListLineItems()
        {
            var invoices = this.service.ListLineItems(InvoiceId, this.listLineItemsOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/invoices/in_123/lines");
            Assert.NotNull(invoices);
            Assert.Equal("list", invoices.Object);
            Assert.Single(invoices.Data);
            Assert.Equal("line_item", invoices.Data[0].Object);
        }

        [Fact]
        public async Task ListLineItemsAsync()
        {
            var invoices = await this.service.ListLineItemsAsync(InvoiceId, this.listLineItemsOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/invoices/in_123/lines");
            Assert.NotNull(invoices);
            Assert.Equal("list", invoices.Object);
            Assert.Single(invoices.Data);
            Assert.Equal("line_item", invoices.Data[0].Object);
        }

        [Fact]
        public void ListUpcomingLineItems()
        {
            var invoices = this.service.ListUpcomingLineItems(this.upcomingOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/invoices/upcoming/lines");
            Assert.NotNull(invoices);
            Assert.Equal("list", invoices.Object);
            Assert.Single(invoices.Data);
            Assert.Equal("line_item", invoices.Data[0].Object);
        }

        [Fact]
        public async Task ListUpcomingLineItemsAsync()
        {
            var invoices = await this.service.ListUpcomingLineItemsAsync(this.upcomingOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/invoices/upcoming/lines");
            Assert.NotNull(invoices);
            Assert.Equal("list", invoices.Object);
            Assert.Single(invoices.Data);
            Assert.Equal("line_item", invoices.Data[0].Object);
        }

        [Fact]
        public void MarkUncollectible()
        {
            var invoice = this.service.MarkUncollectible(InvoiceId, this.markUncollectibleOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices/in_123/mark_uncollectible");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task MarkUncollectibleAsync()
        {
            var invoice = await this.service.MarkUncollectibleAsync(InvoiceId, this.markUncollectibleOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices/in_123/mark_uncollectible");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public void Pay()
        {
            var invoice = this.service.Pay(InvoiceId, this.payOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices/in_123/pay");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task PayAsync()
        {
            var invoice = await this.service.PayAsync(InvoiceId, this.payOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices/in_123/pay");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public void SendInvoice()
        {
            var invoice = this.service.SendInvoice(InvoiceId, this.sendOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices/in_123/send");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task SendInvoiceAsync()
        {
            var invoice = await this.service.SendInvoiceAsync(InvoiceId, this.sendOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices/in_123/send");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public void Upcoming()
        {
            var invoice = this.service.Upcoming(this.upcomingOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/invoices/upcoming");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task UpcomingAsync()
        {
            var invoice = await this.service.UpcomingAsync(this.upcomingOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/invoices/upcoming");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public void Update()
        {
            var invoice = this.service.Update(InvoiceId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices/in_123");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var invoice = await this.service.UpdateAsync(InvoiceId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices/in_123");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public void VoidInvoice()
        {
            var invoice = this.service.VoidInvoice(InvoiceId, this.voidOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices/in_123/void");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public async Task VoidInvoiceAsync()
        {
            var invoice = await this.service.VoidInvoiceAsync(InvoiceId, this.voidOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/invoices/in_123/void");
            Assert.NotNull(invoice);
            Assert.Equal("invoice", invoice.Object);
        }
    }
}
