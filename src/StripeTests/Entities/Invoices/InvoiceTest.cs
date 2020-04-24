namespace StripeTests
{
    using System.Collections.Generic;
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
            // TODO: assert that tax_rate is not null. Today stripe-mock does not support this
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

        [Fact]
        public void DeserializeWithDiscountsNull()
        {
            string json = "{\"object\": \"invoice\", \"discounts\": null}";
            var invoice = JsonConvert.DeserializeObject<Invoice>(json);
            Assert.NotNull(invoice);
            Assert.IsType<Invoice>(invoice);
            Assert.Equal("invoice", invoice.Object);

            Assert.Null(invoice.DiscountIds);

            Assert.Null(invoice.Discounts);
        }

        [Fact]
        public void DeserializeWithDiscountsEmpty()
        {
            string json = "{\"object\": \"invoice\", \"discounts\": []}";
            var invoice = JsonConvert.DeserializeObject<Invoice>(json);
            Assert.NotNull(invoice);
            Assert.IsType<Invoice>(invoice);
            Assert.Equal("invoice", invoice.Object);

            Assert.NotNull(invoice.DiscountIds);
            Assert.Empty(invoice.DiscountIds);

            Assert.NotNull(invoice.Discounts);
            Assert.Empty(invoice.Discounts);
        }

        [Fact]
        public void DeserializeWithDiscountsUnexpanded()
        {
            string json = "{\"object\": \"invoice\", \"discounts\": [\"di_123\", \"di_456\"]}";
            var invoice = JsonConvert.DeserializeObject<Invoice>(json);
            Assert.NotNull(invoice);
            Assert.IsType<Invoice>(invoice);
            Assert.Equal("invoice", invoice.Object);

            Assert.NotNull(invoice.DiscountIds);
            Assert.Equal(2, invoice.DiscountIds.Count);
            Assert.Equal("di_123", invoice.DiscountIds[0]);
            Assert.Equal("di_456", invoice.DiscountIds[1]);

            Assert.NotNull(invoice.Discounts);
            Assert.Equal(2, invoice.Discounts.Count);
            Assert.Null(invoice.Discounts[0]);
            Assert.Null(invoice.Discounts[1]);
        }

        [Fact]
        public void DeserializeWithDiscountsExpanded()
        {
            string json = "{\"object\": \"invoice\", \"discounts\": [{\"id\": \"di_123\", \"object\": \"discount\"}, {\"id\": \"di_456\", \"object\": \"discount\"}]}";
            var invoice = JsonConvert.DeserializeObject<Invoice>(json);
            Assert.NotNull(invoice);
            Assert.IsType<Invoice>(invoice);
            Assert.Equal("invoice", invoice.Object);

            Assert.NotNull(invoice.DiscountIds);
            Assert.Equal(2, invoice.DiscountIds.Count);
            Assert.Equal("di_123", invoice.DiscountIds[0]);
            Assert.Equal("di_456", invoice.DiscountIds[1]);

            Assert.NotNull(invoice.Discounts);
            Assert.Equal(2, invoice.Discounts.Count);
            Assert.NotNull(invoice.Discounts[0]);
            Assert.Equal("di_123", invoice.Discounts[0].Id);
            Assert.Equal("discount", invoice.Discounts[0].Object);
            Assert.NotNull(invoice.Discounts[1]);
            Assert.Equal("di_456", invoice.Discounts[1].Id);
            Assert.Equal("discount", invoice.Discounts[1].Object);
        }

        [Fact]
        public void SerializeWithDiscountIdsNull()
        {
            string json = this.GetFixture("/v1/invoices/in_123");
            var invoice = JsonConvert.DeserializeObject<Invoice>(json);
            invoice.DiscountIds = null;

            var serialized = invoice.ToJson();
            var deserialized = Invoice.FromJson(serialized);

            Assert.NotNull(deserialized);

            Assert.Null(deserialized.DiscountIds);

            Assert.Null(deserialized.Discounts);
        }

        [Fact]
        public void SerializeWithDiscountsNull()
        {
            string json = this.GetFixture("/v1/invoices/in_123");
            var invoice = JsonConvert.DeserializeObject<Invoice>(json);
            invoice.Discounts = null;

            var serialized = invoice.ToJson();
            var deserialized = Invoice.FromJson(serialized);

            Assert.NotNull(deserialized);

            Assert.Null(deserialized.DiscountIds);

            Assert.Null(deserialized.Discounts);
        }

        [Fact]
        public void SerializeWithDiscountIdsEmpty()
        {
            string json = this.GetFixture("/v1/invoices/in_123");
            var invoice = JsonConvert.DeserializeObject<Invoice>(json);
            invoice.DiscountIds = new List<string>();

            var serialized = invoice.ToJson();
            var deserialized = Invoice.FromJson(serialized);

            Assert.NotNull(deserialized);

            Assert.NotNull(deserialized.DiscountIds);
            Assert.Empty(deserialized.DiscountIds);

            Assert.NotNull(deserialized.Discounts);
            Assert.Empty(deserialized.Discounts);
        }

        [Fact]
        public void SerializeWithDiscountsEmpty()
        {
            string json = this.GetFixture("/v1/invoices/in_123");
            var invoice = JsonConvert.DeserializeObject<Invoice>(json);
            invoice.Discounts = new List<Discount>();

            var serialized = invoice.ToJson();
            var deserialized = Invoice.FromJson(serialized);

            Assert.NotNull(deserialized);

            Assert.NotNull(deserialized.DiscountIds);
            Assert.Empty(deserialized.DiscountIds);

            Assert.NotNull(deserialized.Discounts);
            Assert.Empty(deserialized.Discounts);
        }

        [Fact]
        public void SerializeWithDiscountIdsNotEmpty()
        {
            string json = this.GetFixture("/v1/invoices/in_123");
            var invoice = JsonConvert.DeserializeObject<Invoice>(json);
            invoice.DiscountIds = new List<string> { "di_123", "di_456" };

            var serialized = invoice.ToJson();
            var deserialized = Invoice.FromJson(serialized);

            Assert.NotNull(deserialized);

            Assert.NotNull(deserialized.DiscountIds);
            Assert.Equal(2, deserialized.DiscountIds.Count);
            Assert.Equal("di_123", deserialized.DiscountIds[0]);
            Assert.Equal("di_456", deserialized.DiscountIds[1]);

            Assert.NotNull(deserialized.Discounts);
            Assert.Equal(2, deserialized.Discounts.Count);
            Assert.Null(deserialized.Discounts[0]);
            Assert.Null(deserialized.Discounts[1]);
        }

        [Fact]
        public void SerializeWithDiscountsNotEmpty()
        {
            var discount1 = new Discount();
            discount1.Id = "di_123";
            discount1.Object = "discount";

            var discount2 = new Discount();
            discount2.Id = "di_456";
            discount2.Object = "discount";

            string json = this.GetFixture("/v1/invoices/in_123");
            var invoice = JsonConvert.DeserializeObject<Invoice>(json);
            invoice.Discounts = new List<Discount> { discount1, discount2 };

            var serialized = invoice.ToJson();
            var deserialized = Invoice.FromJson(serialized);

            Assert.NotNull(deserialized);

            Assert.NotNull(deserialized.DiscountIds);
            Assert.Equal(2, deserialized.DiscountIds.Count);
            Assert.Equal("di_123", deserialized.DiscountIds[0]);
            Assert.Equal("di_456", deserialized.DiscountIds[1]);

            Assert.NotNull(deserialized.Discounts);
            Assert.Equal(2, deserialized.Discounts.Count);
            Assert.NotNull(deserialized.Discounts[0]);
            Assert.Equal("di_123", deserialized.Discounts[0].Id);
            Assert.Equal("discount", deserialized.Discounts[0].Object);
            Assert.NotNull(deserialized.Discounts[1]);
            Assert.Equal("di_456", deserialized.Discounts[1].Id);
            Assert.Equal("discount", deserialized.Discounts[1].Object);
        }
    }
}
