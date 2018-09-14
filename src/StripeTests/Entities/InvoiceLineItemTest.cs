namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class InvoiceLineItemTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/invoiceitems/ii_123");
            var invoiceItem = Mapper<InvoiceLineItem>.MapFromJson(json);
            Assert.NotNull(invoiceItem);
            Assert.IsType<InvoiceLineItem>(invoiceItem);
            Assert.NotNull(invoiceItem.Id);
            Assert.Equal("invoiceitem", invoiceItem.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "customer",
              "invoice",
              "subscription",
            };

            string json = GetFixture("/v1/invoiceitems/ii_123", expansions);
            var invoiceItem = Mapper<InvoiceLineItem>.MapFromJson(json);
            Assert.NotNull(invoiceItem);
            Assert.IsType<InvoiceLineItem>(invoiceItem);
            Assert.NotNull(invoiceItem.Id);
            Assert.Equal("invoiceitem", invoiceItem.Object);

            Assert.NotNull(invoiceItem.Customer);
            Assert.Equal("customer", invoiceItem.Customer.Object);

            Assert.NotNull(invoiceItem.Invoice);
            Assert.Equal("invoice", invoiceItem.Invoice.Object);

            Assert.NotNull(invoiceItem.Subscription);
            Assert.Equal("subscription", invoiceItem.Subscription.Object);
        }
    }
}
