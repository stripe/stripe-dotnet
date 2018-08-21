namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeCustomerTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/customers/cus_123");
            var customer = Mapper<StripeCustomer>.MapFromJson(json);
            Assert.NotNull(customer);
            Assert.IsType<StripeCustomer>(customer);
            Assert.NotNull(customer.Id);
            Assert.Equal("customer", customer.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            var json = GetResourceAsString("api_fixtures.customer_with_expansions.json");
            var customer = Mapper<StripeCustomer>.MapFromJson(json);

            Assert.NotNull(customer);
            Assert.IsType<StripeCustomer>(customer);
            Assert.NotNull(customer.Id);
            Assert.Equal("customer", customer.Object);

            Assert.NotNull(customer.DefaultSource);
            Assert.Equal(PaymentSourceType.Card, customer.DefaultSource.Type);
            Assert.NotNull(customer.DefaultSource.Card);
            Assert.Equal("card", customer.DefaultSource.Card.Object);
        }
    }
}
