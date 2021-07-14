namespace StripeTests
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class QuoteServiceTest : BaseStripeTest
    {
        private const string QuoteId = "qt_123";

        private readonly QuoteService service;
        private readonly QuoteCreateOptions createOptions;
        private readonly QuoteUpdateOptions updateOptions;
        private readonly QuoteUpdateOptions updateOptionsWithCurrentPeriodEnd;
        private readonly QuoteUpdateOptions updateOptionsWithDateTime;
        private readonly QuoteListOptions listOptions;
        private readonly QuoteAcceptOptions acceptOptions;
        private readonly QuoteCancelOptions cancelOptions;
        private readonly QuoteFinalizeOptions finalizeOptions;
        private readonly QuoteListLineItemsOptions listLineItemsOptions;
        private readonly QuoteListComputedUpfrontLineItemsOptions listComputedUpfrontLineItemsOptions;
        private readonly QuotePdfOptions pdfOptions;

        public QuoteServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new QuoteService(this.StripeClient);

            this.createOptions = new QuoteCreateOptions
            {
                Customer = "cus_123",
            };

            this.updateOptions = new QuoteUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.updateOptionsWithCurrentPeriodEnd = new QuoteUpdateOptions
            {
                SubscriptionData = new QuoteSubscriptionDataOptions
                {
                    EffectiveDate = QuoteSubscriptionDataEffectiveDate.CurrentPeriodEnd,
                },
            };

            this.updateOptionsWithDateTime = new QuoteUpdateOptions
            {
                SubscriptionData = new QuoteSubscriptionDataOptions
                {
                    EffectiveDate = System.DateTime.Now,
                },
            };

            this.listOptions = new QuoteListOptions
            {
                Limit = 1,
            };

            this.acceptOptions = new QuoteAcceptOptions
            {
            };

            this.cancelOptions = new QuoteCancelOptions
            {
            };

            this.finalizeOptions = new QuoteFinalizeOptions
            {
            };

            this.listLineItemsOptions = new QuoteListLineItemsOptions
            {
                Limit = 1,
            };

            this.listComputedUpfrontLineItemsOptions = new QuoteListComputedUpfrontLineItemsOptions
            {
                Limit = 1,
            };

            this.pdfOptions = new QuotePdfOptions
            {
            };
        }

        [Fact]
        public void Create()
        {
            var quote = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes");
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var quote = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes");
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public void Accept()
        {
            var quote = this.service.Accept(QuoteId, this.acceptOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes/qt_123/accept");
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public async Task AcceptAsync()
        {
            var quote = await this.service.AcceptAsync(QuoteId, this.acceptOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes/qt_123/accept");
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public void Cancel()
        {
            var quote = this.service.Cancel(QuoteId, this.cancelOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes/qt_123/cancel");
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public async Task CancelAsync()
        {
            var quote = await this.service.CancelAsync(QuoteId, this.cancelOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes/qt_123/cancel");
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public void FinalizeQuote()
        {
            var quote = this.service.FinalizeQuote(QuoteId, this.finalizeOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes/qt_123/finalize");
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public async Task FinalizeQuoteAsync()
        {
            var quote = await this.service.FinalizeQuoteAsync(QuoteId, this.finalizeOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes/qt_123/finalize");
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public void Get()
        {
            var quote = this.service.Get(QuoteId);
            this.AssertRequest(HttpMethod.Get, "/v1/quotes/qt_123");
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var quote = await this.service.GetAsync(QuoteId);
            this.AssertRequest(HttpMethod.Get, "/v1/quotes/qt_123");
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public void List()
        {
            var quotes = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/quotes");
            Assert.NotNull(quotes);
            Assert.Equal("list", quotes.Object);
            Assert.Single(quotes.Data);
            Assert.Equal("quote", quotes.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var quotes = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/quotes");
            Assert.NotNull(quotes);
            Assert.Equal("list", quotes.Object);
            Assert.Single(quotes.Data);
            Assert.Equal("quote", quotes.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var quote = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var quote = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public void ListLineItems()
        {
            var lineItems = this.service.ListLineItems(QuoteId, this.listLineItemsOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/quotes/qt_123/line_items");
            Assert.NotNull(lineItems);
            Assert.Equal("list", lineItems.Object);
            Assert.Single(lineItems.Data);
            Assert.Equal("item", lineItems.Data[0].Object);
        }

        [Fact]
        public async Task ListLineItemsAsync()
        {
            var lineItems = await this.service.ListLineItemsAsync(QuoteId, this.listLineItemsOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/quotes/qt_123/line_items");
            Assert.NotNull(lineItems);
            Assert.Equal("list", lineItems.Object);
            Assert.Single(lineItems.Data);
            Assert.Equal("item", lineItems.Data[0].Object);
        }

        [Fact]
        public void ListLineItemsAutoPaging()
        {
            var lineItem = this.service.ListLineItemsAutoPaging(QuoteId, this.listLineItemsOptions).First();
            Assert.NotNull(lineItem);
            Assert.Equal("item", lineItem.Object);
        }

        [Fact]
        public async Task ListLineItemsAutoPagingAsync()
        {
            var lineItem = await this.service.ListLineItemsAutoPagingAsync(QuoteId, this.listLineItemsOptions).FirstAsync();
            Assert.NotNull(lineItem);
            Assert.Equal("item", lineItem.Object);
        }

        [Fact]
        public void ListComputedUpfrontLineItems()
        {
            var lineItems = this.service.ListComputedUpfrontLineItems(QuoteId, this.listComputedUpfrontLineItemsOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/quotes/qt_123/computed_upfront_line_items");
            Assert.NotNull(lineItems);
            Assert.Equal("list", lineItems.Object);
            Assert.Single(lineItems.Data);
            Assert.Equal("item", lineItems.Data[0].Object);
        }

        [Fact]
        public async Task ListComputedUpfrontLineItemsAsync()
        {
            var lineItems = await this.service.ListComputedUpfrontLineItemsAsync(QuoteId, this.listComputedUpfrontLineItemsOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/quotes/qt_123/computed_upfront_line_items");
            Assert.NotNull(lineItems);
            Assert.Equal("list", lineItems.Object);
            Assert.Single(lineItems.Data);
            Assert.Equal("item", lineItems.Data[0].Object);
        }

        [Fact]
        public void ListComputedUpfrontLineItemsAutoPaging()
        {
            var lineItem = this.service.ListComputedUpfrontLineItemsAutoPaging(QuoteId, this.listComputedUpfrontLineItemsOptions).First();
            Assert.NotNull(lineItem);
            Assert.Equal("item", lineItem.Object);
        }

        [Fact]
        public async Task ListComputedUpfrontLineItemsAutoPagingAsync()
        {
            var lineItem = await this.service.ListComputedUpfrontLineItemsAutoPagingAsync(QuoteId, this.listComputedUpfrontLineItemsOptions).FirstAsync();
            Assert.NotNull(lineItem);
            Assert.Equal("item", lineItem.Object);
        }

        [Fact]
        public void Pdf()
        {
            var stream = this.service.Pdf(QuoteId, this.pdfOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/quotes/qt_123/pdf");
            Assert.Equal("Stripe binary response", new StreamReader(stream).ReadToEnd());
        }

        [Fact]
        public async Task PdfAsync()
        {
            var stream = await this.service.PdfAsync(QuoteId, this.pdfOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/quotes/qt_123/pdf");
            Assert.Equal("Stripe binary response", new StreamReader(stream).ReadToEnd());
        }

        [Fact]
        public void Update()
        {
            var quote = this.service.Update(QuoteId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes/qt_123");
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var quote = await this.service.UpdateAsync(QuoteId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes/qt_123");
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public void UpdateWithCurrentPeriodEnd()
        {
            var quote = this.service.Update(QuoteId, this.updateOptionsWithCurrentPeriodEnd);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes/qt_123");
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }

        [Fact]
        public void UpdateWithDateTime()
        {
            var quote = this.service.Update(QuoteId, this.updateOptionsWithDateTime);
            this.AssertRequest(HttpMethod.Post, "/v1/quotes/qt_123");
            Assert.NotNull(quote);
            Assert.Equal("quote", quote.Object);
        }
    }
}
