namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class MandateServiceTest : BaseStripeTest
    {
        private const string MandateId = "mandate_123";

        private readonly MandateService service;

        public MandateServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new MandateService(this.StripeClient);
        }

        [Fact]
        public void Get()
        {
            var mandate = this.service.Get(MandateId);
            this.AssertRequest(HttpMethod.Get, "/v1/mandates/mandate_123");
            Assert.NotNull(mandate);
            Assert.Equal("mandate", mandate.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var mandate = await this.service.GetAsync(MandateId);
            this.AssertRequest(HttpMethod.Get, "/v1/mandates/mandate_123");
            Assert.NotNull(mandate);
            Assert.Equal("mandate", mandate.Object);
        }
    }
}
