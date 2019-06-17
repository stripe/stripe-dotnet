namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class CustomerBalanceTransactionTest : BaseStripeTest
    {
        public CustomerBalanceTransactionTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/customers/cus_123/balance_transactions/cbtxn_123");
            var transaction = JsonConvert.DeserializeObject<CustomerBalanceTransaction>(json);
            Assert.NotNull(transaction);
            Assert.IsType<CustomerBalanceTransaction>(transaction);
            Assert.NotNull(transaction.Id);
            Assert.Equal("customer_balance_transaction", transaction.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "credit_note",
              "customer",
              "invoice",
            };

            string json = this.GetFixture("/v1/customers/cus_123/balance_transactions/cbtxn_123", expansions);
            var transaction = JsonConvert.DeserializeObject<CustomerBalanceTransaction>(json);
            Assert.NotNull(transaction);
            Assert.IsType<CustomerBalanceTransaction>(transaction);
            Assert.NotNull(transaction.Id);
            Assert.Equal("customer_balance_transaction", transaction.Object);

            Assert.NotNull(transaction.CreditNote);
            Assert.Equal("credit_note", transaction.CreditNote.Object);

            Assert.NotNull(transaction.Customer);
            Assert.Equal("customer", transaction.Customer.Object);

            Assert.NotNull(transaction.Invoice);
            Assert.Equal("invoice", transaction.Invoice.Object);
        }
    }
}
