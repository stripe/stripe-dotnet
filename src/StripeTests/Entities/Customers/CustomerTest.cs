namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class CustomerTest : BaseStripeTest
    {
        public CustomerTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/customers/cus_123");
            var customer = JsonConvert.DeserializeObject<Customer>(json);
            Assert.NotNull(customer);
            Assert.IsType<Customer>(customer);
            Assert.NotNull(customer.Id);
            Assert.Equal("customer", customer.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "invoice_settings.default_payment_method",
            };

            string json = this.GetFixture("/v1/customers/cus_123", expansions);
            var customer = JsonConvert.DeserializeObject<Customer>(json);
            Assert.NotNull(customer);
            Assert.IsType<Customer>(customer);
            Assert.NotNull(customer.Id);
            Assert.Equal("customer", customer.Object);

            Assert.NotNull(customer.InvoiceSettings.DefaultPaymentMethod);
            Assert.Equal("payment_method", customer.InvoiceSettings.DefaultPaymentMethod.Object);
        }

        [Fact]
        public void DeserializeWithExpansionsDefaultSource()
        {
            var json = GetResourceAsString("api_fixtures.customer_with_expansions.json");
            var customer = JsonConvert.DeserializeObject<Customer>(json);

            Assert.NotNull(customer);
            Assert.IsType<Customer>(customer);
            Assert.NotNull(customer.Id);
            Assert.Equal("customer", customer.Object);
            Assert.Equal(EpochTime.ConvertEpochToDateTime(1234567890), customer.Created);

            Assert.NotNull(customer.DefaultSource);
            Assert.IsType<Card>(customer.DefaultSource);
            Assert.Equal("card", customer.DefaultSource.Object);
        }
    }
}
