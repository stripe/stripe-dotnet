namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class CountrySpecServiceTest : BaseStripeTest
    {
        private const string CountrySpecId = "US";

        private CountrySpecService service;
        private CountrySpecListOptions listOptions;

        public CountrySpecServiceTest()
        {
            this.service = new CountrySpecService();

            this.listOptions = new CountrySpecListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Get()
        {
            var countrySpec = this.service.Get(CountrySpecId);
            Assert.NotNull(countrySpec);
            Assert.Equal("country_spec", countrySpec.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var countrySpec = await this.service.GetAsync(CountrySpecId);
            Assert.NotNull(countrySpec);
            Assert.Equal("country_spec", countrySpec.Object);
        }

        [Fact]
        public void List()
        {
            var countrySpecs = this.service.List(this.listOptions);
            Assert.NotNull(countrySpecs);
            Assert.Equal("list", countrySpecs.Object);
            Assert.Single(countrySpecs.Data);
            Assert.Equal("country_spec", countrySpecs.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var countrySpecs = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(countrySpecs);
            Assert.Equal("list", countrySpecs.Object);
            Assert.Single(countrySpecs.Data);
            Assert.Equal("country_spec", countrySpecs.Data[0].Object);
        }
    }
}
