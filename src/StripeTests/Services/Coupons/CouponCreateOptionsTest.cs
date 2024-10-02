namespace StripeTests
{
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class CouponCreateOptionsTest : BaseStripeTest
    {
        [Fact]
        public void Serialize()
        {
            var options = new CouponCreateOptions
            {
                PercentOff = 25,
                Duration = "forever",
            };

            Assert.Equal("duration=forever&percent_off=25", FormEncoder.CreateQueryString(options));
        }
    }
}
