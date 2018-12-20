namespace StripeTests
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class ExchangeRateServiceTest : BaseStripeTest
    {
        private readonly ExchangeRateService service;
        private readonly ExchangeRateListOptions listOptions;

        public ExchangeRateServiceTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new ExchangeRateService();

            this.listOptions = new ExchangeRateListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Get()
        {
            var exchangeRate = this.service.Get("usd");
            this.AssertRequest(HttpMethod.Get, "/v1/exchange_rates/usd");
            Assert.NotNull(exchangeRate);
            Assert.Equal("exchange_rate", exchangeRate.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var exchangeRate = await this.service.GetAsync("usd");
            this.AssertRequest(HttpMethod.Get, "/v1/exchange_rates/usd");
            Assert.NotNull(exchangeRate);
            Assert.Equal("exchange_rate", exchangeRate.Object);
        }

        [Fact]
        public void List()
        {
            var exchangeRates = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/exchange_rates");
            Assert.NotNull(exchangeRates);
            Assert.Equal("list", exchangeRates.Object);
            Assert.Single(exchangeRates.Data);
            Assert.Equal("exchange_rate", exchangeRates.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var exchangeRates = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/exchange_rates");
            Assert.NotNull(exchangeRates);
            Assert.Equal("list", exchangeRates.Object);
            Assert.Single(exchangeRates.Data);
            Assert.Equal("exchange_rate", exchangeRates.Data[0].Object);
        }
    }
}
