namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class ThreeDSecureServiceTest : BaseStripeTest
    {
        private ThreeDSecureService service;
        private ThreeDSecureCreateOptions createOptions;

        public ThreeDSecureServiceTest()
        {
            this.service = new ThreeDSecureService();

            this.createOptions = new ThreeDSecureCreateOptions()
            {
                Amount = 25,
                Currency = "eur",
                ReturnUrl = "https://stripe.com",
            };
        }

        [Fact]
        public void Create()
        {
            var threeDSecure = this.service.Create(this.createOptions);
            Assert.NotNull(threeDSecure);
            Assert.Equal("three_d_secure", threeDSecure.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var threeDSecure = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(threeDSecure);
            Assert.Equal("three_d_secure", threeDSecure.Object);
        }
    }
}
