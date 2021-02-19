namespace StripeTests.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.BillingPortal;
    using Xunit;

    public class ConfigurationTest : BaseStripeTest
    {
        public ConfigurationTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.billing_portal.configuration.json");
            var configuration = JsonConvert.DeserializeObject<Configuration>(json);
            Assert.NotNull(configuration);
            Assert.IsType<Configuration>(configuration);
            Assert.NotNull(configuration.Id);
            Assert.Equal("billing_portal.configuration", configuration.Object);
        }
    }
}
