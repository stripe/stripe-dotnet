namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class CreditNoteServiceTest : BaseStripeTest
    {
        private const string CreditNoteId = "cn_123";

        private readonly CreditNoteService service;
        private readonly CreditNoteCreateOptions createOptions;
        private readonly CreditNoteUpdateOptions updateOptions;
        private readonly CreditNoteListOptions listOptions;
        private readonly CreditNoteListLineItemsOptions listLineItemsOptions;
        private readonly CreditNotePreviewOptions previewOptions;
        private readonly CreditNoteListPreviewLineItemsOptions listPreviewLineItemsOptions;
        private readonly CreditNoteVoidOptions voidOptions;

        public CreditNoteServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new CreditNoteService(this.StripeClient);

            this.createOptions = new CreditNoteCreateOptions
            {
                Amount = 100,
                Invoice = "in_123",
                Reason = "duplicate",
            };

            this.updateOptions = new CreditNoteUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new CreditNoteListOptions
            {
                Limit = 1,
                Invoice = "in_123",
            };

            this.listLineItemsOptions = new CreditNoteListLineItemsOptions
            {
                Limit = 1,
            };

            this.previewOptions = new CreditNotePreviewOptions
            {
                Amount = 1000,
                Invoice = "in_123",
            };

            this.listPreviewLineItemsOptions = new CreditNoteListPreviewLineItemsOptions
            {
                Amount = 1000,
                Invoice = "in_123",
            };

            this.voidOptions = new CreditNoteVoidOptions
            {
            };
        }

        [Fact]
        public void Create()
        {
            var creditNote = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/credit_notes");
            Assert.NotNull(creditNote);
            Assert.Equal("credit_note", creditNote.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var creditNote = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/credit_notes");
            Assert.NotNull(creditNote);
            Assert.Equal("credit_note", creditNote.Object);
        }

        [Fact]
        public void Get()
        {
            var creditNote = this.service.Get(CreditNoteId);
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes/cn_123");
            Assert.NotNull(creditNote);
            Assert.Equal("credit_note", creditNote.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var creditNote = await this.service.GetAsync(CreditNoteId);
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes/cn_123");
            Assert.NotNull(creditNote);
            Assert.Equal("credit_note", creditNote.Object);
        }

        [Fact]
        public void List()
        {
            var creditNotes = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes");
            Assert.NotNull(creditNotes);
            Assert.Equal("list", creditNotes.Object);
            Assert.Single(creditNotes.Data);
            Assert.Equal("credit_note", creditNotes.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var creditNotes = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes");
            Assert.NotNull(creditNotes);
            Assert.Equal("list", creditNotes.Object);
            Assert.Single(creditNotes.Data);
            Assert.Equal("credit_note", creditNotes.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var creditNote = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(creditNote);
            Assert.Equal("credit_note", creditNote.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var creditNote = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(creditNote);
            Assert.Equal("credit_note", creditNote.Object);
        }

        [Fact]
        public void ListLineItems()
        {
            var lineItems = this.service.ListLineItems(CreditNoteId, this.listLineItemsOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes/cn_123/lines");
            Assert.NotNull(lineItems);
            Assert.Equal("list", lineItems.Object);
            Assert.Single(lineItems.Data);
            Assert.Equal("credit_note_line_item", lineItems.Data[0].Object);
        }

        [Fact]
        public async Task ListLineItemsAsync()
        {
            var lineItems = await this.service.ListLineItemsAsync(CreditNoteId, this.listLineItemsOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes/cn_123/lines");
            Assert.NotNull(lineItems);
            Assert.Equal("list", lineItems.Object);
            Assert.Single(lineItems.Data);
            Assert.Equal("credit_note_line_item", lineItems.Data[0].Object);
        }

        [Fact]
        public void ListLineItemsAutoPaging()
        {
            var lineItem = this.service.ListLineItemsAutoPaging(CreditNoteId, this.listLineItemsOptions).First();
            Assert.NotNull(lineItem);
            Assert.Equal("credit_note_line_item", lineItem.Object);
        }

        [Fact]
        public async Task ListLineItemsAutoPagingAsync()
        {
            var lineItem = await this.service.ListLineItemsAutoPagingAsync(CreditNoteId, this.listLineItemsOptions).FirstAsync();
            Assert.NotNull(lineItem);
            Assert.Equal("credit_note_line_item", lineItem.Object);
        }

        [Fact]
        public void Preview()
        {
            var creditNote = this.service.Preview(this.previewOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes/preview");
            Assert.NotNull(creditNote);
            Assert.Equal("credit_note", creditNote.Object);
        }

        [Fact]
        public async Task PreviewAsync()
        {
            var creditNote = await this.service.PreviewAsync(this.previewOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes/preview");
            Assert.NotNull(creditNote);
            Assert.Equal("credit_note", creditNote.Object);
        }

        [Fact]
        public void ListPreviewLineItems()
        {
            var lineItems = this.service.ListPreviewLineItems(this.listPreviewLineItemsOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes/preview/lines");
            Assert.NotNull(lineItems);
            Assert.Equal("list", lineItems.Object);
            Assert.Single(lineItems.Data);
            Assert.Equal("credit_note_line_item", lineItems.Data[0].Object);
        }

        [Fact]
        public async Task ListPreviewLineItemsAsync()
        {
            var lineItems = await this.service.ListPreviewLineItemsAsync(this.listPreviewLineItemsOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/credit_notes/preview/lines");
            Assert.NotNull(lineItems);
            Assert.Equal("list", lineItems.Object);
            Assert.Single(lineItems.Data);
            Assert.Equal("credit_note_line_item", lineItems.Data[0].Object);
        }

        [Fact]
        public void ListPreviewLineItemsAutoPaging()
        {
            var lineItem = this.service.ListPreviewLineItemsAutoPaging(this.listPreviewLineItemsOptions).First();
            Assert.NotNull(lineItem);
            Assert.Equal("credit_note_line_item", lineItem.Object);
        }

        [Fact]
        public async Task ListPreviewLineItemsAutoPagingAsync()
        {
            var lineItem = await this.service.ListPreviewLineItemsAutoPagingAsync(this.listPreviewLineItemsOptions).FirstAsync();
            Assert.NotNull(lineItem);
            Assert.Equal("credit_note_line_item", lineItem.Object);
        }

        [Fact]
        public void Update()
        {
            var creditNote = this.service.Update(CreditNoteId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/credit_notes/cn_123");
            Assert.NotNull(creditNote);
            Assert.Equal("credit_note", creditNote.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var creditNote = await this.service.UpdateAsync(CreditNoteId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/credit_notes/cn_123");
            Assert.NotNull(creditNote);
            Assert.Equal("credit_note", creditNote.Object);
        }

        [Fact]
        public void VoidCreditNote()
        {
            var creditNote = this.service.VoidCreditNote(CreditNoteId, this.voidOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/credit_notes/cn_123/void");
            Assert.NotNull(creditNote);
            Assert.Equal("credit_note", creditNote.Object);
        }

        [Fact]
        public async Task VoidCreditNoteAsync()
        {
            var creditNote = await this.service.VoidCreditNoteAsync(CreditNoteId, this.voidOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/credit_notes/cn_123/void");
            Assert.NotNull(creditNote);
            Assert.Equal("credit_note", creditNote.Object);
        }
    }
}
