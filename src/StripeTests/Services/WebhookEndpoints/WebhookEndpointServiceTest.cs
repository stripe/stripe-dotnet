namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class WebhookEndpointServiceTest : BaseStripeTest
    {
        private const string WebhookEndpointId = "we_123";

        private readonly WebhookEndpointService service;
        private readonly WebhookEndpointCreateOptions createOptions;
        private readonly WebhookEndpointUpdateOptions updateOptions;
        private readonly WebhookEndpointListOptions listOptions;

        public WebhookEndpointServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new WebhookEndpointService(this.StripeClient);

            this.createOptions = new WebhookEndpointCreateOptions
            {
                EnabledEvents = new List<string>
                {
                    "charge.succeeded",
                },
                Url = "https://stripe.com",
            };

            this.updateOptions = new WebhookEndpointUpdateOptions
            {
                EnabledEvents = new List<string>
                {
                    "charge.succeeded",
                },
            };

            this.listOptions = new WebhookEndpointListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var endpoint = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/webhook_endpoints");
            Assert.NotNull(endpoint);
            Assert.Equal("webhook_endpoint", endpoint.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var endpoint = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/webhook_endpoints");
            Assert.NotNull(endpoint);
            Assert.Equal("webhook_endpoint", endpoint.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(WebhookEndpointId);
            this.AssertRequest(HttpMethod.Delete, "/v1/webhook_endpoints/we_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(WebhookEndpointId);
            this.AssertRequest(HttpMethod.Delete, "/v1/webhook_endpoints/we_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var endpoint = this.service.Get(WebhookEndpointId);
            this.AssertRequest(HttpMethod.Get, "/v1/webhook_endpoints/we_123");
            Assert.NotNull(endpoint);
            Assert.Equal("webhook_endpoint", endpoint.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var endpoint = await this.service.GetAsync(WebhookEndpointId);
            this.AssertRequest(HttpMethod.Get, "/v1/webhook_endpoints/we_123");
            Assert.NotNull(endpoint);
            Assert.Equal("webhook_endpoint", endpoint.Object);
        }

        [Fact]
        public void List()
        {
            var endpoints = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/webhook_endpoints");
            Assert.NotNull(endpoints);
            Assert.Equal("list", endpoints.Object);
            Assert.Single(endpoints.Data);
            Assert.Equal("webhook_endpoint", endpoints.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var endpoints = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/webhook_endpoints");
            Assert.NotNull(endpoints);
            Assert.Equal("list", endpoints.Object);
            Assert.Single(endpoints.Data);
            Assert.Equal("webhook_endpoint", endpoints.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var endpoint = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(endpoint);
            Assert.Equal("webhook_endpoint", endpoint.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var endpoint = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(endpoint);
            Assert.Equal("webhook_endpoint", endpoint.Object);
        }

        [Fact]
        public void Update()
        {
            var endpoint = this.service.Update(WebhookEndpointId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/webhook_endpoints/we_123");
            Assert.NotNull(endpoint);
            Assert.Equal("webhook_endpoint", endpoint.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var endpoint = await this.service.UpdateAsync(WebhookEndpointId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/webhook_endpoints/we_123");
            Assert.NotNull(endpoint);
            Assert.Equal("webhook_endpoint", endpoint.Object);
        }
    }
}
