namespace StripeTests.BillingPortal
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Stripe.BillingPortal;
    using Xunit;

    public class ConfigurationServiceTest : BaseStripeTest
    {
        private const string ConfigurationId = "bpc_123";
        private readonly ConfigurationService service;
        private readonly ConfigurationCreateOptions createOptions;
        private readonly ConfigurationUpdateOptions updateOptions;

        public ConfigurationServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new ConfigurationService(this.StripeClient);

            this.createOptions = new ConfigurationCreateOptions
            {
                BusinessProfile = new ConfigurationBusinessProfileOptions
                {
                  PrivacyPolicyUrl = "https://example.com/privacy",
                  TermsOfServiceUrl = "https://example.com/tos",
                },
                Features = new ConfigurationFeaturesOptions
                {
                  CustomerUpdate = new ConfigurationFeaturesCustomerUpdateOptions
                  {
                    AllowedUpdates = new List<string> { "address" },
                    Enabled = true,
                  },
                },
            };
            this.updateOptions = new ConfigurationUpdateOptions
            {
              Active = false,
            };
        }

        [Fact]
        public void Create()
        {
            var configuration = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/billing_portal/configurations");
            Assert.NotNull(configuration);
            Assert.Equal("billing_portal.configuration", configuration.Object);
        }

        [Fact]
        public void Update()
        {
            var configuration = this.service.Update("bpc_123", this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/billing_portal/configurations/bpc_123");
            Assert.NotNull(configuration);
            Assert.Equal("billing_portal.configuration", configuration.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var configuration = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/billing_portal/configurations");
            Assert.NotNull(configuration);
            Assert.Equal("billing_portal.configuration", configuration.Object);
        }
    }
}
