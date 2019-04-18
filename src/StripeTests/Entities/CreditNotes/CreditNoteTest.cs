namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class CreditNoteTest : BaseStripeTest
    {
        public CreditNoteTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/credit_notes/cn_123");
            var creditNote = JsonConvert.DeserializeObject<CreditNote>(json);
            Assert.NotNull(creditNote);
            Assert.IsType<CreditNote>(creditNote);
            Assert.NotNull(creditNote.Id);
            Assert.Equal("credit_note", creditNote.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "customer",
              "invoice",
              "refund",
            };

            string json = this.GetFixture("/v1/credit_notes/cn_123", expansions);
            var creditNote = JsonConvert.DeserializeObject<CreditNote>(json);
            Assert.NotNull(creditNote);
            Assert.IsType<CreditNote>(creditNote);
            Assert.NotNull(creditNote.Id);
            Assert.Equal("credit_note", creditNote.Object);

            Assert.NotNull(creditNote.Customer);
            Assert.Equal("customer", creditNote.Customer.Object);

            Assert.NotNull(creditNote.Invoice);
            Assert.Equal("invoice", creditNote.Invoice.Object);

            Assert.NotNull(creditNote.Refund);
            Assert.Equal("refund", creditNote.Refund.Object);
        }
    }
}
