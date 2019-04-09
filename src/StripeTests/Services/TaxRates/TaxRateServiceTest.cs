namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class TaxRateServiceTest : BaseStripeTest
    {
        private const string TaxRateId = "txr_123";

        private readonly TaxRateService service;
        private readonly TaxRateCreateOptions createOptions;
        private readonly TaxRateUpdateOptions updateOptions;
        private readonly TaxRateListOptions listOptions;

        public TaxRateServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new TaxRateService();

            this.createOptions = new TaxRateCreateOptions
            {
                DisplayName = "Name",
                Inclusive = true,
                Percentage = 12.5m,
            };

            this.updateOptions = new TaxRateUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new TaxRateListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var taxRate = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/tax_rates");
            Assert.NotNull(taxRate);
            Assert.Equal("tax_rate", taxRate.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var taxRate = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/tax_rates");
            Assert.NotNull(taxRate);
            Assert.Equal("tax_rate", taxRate.Object);
        }

        [Fact]
        public void Get()
        {
            var taxRate = this.service.Get(TaxRateId);
            this.AssertRequest(HttpMethod.Get, "/v1/tax_rates/txr_123");
            Assert.NotNull(taxRate);
            Assert.Equal("tax_rate", taxRate.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var taxRate = await this.service.GetAsync(TaxRateId);
            this.AssertRequest(HttpMethod.Get, "/v1/tax_rates/txr_123");
            Assert.NotNull(taxRate);
            Assert.Equal("tax_rate", taxRate.Object);
        }

        [Fact]
        public void List()
        {
            var taxRates = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/tax_rates");
            Assert.NotNull(taxRates);
            Assert.Equal("list", taxRates.Object);
            Assert.Single(taxRates.Data);
            Assert.Equal("tax_rate", taxRates.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var taxRates = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/tax_rates");
            Assert.NotNull(taxRates);
            Assert.Equal("list", taxRates.Object);
            Assert.Single(taxRates.Data);
            Assert.Equal("tax_rate", taxRates.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var taxRates = this.service.ListAutoPaging(this.listOptions).ToList();
            Assert.NotNull(taxRates);
            Assert.Equal("tax_rate", taxRates[0].Object);
        }

        [Fact]
        public void Update()
        {
            var taxRate = this.service.Update(TaxRateId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/tax_rates/txr_123");
            Assert.NotNull(taxRate);
            Assert.Equal("tax_rate", taxRate.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var taxRate = await this.service.UpdateAsync(TaxRateId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/tax_rates/txr_123");
            Assert.NotNull(taxRate);
            Assert.Equal("tax_rate", taxRate.Object);
        }
    }
}
