namespace StripeTests
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class CountrySpecServiceTest : BaseStripeTest
    {
        private const string CountrySpecId = "US";

        private readonly CountrySpecService service;
        private readonly CountrySpecListOptions listOptions;

        public CountrySpecServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new CountrySpecService(this.StripeClient);

            this.listOptions = new CountrySpecListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Get()
        {
            var countrySpec = this.service.Get(CountrySpecId);
            this.AssertRequest(HttpMethod.Get, "/v1/country_specs/US");
            Assert.NotNull(countrySpec);
            Assert.Equal("country_spec", countrySpec.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var countrySpec = await this.service.GetAsync(CountrySpecId);
            this.AssertRequest(HttpMethod.Get, "/v1/country_specs/US");
            Assert.NotNull(countrySpec);
            Assert.Equal("country_spec", countrySpec.Object);
        }

        [Fact]
        public void List()
        {
            var countrySpecs = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/country_specs");
            Assert.NotNull(countrySpecs);
            Assert.Equal("list", countrySpecs.Object);
            Assert.Single(countrySpecs.Data);
            Assert.Equal("country_spec", countrySpecs.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var countrySpecs = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/country_specs");
            Assert.NotNull(countrySpecs);
            Assert.Equal("list", countrySpecs.Object);
            Assert.Single(countrySpecs.Data);
            Assert.Equal("country_spec", countrySpecs.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var countrySpec = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(countrySpec);
            Assert.Equal("country_spec", countrySpec.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var countrySpec = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(countrySpec);
            Assert.Equal("country_spec", countrySpec.Object);
        }
    }
}
