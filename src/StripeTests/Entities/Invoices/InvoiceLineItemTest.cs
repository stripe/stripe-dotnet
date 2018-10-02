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
            string json = GetFixture("/v1/invoices/in_123/lines");
            var lineItems = Mapper<StripeList<InvoiceLineItem>>.MapFromJson(json);
            Assert.NotNull(lineItems);

            InvoiceLineItem lineItem = lineItems.Data[0];
            Assert.NotNull(lineItem);
            Assert.IsType<InvoiceLineItem>(lineItem);
            Assert.NotNull(lineItem.Id);
            Assert.Equal("line_item", lineItem.Object);
        }
    }
}
