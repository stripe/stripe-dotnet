namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class StripeCouponCreateOptionsTest : BaseStripeTest
    {
        private StripeCouponService service;

        public StripeCouponCreateOptionsTest()
        {
            this.service = new StripeCouponService();
        }

        [Fact]
        public void Serialize()
        {
            var options = new StripeCouponCreateOptions()
            {
                PercentOff = 25,
                Duration = "forever",
            };

            var url = this.service.ApplyAllParameters(options, string.Empty, false);
            Assert.Equal("?percent_off=25&duration=forever", url);
        }
    }
}
