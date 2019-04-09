namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class InvoiceTest : BaseStripeTest
    {
        public InvoiceTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/invoices/in_123");
            var invoice = JsonConvert.DeserializeObject<Invoice>(json);
            Assert.NotNull(invoice);
            Assert.IsType<Invoice>(invoice);
            Assert.NotNull(invoice.Id);
            Assert.Equal("invoice", invoice.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "charge",
              "customer",
              "default_payment_method",
              "payment_intent",
              "subscription",
            };

            string json = this.GetFixture("/v1/invoices/in_123", expansions);
            var invoice = JsonConvert.DeserializeObject<Invoice>(json);
            Assert.NotNull(invoice);
            Assert.IsType<Invoice>(invoice);
            Assert.NotNull(invoice.Id);
            Assert.Equal("invoice", invoice.Object);

            Assert.NotNull(invoice.Charge);
            Assert.Equal("charge", invoice.Charge.Object);

            Assert.NotNull(invoice.Customer);
            Assert.Equal("customer", invoice.Customer.Object);

            Assert.NotNull(invoice.DefaultPaymentMethod);
            Assert.Equal("payment_method", invoice.DefaultPaymentMethod.Object);

            Assert.NotNull(invoice.PaymentIntent);
            Assert.Equal("payment_intent", invoice.PaymentIntent.Object);

            Assert.NotNull(invoice.Subscription);
            Assert.Equal("subscription", invoice.Subscription.Object);
        }
    }
}
