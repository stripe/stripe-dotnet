namespace StripeTests
{
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class CapabilityServiceTest : BaseStripeTest
    {
        private const string AccountId = "acct_123";
        private const string CapabilityId = "acap_123";

        private readonly CapabilityService service;
        private readonly CapabilityUpdateOptions updateOptions;
        private readonly CapabilityListOptions listOptions;

        public CapabilityServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new CapabilityService(this.StripeClient);

            this.updateOptions = new CapabilityUpdateOptions
            {
                Requested = true,
            };

            this.listOptions = new CapabilityListOptions
            {
            };
        }

        [Fact]
        public void Get()
        {
            var capability = this.service.Get(AccountId, CapabilityId);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts/acct_123/capabilities/acap_123");
            Assert.NotNull(capability);
            Assert.Equal("capability", capability.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var capability = await this.service.GetAsync(AccountId, CapabilityId);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts/acct_123/capabilities/acap_123");
            Assert.NotNull(capability);
            Assert.Equal("capability", capability.Object);
        }

        [Fact]
        public void List()
        {
            var capabilities = this.service.List(AccountId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts/acct_123/capabilities");
            Assert.NotNull(capabilities);
            Assert.Equal("list", capabilities.Object);
            Assert.Single(capabilities.Data);
            Assert.Equal("capability", capabilities.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var capabilities = await this.service.ListAsync(AccountId, this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/accounts/acct_123/capabilities");
            Assert.NotNull(capabilities);
            Assert.Equal("list", capabilities.Object);
            Assert.Single(capabilities.Data);
            Assert.Equal("capability", capabilities.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var capabilitie = this.service.ListAutoPaging(AccountId, this.listOptions).First();
            Assert.NotNull(capabilitie);
            Assert.Equal("capability", capabilitie.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var capabilitie = await this.service.ListAutoPagingAsync(AccountId, this.listOptions).FirstAsync();
            Assert.NotNull(capabilitie);
            Assert.Equal("capability", capabilitie.Object);
        }

        [Fact]
        public void Update()
        {
            var capability = this.service.Update(AccountId, CapabilityId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123/capabilities/acap_123");
            Assert.NotNull(capability);
            Assert.Equal("capability", capability.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var capability = await this.service.UpdateAsync(AccountId, CapabilityId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/accounts/acct_123/capabilities/acap_123");
            Assert.NotNull(capability);
            Assert.Equal("capability", capability.Object);
        }
    }
}
