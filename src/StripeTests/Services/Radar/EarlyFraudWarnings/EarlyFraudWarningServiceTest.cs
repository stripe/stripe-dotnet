namespace StripeTests.Radar
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe.Radar;
    using Xunit;

    public class EarlyFraudWarningServiceTest : BaseStripeTest
    {
        private const string EarlyFraudWarningId = "issfr_123";

        private readonly EarlyFraudWarningService service;
        private readonly EarlyFraudWarningListOptions listOptions;

        public EarlyFraudWarningServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new EarlyFraudWarningService(this.StripeClient);

            this.listOptions = new EarlyFraudWarningListOptions
            {
                Charge = "ch_123",
                Limit = 1,
            };
        }

        [Fact]
        public void Get()
        {
            var warning = this.service.Get(EarlyFraudWarningId);
            this.AssertRequest(HttpMethod.Get, "/v1/radar/early_fraud_warnings/issfr_123");
            Assert.NotNull(warning);
            Assert.Equal("radar.early_fraud_warning", warning.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var warning = await this.service.GetAsync(EarlyFraudWarningId);
            this.AssertRequest(HttpMethod.Get, "/v1/radar/early_fraud_warnings/issfr_123");
            Assert.NotNull(warning);
            Assert.Equal("radar.early_fraud_warning", warning.Object);
        }

        [Fact]
        public void List()
        {
            var warnings = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/radar/early_fraud_warnings");
            Assert.NotNull(warnings);
            Assert.Equal("list", warnings.Object);
            Assert.Single(warnings.Data);
            Assert.Equal("radar.early_fraud_warning", warnings.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var warnings = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/radar/early_fraud_warnings");
            Assert.NotNull(warnings);
            Assert.Equal("list", warnings.Object);
            Assert.Single(warnings.Data);
            Assert.Equal("radar.early_fraud_warning", warnings.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var warning = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(warning);
            Assert.Equal("radar.early_fraud_warning", warning.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var warning = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(warning);
            Assert.Equal("radar.early_fraud_warning", warning.Object);
        }
    }
}
