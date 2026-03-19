namespace StripeTests
{
    using System.Text.Json;
    using Stripe;
    using Xunit;

    public class CountrySpecTest : BaseStripeTest
    {
        public CountrySpecTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/country_specs/US");
            var countrySpec = JsonSerializer.Deserialize<CountrySpec>(json);
            Assert.NotNull(countrySpec);
            Assert.IsType<CountrySpec>(countrySpec);
            Assert.NotNull(countrySpec.Id);
            Assert.Equal("country_spec", countrySpec.Object);
        }
    }
}
