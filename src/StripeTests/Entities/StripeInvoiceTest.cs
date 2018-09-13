namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class InvoiceTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/invoices/in_123");
            var invoice = Mapper<Invoice>.MapFromJson(json);
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
              "subscription",
            };

            string json = GetFixture("/v1/invoices/in_123", expansions);
            var invoice = Mapper<Invoice>.MapFromJson(json);
            Assert.NotNull(invoice);
            Assert.IsType<Invoice>(invoice);
            Assert.NotNull(invoice.Id);
            Assert.Equal("invoice", invoice.Object);

            Assert.NotNull(invoice.Charge);
            Assert.Equal("charge", invoice.Charge.Object);

            Assert.NotNull(invoice.Customer);
            Assert.Equal("customer", invoice.Customer.Object);

            Assert.NotNull(invoice.Subscription);
            Assert.Equal("subscription", invoice.Subscription.Object);
        }
    }
}
