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
        private readonly ConfigurationListOptions listOptions;

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
            this.listOptions = new ConfigurationListOptions
            {
                Active = true,
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

        [Fact]
        public void Get()
        {
            var configuration = this.service.Get(ConfigurationId);
            this.AssertRequest(HttpMethod.Get, "/v1/billing_portal/configurations/bpc_123");
            Assert.NotNull(configuration);
            Assert.Equal("billing_portal.configuration", configuration.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var configuration = await this.service.GetAsync(ConfigurationId);
            this.AssertRequest(HttpMethod.Get, "/v1/billing_portal/configurations/bpc_123");
            Assert.NotNull(configuration);
            Assert.Equal("billing_portal.configuration", configuration.Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var configurations = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/billing_portal/configurations");
            Assert.NotNull(configurations);
            Assert.Equal("list", configurations.Object);
            Assert.Single(configurations.Data);
            Assert.Equal("billing_portal.configuration", configurations.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var configuration = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(configuration);
            Assert.Equal("billing_portal.configuration", configuration.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var configuration = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(configuration);
            Assert.Equal("billing_portal.configuration", configuration.Object);
        }
    }
}
