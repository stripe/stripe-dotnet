namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class CustomerTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/customers/cus_123");
            var customer = JsonConvert.DeserializeObject<Customer>(json);
            Assert.NotNull(customer);
            Assert.IsType<Customer>(customer);
            Assert.NotNull(customer.Id);
            Assert.Equal("customer", customer.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
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
