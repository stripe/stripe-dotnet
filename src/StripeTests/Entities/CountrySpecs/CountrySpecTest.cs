namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class CountrySpecTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/country_specs/US");
            var countrySpec = JsonConvert.DeserializeObject<CountrySpec>(json);
            Assert.NotNull(countrySpec);
            Assert.IsType<CountrySpec>(countrySpec);
            Assert.NotNull(countrySpec.Id);
            Assert.Equal("country_spec", countrySpec.Object);
        }
    }
}
