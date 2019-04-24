namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class TaxRateTest : BaseStripeTest
    {
        public TaxRateTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/tax_rates/txr_123");
            var taxRate = JsonConvert.DeserializeObject<TaxRate>(json);
            Assert.NotNull(taxRate);
            Assert.IsType<TaxRate>(taxRate);
            Assert.NotNull(taxRate.Id);
            Assert.Equal("tax_rate", taxRate.Object);
        }
    }
}
