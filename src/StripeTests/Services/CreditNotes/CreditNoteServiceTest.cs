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
        private readonly CreditNoteVoidOptions voidOptions;

        public CreditNoteServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new CreditNoteService();

            this.createOptions = new CreditNoteCreateOptions
            {
                Amount = 100,
                InvoiceId = "in_123",
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
                InvoiceId = "in_123",
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
            var creditNotes = this.service.ListAutoPaging(this.listOptions).ToList();
            Assert.NotNull(creditNotes);
            Assert.Equal("credit_note", creditNotes[0].Object);
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
