namespace StripeTests
{
    using System.Text.Json;
    using Stripe;
    using Xunit;

    public class ApplePayDomainTest : BaseStripeTest
    {
        public ApplePayDomainTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/apple_pay/domains/apwc_123");
            var domain = JsonSerializer.Deserialize<ApplePayDomain>(json);
            Assert.NotNull(domain);
            Assert.IsType<ApplePayDomain>(domain);
            Assert.NotNull(domain.Id);
            Assert.Equal("apple_pay_domain", domain.Object);
        }
    }
}
