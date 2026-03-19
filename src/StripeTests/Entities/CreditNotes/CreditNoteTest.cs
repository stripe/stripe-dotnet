namespace StripeTests
{
    using System.Text.Json;
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
            var creditNote = JsonSerializer.Deserialize<CreditNote>(json);
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
              "customer_balance_transaction",
              "invoice",
              "refund",
            };

            string json = this.GetFixture("/v1/credit_notes/cn_123456", expansions);
            var creditNote = JsonSerializer.Deserialize<CreditNote>(json);
            Assert.NotNull(creditNote);
            Assert.IsType<CreditNote>(creditNote);
            Assert.NotNull(creditNote.Id);
            Assert.Equal("credit_note", creditNote.Object);

            Assert.NotNull(creditNote.Customer);
            Assert.Equal("customer", creditNote.Customer.Object);

            Assert.NotNull(creditNote.CustomerBalanceTransaction);
            Assert.Equal("customer_balance_transaction", creditNote.CustomerBalanceTransaction.Object);

            Assert.NotNull(creditNote.Invoice);
            Assert.Equal("invoice", creditNote.Invoice.Object);
        }
    }
}
